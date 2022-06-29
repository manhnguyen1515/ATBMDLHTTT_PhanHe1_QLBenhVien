using DoAn1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.GUI.Inspector
{
    public partial class F_Inspector : Form
    {
        public F_Inspector()
        {
            InitializeComponent();
        }

        private void F_Inspector_Load(object sender, EventArgs e)
        {
            LoadRecords();
            LoadServices();
            LoadEmployees();
            LoadPatients();
            LoadFacilities();
            LoadInfo();
        }

        private void LoadRecords()
        {
            string query = "SELECT * FROM ADMIN.HSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvMedicalRecords.DataSource = data;
        }

        private void LoadServices()
        {
            string query = "SELECT * FROM ADMIN.HSBA_DV JOIN ADMIN.HSBA ON HSBA_DV.MAHSBA = HSBA.MAHSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvServices.DataSource = data;
        }

        private void LoadEmployees()
        {
            string query = "SELECT * FROM ADMIN.NHANVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvEmployee.DataSource = data;
        }

        private void LoadPatients()
        {
            string query = "SELECT * FROM ADMIN.BENHNHAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvPatient.DataSource = data;
        }

        private void LoadFacilities()
        {
            string query = "SELECT * FROM ADMIN.CSYT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvFacility.DataSource = data;
        }

        private void LoadInfo()
        {
            string query = "SELECT * FROM ADMIN.NHANVIEN WHERE MANV = USER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txbFullname.Text = data.Rows[0].Field<string>(1);
                txbGender.Text = data.Rows[0].Field<string>(2);
                dtpkBirthDay.Value = data.Rows[0].Field<DateTime>(3);
                txbCitizenId.Text = data.Rows[0].Field<string>(4);
                txbAddress.Text = data.Rows[0].Field<string>(5);
                txbPhone.Text = data.Rows[0].Field<string>(6);
                txbFacility.Text = data.Rows[0].Field<string>(7);
                txbRole.Text = data.Rows[0].Field<string>(8);
                txbDepartment.Text = data.Rows[0].Field<string>(9);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DataProvider.Connection != null)
            {
                DataProvider.Connection.Close();
                DataProvider.Connection = null;
            }
            this.Close();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var fullname = txbFullname.Text;
            var gender = txbGender.Text;
            var birthDay = dtpkBirthDay.Value;
            var citizenId = txbCitizenId.Text;
            var address = txbAddress.Text;
            var phone = txbPhone.Text;
            var facility = txbFacility.Text;
            var role = txbRole.Text;
            var department = txbDepartment.Text;

            try
            {
                string query = "UPDATE ADMIN.NHANVIEN " +
                               "SET HOTEN = :fullname ," +
                               "    PHAI = :gender ," +
                               "    NGAYSINH = :birthday ," +
                               "    CMND = :citizenid ," +
                               "    QUEQUAN = :address ," +
                               "    SODT = :phone ," +
                               "    CSYT = :facility ," +
                               "    VAITRO = :role ," +
                               "    CHUYENKHOA = :department " +
                               "WHERE MANV = USER";

                var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                {
                  fullname,
                  gender,
                  birthDay,
                  citizenId,
                  address,
                  phone,
                  facility,
                  role,
                  department
                });

                if (cmd != null)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công\n");
                this.Close();
            }
        }
    }
}

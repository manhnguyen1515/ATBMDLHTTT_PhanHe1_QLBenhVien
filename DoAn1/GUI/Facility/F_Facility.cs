using DoAn1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.GUI.Facility
{
    public partial class F_Facility : Form
    {
        private List<string> _records;
        public F_Facility()
        {
            InitializeComponent();
        }

        private void F_Facility_Load(object sender, EventArgs e)
        {
            _records = new List<string>();
            LoadRecords();
            LoadServices();
            LoadInfo();
        }

        private void LoadRecords()
        {
            string query = "SELECT * FROM ADMIN.HSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvRecords.DataSource = data;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                _records.Add(data.Rows[i]["MAHSBA"].ToString());
            }
            cbbRecord.DataSource = _records;
        }

        private void LoadServices()
        {
            string record = cbbRecord.SelectedItem as string;
            string query = $"SELECT * FROM ADMIN.VIEW_CSYT_HSBA_DV WHERE MAHSBA = '{record}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvServices.DataSource = data;
        }

        private void LoadInfo()
        {
            string query = "SELECT * FROM ADMIN.NHANVIEN WHERE MANV = USER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if(data.Rows.Count > 0)
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

        private void cbbRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            Form addForm = new F_AddRecord();
            addForm.ShowDialog();
            LoadRecords();
        }

        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string mahsba = dtgvRecords.CurrentRow.Cells["MAHSBA"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba.proc_DEL( :mahsba ); END; END;";

                    var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mahsba });
                    MessageBox.Show("Hồ sơ bệnh án đã được xóa thành công!\n\n", "Kết quả");
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string mahsba = cbbRecord.SelectedItem as string;
            Form addForm = new F_AddService(mahsba);
            addForm.ShowDialog();
            LoadServices();
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            try
            {
                string mahsba = dtgvServices.CurrentRow.Cells["MAHSBA"].Value.ToString();
                string madv = dtgvServices.CurrentRow.Cells["MADV"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba_dv.proc_del( :mahsba , :madv ); END; END;";

                    var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mahsba, madv });
                    MessageBox.Show("Hồ sơ dịch vụ đã được xóa thành công!\n\n", "Kết quả");
                    LoadServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa!\n\n" + ex.Message, "Kết quả");
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
                MessageBox.Show("Cập nhật không thành công\n" + ex.Message);
                this.Close();
            }
        }
    }
}

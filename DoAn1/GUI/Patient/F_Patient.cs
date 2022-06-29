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

namespace DoAn1.GUI.Patient
{
    public partial class F_Patient : Form
    {
        public F_Patient()
        {
            InitializeComponent();
        }

        private void F_Manage_Patient_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            string query = "SELECT * FROM ADMIN.BENHNHAN WHERE MABN = USER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                txbFullname.Text = data.Rows[0].Field<string>(2);
                txbCitizenId.Text = data.Rows[0].Field<string>(3);
                dtpkBirthDay.Value = data.Rows[0].Field<DateTime>(4);
                txbNumberHome.Text = data.Rows[0].Field<string>(5);
                txbStreetName.Text = data.Rows[0].Field<string>(6);
                txbDistrict.Text = data.Rows[0].Field<string>(7);
                txbProvince.Text = data.Rows[0].Field<string>(8);
                txbMedicalHistory.Text = data.Rows[0].Field<string>(9);
                txbHistoryFamily.Text = data.Rows[0].Field<string>(10);
                txbDrugAllergy.Text = data.Rows[0].Field<string>(11);
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var fullname = txbFullname.Text;
            var citizenId = txbCitizenId.Text;
            var birthDay = dtpkBirthDay.Value;
            var numberHome = txbNumberHome.Text;
            var streetName = txbStreetName.Text;
            var district = txbDistrict.Text;
            var province = txbProvince.Text;
            var medicalHistory = txbMedicalHistory.Text;
            var historyFamily = txbHistoryFamily.Text;
            var drugAllergy = txbDrugAllergy.Text;

            try
            {
                string query = "UPDATE ADMIN.BENHNHAN " +
                               "SET TENBN = :fullname ," +
                               "    CMND = :citizenid ," +
                               "    NGAYSINH = :birthday ," +
                               "    SONHA = :numberhome ," +
                               "    TENDUONG = :streetname ," +
                               "    QUANHUYEN = :district ," +
                               "    TINHTP = :province ," +
                               "    TIENSUBENH = :medicalhistory ," +
                               "    TIENSUBENHGD = :historyfamily ," +
                               "    DIUNGTHUOC = :drugallergy " +
                               "WHERE MABN = USER";

                var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                {
                  fullname,
                  citizenId,
                  birthDay,
                  numberHome,
                  streetName,
                  district,
                  province,
                  medicalHistory,
                  historyFamily,
                  drugAllergy
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DataProvider.Connection != null)
            {
                DataProvider.Connection.Close();
                DataProvider.Connection = null;
            }
            this.Close();
        }

        
    }
}

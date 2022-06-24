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

namespace DoAn1.GUI.Admin
{
    public partial class F_CreateEmployee : Form
    {
        public F_CreateEmployee()
        {
            InitializeComponent();
        }

        private void F_CreateEmployee_Load(object sender, EventArgs e)
        {
            cbbGenders.DataSource = new List<string>() { "Nam", "Nữ" };
            cbbRoles.DataSource = GetRoles();
            cbbFacilities.DataSource = GetFacilities();
        }

        private List<string> GetRoles()
        {
            string query = "SELECT DISTINCT VAITRO FROM ADMIN.NHANVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<string> roles = new List<string>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                roles.Add(data.Rows[i]["VAITRO"].ToString());
            }

            return roles;
        }

        private List<string> GetFacilities()
        {
            string query = "SELECT DISTINCT MACSYT FROM ADMIN.CSYT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<string> result = new List<string>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                result.Add(data.Rows[i]["MACSYT"].ToString());
            }

            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetEmployeeId()
        {
            string query = "SELECT MANV FROM ( SELECT NV.*, max(NV.MANV) over () as max_pk FROM ADMIN.NHANVIEN NV ) WHERE MANV = max_pk";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string lastId = data.Rows[data.Rows.Count - 1]["MANV"].ToString();
            string firstPattern = lastId.Substring(0, 2);
            string lastPattern = lastId.Substring(2);
            int lastIdInt = Int32.Parse(lastPattern);

            string newId = $"{lastIdInt + 1}";
            for (int i = 0; i <= lastId.Length - newId.Length; i++ )
            {
                newId = "0" + newId;
            }
            newId = firstPattern + newId;
            return newId;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string id = GetEmployeeId();
            string fullName = txbFullname.Text;
            string gender = cbbGenders.SelectedItem.ToString();
            string citizenId = txbCitizenId.Text;
            string phone = txbPhone.Text;
            string facility = cbbFacilities.SelectedItem.ToString();
            string address = txbAddress.Text;
            string birthDay = $"TO_DATE('{dtpkBirthDay.Value.ToShortDateString()}', 'mm/dd/yyyy')";
            string role = cbbRoles.SelectedItem.ToString();
            string major = txbMajor.Text;

            string query = $"INSERT INTO ADMIN.NHANVIEN(MANV, HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA) VALUES" +
                $"('{id}', N'{fullName}', '{gender}', {birthDay}, '{citizenId}', N'{address}', '{phone}', '{facility}', N'{role}', N'{major}') ";

            try
            {
                var command = DataProvider.Instance.ExcuteNonQuery(query);
                if (command != null)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không thể thêm. \n" + ex.Message);
            }

            this.Close();
        }
    }
}

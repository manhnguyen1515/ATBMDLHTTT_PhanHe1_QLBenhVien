using DoAn1.DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class F_EditUser : Form
    {
        private string _username;
        public F_EditUser(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void F_EditUser_Load(object sender, EventArgs e)
        {
            txbUserName.Text = _username;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text != txbConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!\n\n");
                return;
            }
            try
            {
                string query = "BEGIN proc_OracleScript; BEGIN Alter_User( :n_username, :n_password ); END; END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { _username, txbPassword.Text });
                MessageBox.Show("User đã được chỉnh sửa thành thành công!\n\n", "Kết quả");
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa user!\n\n" + ex.Message, "Kết quả");
            }
        }
    }
}

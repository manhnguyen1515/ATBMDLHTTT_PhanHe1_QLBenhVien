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
using Oracle.ManagedDataAccess.Client;

namespace DoAn1
{
    public partial class F_CreateUser : Form
    {
        public F_CreateUser()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbPassword.Text != txbConfirmPass.Text)
                { 
                    MessageBox.Show("Mật khẩu không khớp!\n\n");
                    return;
                }
                string userName = txbUserName.Text;
                string pass = txbPassword.Text;
                string query = "BEGIN proc_OracleScript; BEGIN proc_CreateUser( :n_username , :n_password ); END; END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userName, pass });
                MessageBox.Show("User đã được tạo thành công!\n\n", "Kết quả");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo User!\n\n" + ex.Message, "Kết quả");
            }
        }

    }
}

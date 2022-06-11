using DoAn1.DAO;
using DoAn1.GUI.Patient;
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
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            using (OracleConnection conn = DataProvider.Instance.GetDBConnection("localhost", 1521, "xe", userName, passWord))
            {
                try
                {
                    conn.Open();
                    if (DataProvider.Connection == null)
                        DataProvider.Connection = conn;

                    Form form = null;
                   if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'BACSI'").Rows.Count > 0)
                   {
                        form = new F_Manage_Doctor();
                   }
                   else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'BENHNHAN'").Rows.Count > 0)
                    {
                        form = new F_Manage_Patient();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'THANHTRA'").Rows.Count > 0)
                    {
                        //form = new F_Manage_Doctor();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'CSYT'").Rows.Count > 0)
                    {
                        //form = new F_Manage_Doctor();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'NGHIENCUU'").Rows.Count > 0)
                    {
                        //form = new F_Manage_Doctor();
                    }
                    else
                   {
                       form = new F_Manager();
                   }
                    
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    DataProvider.Connection = null;
                }
            }
        }

        private void F_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                if(DataProvider.Connection != null)
                {
                    DataProvider.Connection.Close();
                    DataProvider.Connection = null;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

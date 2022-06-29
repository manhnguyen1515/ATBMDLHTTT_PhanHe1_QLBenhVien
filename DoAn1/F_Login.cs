using DoAn1.DAO;
using DoAn1.GUI.Facility;
using DoAn1.GUI.Inspector;
using DoAn1.GUI.Patient;
using DoAn1.GUI.Researcher;
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
                    if (DataProvider.Connection == null)
                        DataProvider.Connection = conn;
                   DataProvider.Connection.Open();
                   Form form = null;

                    if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'DBA_QLYTE'").Rows.Count > 0)
                    {
                        form = new F_Manager();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'BACSI'").Rows.Count > 0)
                   {
                        form = new F_Doctor();
                   }
                   else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'BENHNHAN'").Rows.Count > 0)
                    {
                        form = new F_Patient();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'THANHTRA'").Rows.Count > 0)
                    {
                        form = new F_Inspector();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'CSYT'").Rows.Count > 0)
                    {
                        form = new F_Facility();
                    }
                    else if (DataProvider.Instance.ExcuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE USERNAME = USER AND GRANTED_ROLE = 'NGHIENCUU'").Rows.Count > 0)
                    {
                        form = new F_Researcher();
                    }
                    else
                   {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!\n", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataProvider.Connection.Close();
                        DataProvider.Connection = null;
                        return;
                    }

                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!\n", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataProvider.Connection.Close();
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

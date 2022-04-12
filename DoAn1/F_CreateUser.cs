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
                    MessageBox.Show("Mat khau khong khop!\n\n");
                    return;
                }
                string userName = txbUserName.Text;
                string pass = txbPassword.Text;
                
                string query = "BEGIN proc_CreateUser('" + userName + "','" + pass +  "'); END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create User!\n\n" + ex.Message, "Result");
            }
        }

    }
}

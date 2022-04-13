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
            string query = "BEGIN proc_CreateUser( :n_username , :n_password ); END;";
            
            if (txbPassword.Text != txbConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { txbUserName.Text, txbPassword.Text });
            if(result <= 0)
            {
                MessageBox.Show("Không thành công!");
            }
               
        }
    }
}

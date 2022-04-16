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
    public partial class F_GrantRole : Form
    {
        private string _userName;
        public F_GrantRole(string UserName)
        {
            InitializeComponent();
            _userName = UserName;
        }

        private void F_GrantRole_Load(object sender, EventArgs e)
        {
            txbUserName.Text = _userName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "BEGIN proc_OracleScript; proc_GrantRoleForUser( :n_rolename, :n_username); END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { txbRoleName.Text, _userName});
                MessageBox.Show("Cấp role cho user thành công!\n\n", "Kết quả");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cấp role cho user!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

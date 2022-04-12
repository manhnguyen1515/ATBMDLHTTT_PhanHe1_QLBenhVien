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
    public partial class F_Manager : System.Windows.Forms.Form
    {
        public F_Manager()
        {
            InitializeComponent();
        }

        private void F_Manager_Load(object sender, EventArgs e)
        {
            string query = "begin proc_users; end;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvManageUser.DataSource = data;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            F_CreateUser createDialog = new F_CreateUser();
            createDialog.ShowDialog();
            this.Show();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            F_CreateRole createDialog = new F_CreateRole();
            createDialog.ShowDialog();
            this.Show();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            string query = "begin proc_users; end;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUsers.DataSource = data;
        }

        private void btnViewUserPrivileges_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string query = "BEGIN proc_UserPrivileges('" + userName + "'); END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUserPrivileges.DataSource = data;
        }

        private void btnViewAllUsersPrivileges_Click(object sender, EventArgs e)
        {
            string query = "BEGIN proc_Privileges; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUserPrivileges.DataSource = data;
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = dtgvManageUser.CurrentRow.Cells["USERNAME"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN proc_DropUser('" + UserName + "'); END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query);
                    F_Manager_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create User!\n\n" + ex.Message, "Result");
            }
    }
    }
}

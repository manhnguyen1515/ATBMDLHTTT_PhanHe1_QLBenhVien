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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(DataProvider.Connection != null)
            {
                DataProvider.Connection.Close();
                DataProvider.Connection = null;
            }
            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            F_CreateUser createDialog = new F_CreateUser();
            createDialog.ShowDialog();
            this.Show();
            F_Manager_Load(sender, e);
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            F_CreateRole createDialog = new F_CreateRole();
            createDialog.ShowDialog();
            this.Show();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            string query = "BEGIN PROC_USERS; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUsers.DataSource = data;
        }

        private void btnViewUserPrivileges_Click(object sender, EventArgs e)
        {
            string name = txbUserRoleName.Text;
            string query = "BEGIN proc_UserPrivileges( :n_username ); END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });
            dtgvPrivileges.DataSource = data;
        }

        private void btnAllPrivileges_Click(object sender, EventArgs e)
        {
            string query = "BEGIN proc_Privileges; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvPrivileges.DataSource = data;
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = dtgvManageUser.CurrentRow.Cells["USERNAME"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //string query = "BEGIN proc_OracleScript; proc_DropUser('" + UserName + "'); END;";
                    string query = "BEGIN proc_OracleScript; BEGIN proc_DropUser( :n_username ); END; END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { UserName });
                    MessageBox.Show("User đã được xóa thành công!\n\n", "Kết quả");
                    F_Manager_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa user!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string UserName = dtgvManageUser.CurrentRow.Cells["USERNAME"].Value.ToString();
            F_EditUser editDialog = new F_EditUser(UserName);
            editDialog.ShowDialog();
            this.Show();
            F_Manager_Load(sender, e);
        }
    }
}

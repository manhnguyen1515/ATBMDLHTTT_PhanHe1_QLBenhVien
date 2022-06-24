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
using DoAn1.GUI.Admin;

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
            LoadListUser();
            LoadListRole();
            LoadListEmployee();
            LoadListPatient();
            LoadListFacility();
        }

        private void LoadListUser()
        {
            string query = "begin proc_users; end;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvManageUser.DataSource = data;
            dtgvManagePrivilegeUser.DataSource = data;
            dtgvUsers.DataSource = data;
        }

        private void LoadListRole()
        {
            string query = "BEGIN proc_Roles; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvManageRole.DataSource = data;
            dtgvManagePrivilegeRole.DataSource = data;
        }

        private void LoadListEmployee()
        {
            string query = "SELECT * FROM ADMIN.NHANVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvEmployees.DataSource = data;
        }

        private void LoadListPatient()
        {
            string query = "SELECT * FROM ADMIN.BENHNHAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvPatients.DataSource = data;
        }

        private void LoadListFacility()
        {
            string query = "SELECT * FROM ADMIN.CSYT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvFacilities.DataSource = data;
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
            LoadListUser();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            F_CreateRole createDialog = new F_CreateRole();
            createDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            string query = "BEGIN PROC_USERS; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUsers.DataSource = data;
        }

        private void btnViewUserPrivileges_Click(object sender, EventArgs e)
        {
            //string name = txbUserRoleName.Text;
            //string query = "BEGIN proc_UserPrivileges( :n_name ); END;";
            //try
            //{
            //    DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });
            //    dtgvPrivileges.DataSource = data;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnAllPrivileges_Click(object sender, EventArgs e)
        {
            //string query = "BEGIN proc_Privileges; END;";
            //DataTable data = DataProvider.Instance.ExcuteQuery(query);
            //dtgvPrivileges.DataSource = data;
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
                    LoadListUser();
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
            LoadListUser(); ;
        }

        private void btnAddPrivilegeForUser_Click(object sender, EventArgs e)
        {
            string UserName = dtgvManagePrivilegeUser.CurrentRow.Cells["USERNAME"].Value.ToString();
            F_GrantPrivilege addGrantDialog = new F_GrantPrivilege(UserName, (int)CurrentObject.USER);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btnAddPrivilegeForRole_Click(object sender, EventArgs e)
        {
            string roleName = dtgvManagePrivilegeRole.CurrentRow.Cells["ROLE"].Value.ToString();
            F_GrantPrivilege addGrantDialog = new F_GrantPrivilege(roleName, (int)CurrentObject.ROLE);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void btnDropRole_Click(object sender, EventArgs e)
        {
            try
            {
                string roleName = dtgvManageRole.CurrentRow.Cells["ROLE"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //string query = "BEGIN proc_OracleScript; proc_DropUser('" + UserName + "'); END;";
                    string query = "BEGIN proc_OracleScript; BEGIN proc_DropRole ( :n_rolename ); END; END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { roleName });
                    MessageBox.Show("Role đã được xóa thành công!\n\n", "Kết quả");
                    LoadListRole();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa role!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btnRemovePrivilegeForRole_Click(object sender, EventArgs e)
        {
            string roleName = dtgvManagePrivilegeRole.CurrentRow.Cells["ROLE"].Value.ToString();
            F_RevokeGrant revokeGrantDialog = new F_RevokeGrant(roleName, (int)CurrentObject.ROLE);
            revokeGrantDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void btnAddRoleForUser_Click(object sender, EventArgs e)
        {
            string UserName = dtgvManagePrivilegeUser.CurrentRow.Cells["USERNAME"].Value.ToString();
            F_GrantRole addGrantDialog = new F_GrantRole(UserName);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btnRemovePrivilegeForUser_Click(object sender, EventArgs e)
        {
            string userName = dtgvManagePrivilegeUser.CurrentRow.Cells["USERNAME"].Value.ToString();
            F_RevokeGrant revokeGrantDialog = new F_RevokeGrant(userName, (int)CurrentObject.USER);
            revokeGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btnAllUserPrivs_Click(object sender, EventArgs e)
        {
            string query = "BEGIN proc_AllUserPrivileges; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUserPrivs.DataSource = data;
        }

        private void btnViewUserPriv_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            string query = "BEGIN proc_UserPrivileges( :n_username ); END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });
            dtgvUserPrivs.DataSource = data;
        }

        private void btnViewAllRolePrivs_Click(object sender, EventArgs e)
        {
            string query = "BEGIN proc_AllRolePrivileges; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvRolePrivs.DataSource = data;
        }

        private void btnViewRolePrivs_Click(object sender, EventArgs e)
        {
            string name = txbRoleName.Text;
            string query = "BEGIN proc_RolePrivileges( :n_rolename ); END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });
            dtgvRolePrivs.DataSource = data;
        }

        private void btnCreateUserEmployee_Click(object sender, EventArgs e)
        {
            string query = "BEGIN PROC_CREATENHANVIEN; END;";
            OracleCommand data = DataProvider.Instance.ExcuteNonQuery(query);
            if(data != null)
            {
                MessageBox.Show("Tạo thành công");
                LoadListEmployee();
            }
            else
            {
                MessageBox.Show("Không có user nào được tạo!", "Lỗi không tạo được user");
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            F_CreateEmployee dialog = new F_CreateEmployee();
            dialog.ShowDialog();
            this.Show();
            LoadListEmployee();
        }

        private void btnCreateUserPatient_Click(object sender, EventArgs e)
        {
            string query = "BEGIN PROC_CREATEBENHNHAN; END;";
            OracleCommand data = DataProvider.Instance.ExcuteNonQuery(query);
            if (data != null)
            {
                MessageBox.Show("Tạo thành công");
                LoadListPatient();
            }
            else
            {
                MessageBox.Show("Không có user nào được tạo!", "Lỗi không tạo được user");
            }
        }

        private void btnCreateFacility_Click(object sender, EventArgs e)
        {
            F_UpdateFacility dialog = new F_UpdateFacility();
            dialog.ShowDialog();
            this.Show();
            LoadListFacility();
        }

        private void btnUpdateFacility_Click(object sender, EventArgs e)
        {
            string id = dtgvFacilities.CurrentRow.Cells["MACSYT"].Value.ToString();
            F_UpdateFacility dialog = new F_UpdateFacility(id);
            dialog.ShowDialog();
            this.Show();
            LoadListFacility();
        }
    }
}

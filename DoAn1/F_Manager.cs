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
    public partial class F_Manager : System.Windows.Forms.Form
    {
        public F_Manager()
        {
            InitializeComponent();
        }

        private void F_Manager_Load(object sender, EventArgs e)
        {

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
            string query = "BEGIN PROC_USERS; END;";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvUsers.DataSource = data;
        }

    }
}

using DoAn1.DAO;
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
    public partial class F_CreateRole : Form
    {
        public F_CreateRole()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string roleName = txbRoleName.Text;
                string query = "BEGIN proc_OracleScript; BEGIN proc_CreateRole( :n_rolename ); END; END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { roleName });
                MessageBox.Show("Role đã được tạo thành công!\n\n", "Kết quả");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo Role!\n\n" + ex.Message, "Kết quả");
            }
        }


    }
}

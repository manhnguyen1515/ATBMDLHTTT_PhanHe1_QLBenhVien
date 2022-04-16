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
    public partial class F_RevokeFromUser : Form
    {
        private string _userName;
        List<string> _privileges;
        public F_RevokeFromUser(string UserName)
        {
            InitializeComponent();
            _userName = UserName;
        }

        private void F_RevokeFromUser_Load(object sender, EventArgs e)
        {
            _privileges = new List<string>() { "SELECT", "UPDATE", "INSERT", "DELETE" , "ALL"};
            cbbPrivilegeName.DataSource = _privileges;
            txbUserName.Text = _userName;
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn thu hồi quyền của user?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN proc_OracleScript; proc_RevokeFromUser( :n_privilege, :n_table , :n_objectName); END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { cbbPrivilegeName.Text, txbTableName.Text, _userName });
                    MessageBox.Show("Quyền của user đã được thu hồi thành công!\n\n", "Kết quả");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thu hồi quyền!\n\n" + ex.Message, "Kết quả");
            }
        }
    }
}

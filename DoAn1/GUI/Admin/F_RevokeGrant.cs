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
    public partial class F_RevokeGrant : Form
    {
        private int _currentObject; //0: user ; 1: role
        private string _objectName;

        public F_RevokeGrant(string objectName, int currentObject)
        {
            InitializeComponent();
            _objectName = objectName;
            this._currentObject = currentObject;
        }

        private void F_RevokeGrant_Load(object sender, EventArgs e)
        {
            txbUserRoleName.Text = _objectName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string privilege = txbPrivilegeName.Text;
                string table = txbTableName.Text;

                string query = "BEGIN proc_OracleScript; BEGIN proc_RevokeFromUser( :n_privilege, :n_table , :n_objectName ); END; END;";
                OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName });
                MessageBox.Show("Thu hồi quyền thành công!\n\n", "Kết quả");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không đúng !! Không thể thu hồi!\n\n" + ex.Message, "Kết quả");
            }
        }

        
    }
}

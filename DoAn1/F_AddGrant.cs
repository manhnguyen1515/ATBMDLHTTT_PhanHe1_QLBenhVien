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
    enum CurrentObject
    {
        USER,
        ROLE
    }
    public partial class F_AddGrant : Form
    {
        private int _currentObject; //0: user ; 1: role
        private string _objectName;
        List<string> _privileges;


        public F_AddGrant(string objectName, int currentObject)
        {
            InitializeComponent();
            _objectName = objectName;
            this._currentObject = currentObject;
        }

        private void F_AddGrant_Load(object sender, EventArgs e)
        {
            _privileges = new List<string>() { "SELECT", "UPDATE", "INSERT", "DELETE", "ALL"};

            cbbPrivilegeName.DataSource = _privileges;
            txbUserRoleName.Text = _objectName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string privilege = _privileges[cbbPrivilegeName.SelectedIndex];
                string table = txbTableName.Text;
                char grantOption = chbGrantOption.Checked == true ? 'Y' : 'N';
                if(_currentObject == (int)CurrentObject.USER)
                {
                    string query = "BEGIN proc_OracleScript; BEGIN proc_GrantForUser( :n_privilege, :n_table , :n_objectName, :n_flag ); END; END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName, grantOption });
                }
                else if (_currentObject == (int)CurrentObject.ROLE)
                {
                    string query = "BEGIN proc_OracleScript; BEGIN proc_GrantForRole( :n_privilege, :n_table , :n_objectName); END; END;";
                    OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName });
                }
                else
                {
                    MessageBox.Show("Đối tượng không hợp lệ!\n\n", "Kết quả");
                }
                MessageBox.Show("Cấp quyền thành công!\n\n", "Kết quả");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cấp quyền!\n\n" + ex.Message, "Kết quả");
            }
        }
    }
}

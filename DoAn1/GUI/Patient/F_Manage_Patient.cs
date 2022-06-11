using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.GUI.Patient
{
    public partial class F_Manage_Patient : Form
    {
        public F_Manage_Patient()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DataProvider.Connection != null)
            {
                DataProvider.Connection.Close();
                DataProvider.Connection = null;
            }
            this.Close();
        }
    }
}

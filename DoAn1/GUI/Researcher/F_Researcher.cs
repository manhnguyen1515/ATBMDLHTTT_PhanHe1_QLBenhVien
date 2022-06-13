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

namespace DoAn1.GUI.Researcher
{
    public partial class F_Researcher : Form
    {
        public F_Researcher()
        {
            InitializeComponent();
        }

        private void F_Researcher_Load(object sender, EventArgs e)
        {
            LoadRecordsAndServices();
        }

        private void LoadRecordsAndServices()
        {
            string query = "SELECT * FROM ADMIN.VIEW_NGHIENCUU_HSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvMedicalRecords.DataSource = data;
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

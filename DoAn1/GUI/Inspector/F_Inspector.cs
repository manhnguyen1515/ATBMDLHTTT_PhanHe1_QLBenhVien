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

namespace DoAn1.GUI.Inspector
{
    public partial class F_Inspector : Form
    {
        public F_Inspector()
        {
            InitializeComponent();
        }

        private void F_Inspector_Load(object sender, EventArgs e)
        {
            LoadRecords();
            LoadServices();
            LoadEmployees();
            LoadPatients();
            LoadFacilities();
        }

        private void LoadRecords()
        {
            string query = "SELECT * FROM ADMIN.HSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvMedicalRecords.DataSource = data;
        }

        private void LoadServices()
        {
            string query = "SELECT * FROM ADMIN.HSBA_DV JOIN ADMIN.HSBA ON HSBA_DV.MAHSBA = HSBA.MAHSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvServices.DataSource = data;
        }

        private void LoadEmployees()
        {
            string query = "SELECT * FROM ADMIN.NHANVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvEmployee.DataSource = data;
        }

        private void LoadPatients()
        {
            string query = "SELECT * FROM ADMIN.BENHNHAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvPatient.DataSource = data;
        }

        private void LoadFacilities()
        {
            string query = "SELECT * FROM ADMIN.CSYT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvFacility.DataSource = data;
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

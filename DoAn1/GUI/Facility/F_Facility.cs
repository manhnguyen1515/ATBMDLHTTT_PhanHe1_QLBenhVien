using DoAn1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.GUI.Facility
{
    public partial class F_Facility : Form
    {
        private List<string> _records;
        public F_Facility()
        {
            InitializeComponent();
        }

        private void F_Facility_Load(object sender, EventArgs e)
        {
            _records = new List<string>();
            LoadRecords();
            LoadServices();
        }

        private void LoadRecords()
        {
            string query = "SELECT * FROM ADMIN.HSBA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvRecords.DataSource = data;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                _records.Add(data.Rows[i]["MAHSBA"].ToString());
            }
            cbbRecord.DataSource = _records;
        }

        private void LoadServices()
        {
            string record = cbbRecord.SelectedItem as string;
            string query = $"SELECT * FROM ADMIN.VIEW_CSYT_HSBA_DV WHERE MAHSBA = '{record}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvServices.DataSource = data;
        }

        private void cbbRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            Form addForm = new F_AddRecord();
            addForm.ShowDialog();
            LoadRecords();
        }

        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string mahsba = dtgvRecords.CurrentRow.Cells["MAHSBA"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba.proc_DEL( :mahsba ); END; END;";

                    var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mahsba });
                    MessageBox.Show("Hồ sơ bệnh án đã được xóa thành công!\n\n", "Kết quả");
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string mahsba = cbbRecord.SelectedItem as string;
            Form addForm = new F_AddService(mahsba);
            addForm.ShowDialog();
            LoadServices();
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            try
            {
                string mahsba = dtgvServices.CurrentRow.Cells["MAHSBA"].Value.ToString();
                string madv = dtgvServices.CurrentRow.Cells["MADV"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba_dv.proc_del( :mahsba , :madv ); END; END;";

                    var cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mahsba, madv });
                    MessageBox.Show("Hồ sơ dịch vụ đã được xóa thành công!\n\n", "Kết quả");
                    LoadServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa!\n\n" + ex.Message, "Kết quả");
            }
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

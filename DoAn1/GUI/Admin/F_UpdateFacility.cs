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

namespace DoAn1.GUI.Admin
{
    public partial class F_UpdateFacility : Form
    {
        private string _facilitiId;

        public F_UpdateFacility(string id = null)
        {
            InitializeComponent();
            _facilitiId = id;
        }

        private void F_UpdateFacility_Load(object sender, EventArgs e)
        {
            if(_facilitiId != null)
            {
                string query = $"SELECT * FROM ADMIN.CSYT WHERE MACSYT = '{_facilitiId}'";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                lbFacilitiId.Text = _facilitiId;
                txbName.Text = data.Rows[data.Rows.Count - 1]["TENCSYT"].ToString();
                txbAddress.Text = data.Rows[data.Rows.Count - 1]["DCCSYT"].ToString();
                txbPhone.Text = data.Rows[data.Rows.Count - 1]["SDTCSYT"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(_facilitiId != null )
            {
                UpdateFacility();
            }
            else
            {
                CreateFacility();
            }
        }

        private string GetFacilityId()
        {
            string query = "SELECT MACSYT FROM ( SELECT CS.*, max(CS.MACSYT) over () as max_pk FROM ADMIN.CSYT CS ) WHERE MACSYT = max_pk";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string lastId = data.Rows[data.Rows.Count - 1]["MACSYT"].ToString();
            string firstPattern = lastId.Substring(0, 2);
            string lastPattern = lastId.Substring(2);
            int lastIdInt = Int32.Parse(lastPattern);

            string newId = $"{lastIdInt + 1}";
            for (int i = 0; i <= lastId.Length - newId.Length; i++)
            {
                newId = "0" + newId;
            }
            newId = firstPattern + newId;
            return newId;
        }

        private void CreateFacility()
        {
            string id = GetFacilityId();
            string name = txbName.Text;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;

            string query = "BEGIN PROC_INSERTCSYT( :MACSYT , :TENCSYT, :DCCSYT , :SDTCSYT ); END;";

            try
            {
                var command = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, name, address, phone});
                if (command != null)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không thể thêm. \n" + ex.Message);
            }

            this.Close();
        }

        private void UpdateFacility()
        {
            string id = lbFacilitiId.Text;
            string name = txbName.Text;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;

            string query = "BEGIN PROC_UPDATECSYT( :MACSYT , :TENCSYT, :DCCSYT , :SDTCSYT ); END;";

            try
            {
                var command = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, name, address, phone});
                if (command != null)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không thể cập nhật. \n" + ex.Message);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

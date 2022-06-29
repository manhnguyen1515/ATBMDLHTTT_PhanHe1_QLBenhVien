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

namespace DoAn1.GUI.Facility
{
    public partial class F_AddService : Form
    {
        private string _mahsba;
        public F_AddService(string mahsba)
        {
            _mahsba = mahsba;
            InitializeComponent();
        }

        private void F_AddService_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string madv = txbMaDV.Text;
            var ngay = dtpkNgay.Value;
            string maktv = txbMaKTV.Text;
            string ketqua = txbKetQua.Text;
            string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba_DV.proc_ins" +
                "( :mahsba , :madv , :ngay , :maktv , :ketqua ); END; END;";

            try
            {
                var command = DataProvider.Instance.ExcuteNonQuery(query, new object[] { _mahsba, madv, ngay, maktv, ketqua });
                if (command != null)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                string error = "Lỗi! Không thể thêm. \n\n";
                if (ex.Message.Contains("ORA-20000"))
                    error += "Ngày không hợp lệ. Vui lòng chọn các ngày từ 5 đến 27 trong tháng này.";
                MessageBox.Show(error, "Kết quả");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

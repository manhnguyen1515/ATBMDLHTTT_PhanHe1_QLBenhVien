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
    public partial class F_AddRecord : Form
    {
        public F_AddRecord()
        {
            InitializeComponent();
        }

        private void F_AddRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mahsba = txbMaHSBA.Text;
            string mabn = txbMaBN.Text;
            var ngay = dtpkNgay.Value;
            string chandoan = txbChanDoan.Text;
            string mabs = txbMaBS.Text;
            string makhoa = txbMaKhoa.Text;
            string ketluan = txbKetLuan.Text;
            string query = "BEGIN ADMIN.proc_OracleScript; BEGIN ADMIN.pkg_csyt_hsba.proc_ins" +
                "( :mahsba , :mabn , :ngay , :chandoan , :mabs , :makhoa , USER , :ketluan ); END; END;"; 

            try
            {
                var command = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mahsba, mabn, ngay, chandoan, mabs, makhoa, ketluan });
                if (command != null)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch(Exception ex)
            {
                string error = "Lỗi! Không thể thêm. \n\n";
                if (ex.Message.Contains("ORA-20000"))
                    error += "Ngày không hợp lệ. Vui lòng quay lại vào các ngày từ 5 đến 27 hàng tháng.";
                MessageBox.Show(error, "Kết quả");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

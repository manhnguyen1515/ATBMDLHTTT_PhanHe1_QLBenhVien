
namespace DoAn1.GUI.Facility
{
    partial class F_Facility
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvRecords = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvServices = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbRecord = new System.Windows.Forms.ComboBox();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgvRecords);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hồ sơ bệnh án";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvRecords
            // 
            this.dtgvRecords.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRecords.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvRecords.Location = new System.Drawing.Point(6, 5);
            this.dtgvRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvRecords.Name = "dtgvRecords";
            this.dtgvRecords.RowHeadersWidth = 51;
            this.dtgvRecords.RowTemplate.Height = 29;
            this.dtgvRecords.Size = new System.Drawing.Size(768, 454);
            this.dtgvRecords.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveRecord);
            this.panel1.Controls.Add(this.btnAddRecord);
            this.panel1.Location = new System.Drawing.Point(780, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 453);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveRecord
            // 
            this.btnRemoveRecord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveRecord.FlatAppearance.BorderSize = 0;
            this.btnRemoveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRecord.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRecord.Location = new System.Drawing.Point(69, 247);
            this.btnRemoveRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRecord.Name = "btnRemoveRecord";
            this.btnRemoveRecord.Size = new System.Drawing.Size(158, 43);
            this.btnRemoveRecord.TabIndex = 5;
            this.btnRemoveRecord.Text = "Xóa";
            this.btnRemoveRecord.UseVisualStyleBackColor = false;
            this.btnRemoveRecord.Click += new System.EventHandler(this.btnRemoveRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddRecord.Location = new System.Drawing.Point(69, 128);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(158, 43);
            this.btnAddRecord.TabIndex = 4;
            this.btnAddRecord.Text = "Thêm";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgvServices);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hồ sơ bệnh án dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvServices
            // 
            this.dtgvServices.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServices.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvServices.Location = new System.Drawing.Point(6, 5);
            this.dtgvServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvServices.Name = "dtgvServices";
            this.dtgvServices.RowHeadersWidth = 51;
            this.dtgvServices.RowTemplate.Height = 29;
            this.dtgvServices.Size = new System.Drawing.Size(768, 454);
            this.dtgvServices.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbRecord);
            this.panel2.Controls.Add(this.btnRemoveService);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Location = new System.Drawing.Point(780, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 453);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn HSBA";
            // 
            // cbbRecord
            // 
            this.cbbRecord.FormattingEnabled = true;
            this.cbbRecord.Location = new System.Drawing.Point(69, 53);
            this.cbbRecord.Name = "cbbRecord";
            this.cbbRecord.Size = new System.Drawing.Size(158, 31);
            this.cbbRecord.TabIndex = 6;
            this.cbbRecord.SelectedIndexChanged += new System.EventHandler(this.cbbRecord_SelectedIndexChanged);
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveService.FlatAppearance.BorderSize = 0;
            this.btnRemoveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveService.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveService.ForeColor = System.Drawing.Color.White;
            this.btnRemoveService.Location = new System.Drawing.Point(69, 247);
            this.btnRemoveService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(158, 43);
            this.btnRemoveService.TabIndex = 5;
            this.btnRemoveService.Text = "Xóa";
            this.btnRemoveService.UseVisualStyleBackColor = false;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(69, 128);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(158, 43);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Thêm";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(16, 529);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 43);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // F_Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_Facility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho cơ sở y tế";
            this.Load += new System.EventHandler(this.F_Facility_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.DataGridView dtgvRecords;
        private System.Windows.Forms.DataGridView dtgvServices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbRecord;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnAddService;
    }
}

namespace DoAn1.GUI.Researcher
{
    partial class F_Researcher
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
            this.tcManager = new System.Windows.Forms.TabControl();
            this.tpMedicalRecord = new System.Windows.Forms.TabPage();
            this.dtgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txbFacility = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCitizenId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpkBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.tcManager.SuspendLayout();
            this.tpMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).BeginInit();
            this.tpInfo.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpMedicalRecord);
            this.tcManager.Controls.Add(this.tpInfo);
            this.tcManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManager.Location = new System.Drawing.Point(12, 11);
            this.tcManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(1098, 503);
            this.tcManager.TabIndex = 3;
            // 
            // tpMedicalRecord
            // 
            this.tpMedicalRecord.Controls.Add(this.dtgvMedicalRecords);
            this.tpMedicalRecord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMedicalRecord.Location = new System.Drawing.Point(4, 34);
            this.tpMedicalRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpMedicalRecord.Name = "tpMedicalRecord";
            this.tpMedicalRecord.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpMedicalRecord.Size = new System.Drawing.Size(1090, 465);
            this.tpMedicalRecord.TabIndex = 0;
            this.tpMedicalRecord.Text = "Hồ sơ bệnh án và dịch vụ";
            this.tpMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // dtgvMedicalRecords
            // 
            this.dtgvMedicalRecords.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicalRecords.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvMedicalRecords.Location = new System.Drawing.Point(3, 5);
            this.dtgvMedicalRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvMedicalRecords.Name = "dtgvMedicalRecords";
            this.dtgvMedicalRecords.RowHeadersWidth = 51;
            this.dtgvMedicalRecords.RowTemplate.Height = 29;
            this.dtgvMedicalRecords.Size = new System.Drawing.Size(1081, 458);
            this.dtgvMedicalRecords.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(19, 529);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 43);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.panel6);
            this.tpInfo.Controls.Add(this.panel10);
            this.tpInfo.Controls.Add(this.panel13);
            this.tpInfo.Controls.Add(this.panel12);
            this.tpInfo.Controls.Add(this.panel14);
            this.tpInfo.Controls.Add(this.panel11);
            this.tpInfo.Controls.Add(this.panel8);
            this.tpInfo.Controls.Add(this.panel7);
            this.tpInfo.Controls.Add(this.panel5);
            this.tpInfo.Controls.Add(this.label12);
            this.tpInfo.Controls.Add(this.btnUpdateInfo);
            this.tpInfo.Location = new System.Drawing.Point(4, 34);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1090, 465);
            this.tpInfo.TabIndex = 1;
            this.tpInfo.Text = "Thông tin cá nhân";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(113, 7);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(278, 31);
            this.txbGender.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txbGender);
            this.panel6.Location = new System.Drawing.Point(671, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 48);
            this.panel6.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quê quán:";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(113, 7);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(278, 31);
            this.txbAddress.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txbAddress);
            this.panel10.Location = new System.Drawing.Point(671, 239);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 48);
            this.panel10.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Vai trò:";
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(113, 7);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(278, 31);
            this.txbRole.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.txbRole);
            this.panel13.Location = new System.Drawing.Point(671, 307);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 48);
            this.panel13.TabIndex = 27;
            // 
            // txbFacility
            // 
            this.txbFacility.Location = new System.Drawing.Point(113, 7);
            this.txbFacility.Name = "txbFacility";
            this.txbFacility.Size = new System.Drawing.Size(278, 31);
            this.txbFacility.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.txbFacility);
            this.panel12.Location = new System.Drawing.Point(671, 378);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(394, 48);
            this.panel12.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cơ sở y tế:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.txbDepartment);
            this.panel14.Location = new System.Drawing.Point(19, 382);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(627, 48);
            this.panel14.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Chuyên khoa:";
            // 
            // txbDepartment
            // 
            this.txbDepartment.Location = new System.Drawing.Point(143, 7);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.Size = new System.Drawing.Size(476, 31);
            this.txbDepartment.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.txbPhone);
            this.panel11.Location = new System.Drawing.Point(22, 314);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(627, 48);
            this.panel11.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại:";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(143, 7);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(476, 31);
            this.txbPhone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "CMND:";
            // 
            // txbCitizenId
            // 
            this.txbCitizenId.Location = new System.Drawing.Point(143, 7);
            this.txbCitizenId.Name = "txbCitizenId";
            this.txbCitizenId.Size = new System.Drawing.Size(476, 31);
            this.txbCitizenId.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txbCitizenId);
            this.panel8.Location = new System.Drawing.Point(22, 243);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 48);
            this.panel8.TabIndex = 23;
            // 
            // dtpkBirthDay
            // 
            this.dtpkBirthDay.Location = new System.Drawing.Point(143, 10);
            this.dtpkBirthDay.Name = "dtpkBirthDay";
            this.dtpkBirthDay.Size = new System.Drawing.Size(476, 31);
            this.dtpkBirthDay.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkBirthDay);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(22, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 48);
            this.panel7.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ tên:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbFullname);
            this.panel5.Location = new System.Drawing.Point(22, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1049, 48);
            this.panel5.TabIndex = 20;
            // 
            // txbFullname
            // 
            this.txbFullname.Location = new System.Drawing.Point(143, 4);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(900, 31);
            this.txbFullname.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(383, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 38);
            this.label12.TabIndex = 29;
            this.label12.Text = "Thông tin cá nhân";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.Location = new System.Drawing.Point(19, 34);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(158, 43);
            this.btnUpdateInfo.TabIndex = 19;
            this.btnUpdateInfo.Text = "Cập nhật";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // F_Researcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcManager);
            this.Name = "F_Researcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho nghiên cứu";
            this.Load += new System.EventHandler(this.F_Researcher_Load);
            this.tcManager.ResumeLayout(false);
            this.tpMedicalRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).EndInit();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpMedicalRecord;
        private System.Windows.Forms.DataGridView dtgvMedicalRecords;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbFacility;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCitizenId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpkBirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateInfo;
    }
}
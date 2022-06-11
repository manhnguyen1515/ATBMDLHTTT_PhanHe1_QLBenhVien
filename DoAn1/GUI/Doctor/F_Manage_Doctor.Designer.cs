
namespace DoAn1
{
    partial class F_Manage_Doctor
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbCitizenId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbFacility = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpService = new System.Windows.Forms.TabPage();
            this.tpMedicalRecord = new System.Windows.Forms.TabPage();
            this.dtgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.tcManager = new System.Windows.Forms.TabControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.txbPatientInfo = new System.Windows.Forms.TextBox();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.dtgvServices = new System.Windows.Forms.DataGridView();
            this.dtpkBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tpPatient.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tpService.SuspendLayout();
            this.tpMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).BeginInit();
            this.tcManager.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(23, 529);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 43);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.panel9);
            this.tpPatient.Controls.Add(this.dtgvPatient);
            this.tpPatient.Location = new System.Drawing.Point(4, 34);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(1090, 465);
            this.tpPatient.TabIndex = 4;
            this.tpPatient.Text = "Thông tin bệnh nhân";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.panel11);
            this.tpInfo.Controls.Add(this.panel8);
            this.tpInfo.Controls.Add(this.panel7);
            this.tpInfo.Controls.Add(this.panel5);
            this.tpInfo.Controls.Add(this.panel15);
            this.tpInfo.Location = new System.Drawing.Point(4, 34);
            this.tpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpInfo.Size = new System.Drawing.Size(1090, 465);
            this.tpInfo.TabIndex = 3;
            this.tpInfo.Text = "Thông tin cá nhân";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel14);
            this.panel15.Controls.Add(this.btnUpdateInfo);
            this.panel15.Controls.Add(this.panel12);
            this.panel15.Controls.Add(this.panel13);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.panel6);
            this.panel15.Controls.Add(this.panel10);
            this.panel15.Location = new System.Drawing.Point(3, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1081, 460);
            this.panel15.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(377, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 38);
            this.label12.TabIndex = 18;
            this.label12.Text = "Thông tin cá nhân";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.Location = new System.Drawing.Point(13, 18);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(158, 43);
            this.btnUpdateInfo.TabIndex = 2;
            this.btnUpdateInfo.Text = "Cập nhật";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbFullname);
            this.panel5.Location = new System.Drawing.Point(16, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1049, 48);
            this.panel5.TabIndex = 9;
            // 
            // txbFullname
            // 
            this.txbFullname.Location = new System.Drawing.Point(143, 4);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(900, 31);
            this.txbFullname.TabIndex = 8;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txbGender);
            this.panel6.Location = new System.Drawing.Point(665, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 48);
            this.panel6.TabIndex = 10;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(113, 7);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(278, 31);
            this.txbGender.TabIndex = 8;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkBirthDay);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(16, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 48);
            this.panel7.TabIndex = 11;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txbCitizenId);
            this.panel8.Location = new System.Drawing.Point(16, 227);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 48);
            this.panel8.TabIndex = 12;
            // 
            // txbCitizenId
            // 
            this.txbCitizenId.Location = new System.Drawing.Point(143, 7);
            this.txbCitizenId.Name = "txbCitizenId";
            this.txbCitizenId.Size = new System.Drawing.Size(476, 31);
            this.txbCitizenId.TabIndex = 8;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txbAddress);
            this.panel10.Location = new System.Drawing.Point(665, 223);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 48);
            this.panel10.TabIndex = 13;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(113, 7);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(278, 31);
            this.txbAddress.TabIndex = 8;
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
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.txbPhone);
            this.panel11.Location = new System.Drawing.Point(16, 298);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(627, 48);
            this.panel11.TabIndex = 14;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(143, 7);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(476, 31);
            this.txbPhone.TabIndex = 8;
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
            // panel12
            // 
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.txbFacility);
            this.panel12.Location = new System.Drawing.Point(665, 362);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(394, 48);
            this.panel12.TabIndex = 15;
            // 
            // txbFacility
            // 
            this.txbFacility.Location = new System.Drawing.Point(113, 7);
            this.txbFacility.Name = "txbFacility";
            this.txbFacility.Size = new System.Drawing.Size(278, 31);
            this.txbFacility.TabIndex = 8;
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
            // panel13
            // 
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.txbRole);
            this.panel13.Location = new System.Drawing.Point(665, 291);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 48);
            this.panel13.TabIndex = 16;
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(113, 7);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(278, 31);
            this.txbRole.TabIndex = 8;
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
            // panel14
            // 
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.txbDepartment);
            this.panel14.Location = new System.Drawing.Point(13, 366);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(627, 48);
            this.panel14.TabIndex = 17;
            // 
            // txbDepartment
            // 
            this.txbDepartment.Location = new System.Drawing.Point(143, 7);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.Size = new System.Drawing.Size(476, 31);
            this.txbDepartment.TabIndex = 8;
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
            // tpService
            // 
            this.tpService.Controls.Add(this.dtgvServices);
            this.tpService.Location = new System.Drawing.Point(4, 34);
            this.tpService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpService.Name = "tpService";
            this.tpService.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpService.Size = new System.Drawing.Size(1090, 465);
            this.tpService.TabIndex = 2;
            this.tpService.Text = "Hồ sơ dịch vụ";
            this.tpService.UseVisualStyleBackColor = true;
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
            this.tpMedicalRecord.Text = "Hồ sơ bệnh án";
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
            this.dtgvMedicalRecords.Size = new System.Drawing.Size(1081, 448);
            this.dtgvMedicalRecords.TabIndex = 2;
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpMedicalRecord);
            this.tcManager.Controls.Add(this.tpService);
            this.tcManager.Controls.Add(this.tpInfo);
            this.tcManager.Controls.Add(this.tpPatient);
            this.tcManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManager.Location = new System.Drawing.Point(3, 12);
            this.tcManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(1098, 503);
            this.tcManager.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.splitter2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.btnViewPatient);
            this.panel9.Controls.Add(this.txbPatientInfo);
            this.panel9.Location = new System.Drawing.Point(779, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(311, 447);
            this.panel9.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "hoặc CMND:";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(311, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã bệnh nhân";
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewPatient.FlatAppearance.BorderSize = 0;
            this.btnViewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatient.ForeColor = System.Drawing.Color.White;
            this.btnViewPatient.Location = new System.Drawing.Point(78, 208);
            this.btnViewPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(158, 43);
            this.btnViewPatient.TabIndex = 3;
            this.btnViewPatient.Text = "Xem";
            this.btnViewPatient.UseVisualStyleBackColor = false;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // txbPatientInfo
            // 
            this.txbPatientInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txbPatientInfo.Location = new System.Drawing.Point(3, 126);
            this.txbPatientInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPatientInfo.Name = "txbPatientInfo";
            this.txbPatientInfo.Size = new System.Drawing.Size(298, 38);
            this.txbPatientInfo.TabIndex = 2;
            // 
            // dtgvPatient
            // 
            this.dtgvPatient.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvPatient.Location = new System.Drawing.Point(1, 4);
            this.dtgvPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPatient.Name = "dtgvPatient";
            this.dtgvPatient.RowHeadersWidth = 51;
            this.dtgvPatient.RowTemplate.Height = 29;
            this.dtgvPatient.Size = new System.Drawing.Size(768, 449);
            this.dtgvPatient.TabIndex = 8;
            // 
            // dtgvServices
            // 
            this.dtgvServices.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServices.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvServices.Location = new System.Drawing.Point(5, 4);
            this.dtgvServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvServices.Name = "dtgvServices";
            this.dtgvServices.RowHeadersWidth = 51;
            this.dtgvServices.RowTemplate.Height = 29;
            this.dtgvServices.Size = new System.Drawing.Size(1081, 448);
            this.dtgvServices.TabIndex = 5;
            // 
            // dtpkBirthDay
            // 
            this.dtpkBirthDay.Location = new System.Drawing.Point(143, 10);
            this.dtpkBirthDay.Name = "dtpkBirthDay";
            this.dtpkBirthDay.Size = new System.Drawing.Size(476, 31);
            this.dtpkBirthDay.TabIndex = 9;
            // 
            // F_Manage_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.tcManager);
            this.Controls.Add(this.btnLogout);
            this.Name = "F_Manage_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho bác sĩ";
            this.Load += new System.EventHandler(this.F_Manage_Doctor_Load);
            this.tpPatient.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tpService.ResumeLayout(false);
            this.tpMedicalRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).EndInit();
            this.tcManager.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.TextBox txbPatientInfo;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbFacility;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCitizenId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpService;
        private System.Windows.Forms.DataGridView dtgvServices;
        private System.Windows.Forms.TabPage tpMedicalRecord;
        private System.Windows.Forms.DataGridView dtgvMedicalRecords;
        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.DateTimePicker dtpkBirthDay;
    }
}
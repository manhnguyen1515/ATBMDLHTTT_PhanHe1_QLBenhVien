
namespace DoAn1.GUI.Inspector
{
    partial class F_Inspector
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
            this.tpService = new System.Windows.Forms.TabPage();
            this.dtgvServices = new System.Windows.Forms.DataGridView();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.tpFacility = new System.Windows.Forms.TabPage();
            this.dtgvFacility = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.txbFacility = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGender = new System.Windows.Forms.TextBox();
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
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.tcManager.SuspendLayout();
            this.tpMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).BeginInit();
            this.tpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).BeginInit();
            this.tpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.tpPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            this.tpFacility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacility)).BeginInit();
            this.tpInfo.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tcManager.Controls.Add(this.tpService);
            this.tcManager.Controls.Add(this.tpEmployee);
            this.tcManager.Controls.Add(this.tpPatient);
            this.tcManager.Controls.Add(this.tpFacility);
            this.tcManager.Controls.Add(this.tpInfo);
            this.tcManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManager.Location = new System.Drawing.Point(12, 11);
            this.tcManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(1098, 503);
            this.tcManager.TabIndex = 2;
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
            this.dtgvMedicalRecords.Size = new System.Drawing.Size(1081, 458);
            this.dtgvMedicalRecords.TabIndex = 2;
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
            this.dtgvServices.Size = new System.Drawing.Size(1081, 457);
            this.dtgvServices.TabIndex = 5;
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.dtgvEmployee);
            this.tpEmployee.Location = new System.Drawing.Point(4, 34);
            this.tpEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployee.Size = new System.Drawing.Size(1090, 465);
            this.tpEmployee.TabIndex = 3;
            this.tpEmployee.Text = "Nhân viên";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvEmployee.Location = new System.Drawing.Point(3, 4);
            this.dtgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 29;
            this.dtgvEmployee.Size = new System.Drawing.Size(1084, 457);
            this.dtgvEmployee.TabIndex = 9;
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.dtgvPatient);
            this.tpPatient.Location = new System.Drawing.Point(4, 34);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(1090, 465);
            this.tpPatient.TabIndex = 4;
            this.tpPatient.Text = "Bệnh nhân";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // dtgvPatient
            // 
            this.dtgvPatient.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvPatient.Location = new System.Drawing.Point(3, 6);
            this.dtgvPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPatient.Name = "dtgvPatient";
            this.dtgvPatient.RowHeadersWidth = 51;
            this.dtgvPatient.RowTemplate.Height = 29;
            this.dtgvPatient.Size = new System.Drawing.Size(1084, 457);
            this.dtgvPatient.TabIndex = 8;
            // 
            // tpFacility
            // 
            this.tpFacility.Controls.Add(this.dtgvFacility);
            this.tpFacility.Location = new System.Drawing.Point(4, 34);
            this.tpFacility.Name = "tpFacility";
            this.tpFacility.Padding = new System.Windows.Forms.Padding(3);
            this.tpFacility.Size = new System.Drawing.Size(1090, 465);
            this.tpFacility.TabIndex = 5;
            this.tpFacility.Text = "Cơ sở y tế";
            this.tpFacility.UseVisualStyleBackColor = true;
            // 
            // dtgvFacility
            // 
            this.dtgvFacility.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacility.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvFacility.Location = new System.Drawing.Point(3, 4);
            this.dtgvFacility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvFacility.Name = "dtgvFacility";
            this.dtgvFacility.RowHeadersWidth = 51;
            this.dtgvFacility.RowTemplate.Height = 29;
            this.dtgvFacility.Size = new System.Drawing.Size(1084, 457);
            this.dtgvFacility.TabIndex = 9;
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
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.panel12);
            this.tpInfo.Controls.Add(this.panel10);
            this.tpInfo.Controls.Add(this.panel13);
            this.tpInfo.Controls.Add(this.panel6);
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
            this.tpInfo.TabIndex = 6;
            this.tpInfo.Text = "Thông tin cá nhân";
            this.tpInfo.UseVisualStyleBackColor = true;
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
            this.panel12.Location = new System.Drawing.Point(674, 378);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(394, 48);
            this.panel12.TabIndex = 27;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txbAddress);
            this.panel10.Location = new System.Drawing.Point(674, 239);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 48);
            this.panel10.TabIndex = 26;
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
            this.panel13.Location = new System.Drawing.Point(674, 307);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 48);
            this.panel13.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txbGender);
            this.panel6.Location = new System.Drawing.Point(674, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 48);
            this.panel6.TabIndex = 25;
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
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(113, 7);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(278, 31);
            this.txbGender.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.txbDepartment);
            this.panel14.Location = new System.Drawing.Point(22, 382);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(627, 48);
            this.panel14.TabIndex = 29;
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
            this.panel11.Location = new System.Drawing.Point(19, 311);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(627, 48);
            this.panel11.TabIndex = 34;
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
            this.panel8.Location = new System.Drawing.Point(19, 240);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 48);
            this.panel8.TabIndex = 33;
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
            this.panel7.Location = new System.Drawing.Point(19, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 48);
            this.panel7.TabIndex = 32;
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
            // txbFullname
            // 
            this.txbFullname.Location = new System.Drawing.Point(143, 4);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(900, 31);
            this.txbFullname.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbFullname);
            this.panel5.Location = new System.Drawing.Point(19, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1049, 48);
            this.panel5.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(386, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 38);
            this.label12.TabIndex = 30;
            this.label12.Text = "Thông tin cá nhân";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.Location = new System.Drawing.Point(22, 34);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(158, 43);
            this.btnUpdateInfo.TabIndex = 24;
            this.btnUpdateInfo.Text = "Cập nhật";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // F_Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcManager);
            this.Name = "F_Inspector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho thanh tra";
            this.Load += new System.EventHandler(this.F_Inspector_Load);
            this.tcManager.ResumeLayout(false);
            this.tpMedicalRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).EndInit();
            this.tpService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).EndInit();
            this.tpEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.tpPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            this.tpFacility.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacility)).EndInit();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.TabPage tpService;
        private System.Windows.Forms.DataGridView dtgvServices;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.TabPage tpFacility;
        private System.Windows.Forms.DataGridView dtgvFacility;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbFacility;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGender;
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
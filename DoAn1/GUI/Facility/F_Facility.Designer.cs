
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCitizenId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbFacility = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel15);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1075, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin cá  nhân";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // dtpkBirthDay
            // 
            this.dtpkBirthDay.Location = new System.Drawing.Point(143, 10);
            this.dtpkBirthDay.Name = "dtpkBirthDay";
            this.dtpkBirthDay.Size = new System.Drawing.Size(476, 30);
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
            this.txbCitizenId.Size = new System.Drawing.Size(476, 30);
            this.txbCitizenId.TabIndex = 8;
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
            this.txbPhone.Size = new System.Drawing.Size(476, 30);
            this.txbPhone.TabIndex = 8;
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
            this.txbDepartment.Size = new System.Drawing.Size(476, 30);
            this.txbDepartment.TabIndex = 8;
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
            // txbFacility
            // 
            this.txbFacility.Location = new System.Drawing.Point(113, 7);
            this.txbFacility.Name = "txbFacility";
            this.txbFacility.Size = new System.Drawing.Size(278, 30);
            this.txbFacility.TabIndex = 8;
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(113, 7);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(278, 30);
            this.txbRole.TabIndex = 8;
            // 
            // txbFullname
            // 
            this.txbFullname.Location = new System.Drawing.Point(143, 4);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(900, 30);
            this.txbFullname.TabIndex = 8;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(113, 7);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(278, 30);
            this.txbAddress.TabIndex = 8;
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
            // panel14
            // 
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.txbDepartment);
            this.panel14.Location = new System.Drawing.Point(13, 366);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(627, 48);
            this.panel14.TabIndex = 17;
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
            // panel13
            // 
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.txbRole);
            this.panel13.Location = new System.Drawing.Point(665, 291);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 48);
            this.panel13.TabIndex = 16;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txbAddress);
            this.panel10.Location = new System.Drawing.Point(665, 223);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 48);
            this.panel10.TabIndex = 13;
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
            this.panel11.Location = new System.Drawing.Point(10, 295);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(627, 48);
            this.panel11.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txbCitizenId);
            this.panel8.Location = new System.Drawing.Point(10, 224);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 48);
            this.panel8.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkBirthDay);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(10, 156);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 48);
            this.panel7.TabIndex = 21;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbFullname);
            this.panel5.Location = new System.Drawing.Point(10, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1049, 48);
            this.panel5.TabIndex = 20;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(113, 7);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(278, 30);
            this.txbGender.TabIndex = 8;
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
            this.panel15.Location = new System.Drawing.Point(-3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1081, 460);
            this.panel15.TabIndex = 24;
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
            this.tabPage3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbFacility;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
    }
}
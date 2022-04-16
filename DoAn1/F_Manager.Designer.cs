
namespace DoAn1
{
    partial class F_Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcManager = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvUsers = new System.Windows.Forms.DataGridView();
            this.tpPrivileges = new System.Windows.Forms.TabPage();
            this.dtgvPrivileges = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewUserPrivileges = new System.Windows.Forms.Button();
            this.txbUserRoleName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAllPrivileges = new System.Windows.Forms.Button();
            this.tpManageUser_Role = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpManageUser = new System.Windows.Forms.TabPage();
            this.dtgvManageUser = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDropUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tpManageRole = new System.Windows.Forms.TabPage();
            this.dtgvManageRole = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.tpManagePrivileges = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRemovePrivilegeForUser = new System.Windows.Forms.Button();
            this.btnAddRoleForUser = new System.Windows.Forms.Button();
            this.btnAddPrivilegeForUser = new System.Windows.Forms.Button();
            this.dtgvManagePrivilegeUser = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnRemovePrivilegeForRole = new System.Windows.Forms.Button();
            this.btnAddPrivilegeForRole = new System.Windows.Forms.Button();
            this.dtgvManagePrivilegeRole = new System.Windows.Forms.DataGridView();
            this.tpCheckPrivileges = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcManager.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            this.tpPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpManageUser_Role.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageUser)).BeginInit();
            this.panel6.SuspendLayout();
            this.tpManageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageRole)).BeginInit();
            this.panel7.SuspendLayout();
            this.tpManagePrivileges.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManagePrivilegeUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManagePrivilegeRole)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcManager);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 503);
            this.panel1.TabIndex = 0;
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpUsers);
            this.tcManager.Controls.Add(this.tpPrivileges);
            this.tcManager.Controls.Add(this.tpManageUser_Role);
            this.tcManager.Controls.Add(this.tpManagePrivileges);
            this.tcManager.Controls.Add(this.tpCheckPrivileges);
            this.tcManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManager.Location = new System.Drawing.Point(3, 12);
            this.tcManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(1098, 495);
            this.tcManager.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.panel3);
            this.tpUsers.Controls.Add(this.panel2);
            this.tpUsers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUsers.Location = new System.Drawing.Point(4, 34);
            this.tpUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsers.Size = new System.Drawing.Size(1090, 457);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Danh sách người dùng";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewUser);
            this.panel3.Location = new System.Drawing.Point(774, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 448);
            this.panel3.TabIndex = 1;
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Location = new System.Drawing.Point(84, 31);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(158, 43);
            this.btnViewUser.TabIndex = 1;
            this.btnViewUser.Text = "Xem";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvUsers);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 451);
            this.panel2.TabIndex = 0;
            // 
            // dtgvUsers
            // 
            this.dtgvUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsers.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvUsers.Location = new System.Drawing.Point(3, 2);
            this.dtgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.RowHeadersWidth = 51;
            this.dtgvUsers.RowTemplate.Height = 29;
            this.dtgvUsers.Size = new System.Drawing.Size(756, 447);
            this.dtgvUsers.TabIndex = 0;
            // 
            // tpPrivileges
            // 
            this.tpPrivileges.Controls.Add(this.dtgvPrivileges);
            this.tpPrivileges.Controls.Add(this.panel4);
            this.tpPrivileges.Location = new System.Drawing.Point(4, 34);
            this.tpPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPrivileges.Name = "tpPrivileges";
            this.tpPrivileges.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPrivileges.Size = new System.Drawing.Size(1090, 457);
            this.tpPrivileges.TabIndex = 1;
            this.tpPrivileges.Text = "Thông tin quyền";
            this.tpPrivileges.UseVisualStyleBackColor = true;
            // 
            // dtgvPrivileges
            // 
            this.dtgvPrivileges.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrivileges.Location = new System.Drawing.Point(7, 4);
            this.dtgvPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPrivileges.Name = "dtgvPrivileges";
            this.dtgvPrivileges.RowHeadersWidth = 51;
            this.dtgvPrivileges.RowTemplate.Height = 29;
            this.dtgvPrivileges.Size = new System.Drawing.Size(753, 449);
            this.dtgvPrivileges.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(766, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 449);
            this.panel4.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.splitter2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.btnViewUserPrivileges);
            this.panel9.Controls.Add(this.txbUserRoleName);
            this.panel9.Location = new System.Drawing.Point(3, 234);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(311, 212);
            this.panel9.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập tên User / Role :";
            // 
            // btnViewUserPrivileges
            // 
            this.btnViewUserPrivileges.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewUserPrivileges.FlatAppearance.BorderSize = 0;
            this.btnViewUserPrivileges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUserPrivileges.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUserPrivileges.ForeColor = System.Drawing.Color.White;
            this.btnViewUserPrivileges.Location = new System.Drawing.Point(94, 132);
            this.btnViewUserPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewUserPrivileges.Name = "btnViewUserPrivileges";
            this.btnViewUserPrivileges.Size = new System.Drawing.Size(158, 43);
            this.btnViewUserPrivileges.TabIndex = 3;
            this.btnViewUserPrivileges.Text = "Xem";
            this.btnViewUserPrivileges.UseVisualStyleBackColor = false;
            this.btnViewUserPrivileges.Click += new System.EventHandler(this.btnViewUserPrivileges_Click);
            // 
            // txbUserRoleName
            // 
            this.txbUserRoleName.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txbUserRoleName.Location = new System.Drawing.Point(19, 80);
            this.txbUserRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserRoleName.Name = "txbUserRoleName";
            this.txbUserRoleName.Size = new System.Drawing.Size(289, 38);
            this.txbUserRoleName.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitter1);
            this.panel5.Controls.Add(this.btnAllPrivileges);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 225);
            this.panel5.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 222);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(311, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // btnAllPrivileges
            // 
            this.btnAllPrivileges.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAllPrivileges.FlatAppearance.BorderSize = 0;
            this.btnAllPrivileges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPrivileges.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPrivileges.ForeColor = System.Drawing.Color.White;
            this.btnAllPrivileges.Location = new System.Drawing.Point(94, 86);
            this.btnAllPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllPrivileges.Name = "btnAllPrivileges";
            this.btnAllPrivileges.Size = new System.Drawing.Size(158, 43);
            this.btnAllPrivileges.TabIndex = 4;
            this.btnAllPrivileges.Text = "Xem tất cả";
            this.btnAllPrivileges.UseVisualStyleBackColor = false;
            this.btnAllPrivileges.Click += new System.EventHandler(this.btnAllPrivileges_Click);
            // 
            // tpManageUser_Role
            // 
            this.tpManageUser_Role.Controls.Add(this.tabControl2);
            this.tpManageUser_Role.Location = new System.Drawing.Point(4, 34);
            this.tpManageUser_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageUser_Role.Name = "tpManageUser_Role";
            this.tpManageUser_Role.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageUser_Role.Size = new System.Drawing.Size(1090, 457);
            this.tpManageUser_Role.TabIndex = 2;
            this.tpManageUser_Role.Text = "Quản lý User / Role";
            this.tpManageUser_Role.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpManageUser);
            this.tabControl2.Controls.Add(this.tpManageRole);
            this.tabControl2.Location = new System.Drawing.Point(5, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1089, 466);
            this.tabControl2.TabIndex = 1;
            // 
            // tpManageUser
            // 
            this.tpManageUser.Controls.Add(this.dtgvManageUser);
            this.tpManageUser.Controls.Add(this.panel6);
            this.tpManageUser.Location = new System.Drawing.Point(4, 34);
            this.tpManageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageUser.Name = "tpManageUser";
            this.tpManageUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageUser.Size = new System.Drawing.Size(1081, 428);
            this.tpManageUser.TabIndex = 0;
            this.tpManageUser.Text = "User";
            this.tpManageUser.UseVisualStyleBackColor = true;
            // 
            // dtgvManageUser
            // 
            this.dtgvManageUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageUser.Location = new System.Drawing.Point(3, 0);
            this.dtgvManageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvManageUser.Name = "dtgvManageUser";
            this.dtgvManageUser.RowHeadersWidth = 51;
            this.dtgvManageUser.RowTemplate.Height = 29;
            this.dtgvManageUser.Size = new System.Drawing.Size(753, 417);
            this.dtgvManageUser.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEditUser);
            this.panel6.Controls.Add(this.btnDropUser);
            this.panel6.Controls.Add(this.btnCreateUser);
            this.panel6.Location = new System.Drawing.Point(762, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(316, 417);
            this.panel6.TabIndex = 4;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(83, 262);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(158, 43);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Chỉnh sửa User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDropUser
            // 
            this.btnDropUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDropUser.FlatAppearance.BorderSize = 0;
            this.btnDropUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropUser.ForeColor = System.Drawing.Color.White;
            this.btnDropUser.Location = new System.Drawing.Point(83, 188);
            this.btnDropUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropUser.Name = "btnDropUser";
            this.btnDropUser.Size = new System.Drawing.Size(158, 43);
            this.btnDropUser.TabIndex = 6;
            this.btnDropUser.Text = "Xóa User";
            this.btnDropUser.UseVisualStyleBackColor = false;
            this.btnDropUser.Click += new System.EventHandler(this.btnDropUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Location = new System.Drawing.Point(83, 113);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(158, 43);
            this.btnCreateUser.TabIndex = 5;
            this.btnCreateUser.Text = "Tạo User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tpManageRole
            // 
            this.tpManageRole.Controls.Add(this.dtgvManageRole);
            this.tpManageRole.Controls.Add(this.panel7);
            this.tpManageRole.Location = new System.Drawing.Point(4, 34);
            this.tpManageRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageRole.Name = "tpManageRole";
            this.tpManageRole.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManageRole.Size = new System.Drawing.Size(1081, 428);
            this.tpManageRole.TabIndex = 1;
            this.tpManageRole.Text = "Role";
            this.tpManageRole.UseVisualStyleBackColor = true;
            // 
            // dtgvManageRole
            // 
            this.dtgvManageRole.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvManageRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageRole.Location = new System.Drawing.Point(3, 2);
            this.dtgvManageRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvManageRole.Name = "dtgvManageRole";
            this.dtgvManageRole.RowHeadersWidth = 51;
            this.dtgvManageRole.RowTemplate.Height = 29;
            this.dtgvManageRole.Size = new System.Drawing.Size(753, 415);
            this.dtgvManageRole.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEditRole);
            this.panel7.Controls.Add(this.btnDropRole);
            this.panel7.Controls.Add(this.btnCreateRole);
            this.panel7.Location = new System.Drawing.Point(760, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(318, 416);
            this.panel7.TabIndex = 6;
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditRole.FlatAppearance.BorderSize = 0;
            this.btnEditRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.Location = new System.Drawing.Point(84, 259);
            this.btnEditRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(158, 43);
            this.btnEditRole.TabIndex = 10;
            this.btnEditRole.Text = "Chỉnh sửa Role";
            this.btnEditRole.UseVisualStyleBackColor = false;
            // 
            // btnDropRole
            // 
            this.btnDropRole.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDropRole.FlatAppearance.BorderSize = 0;
            this.btnDropRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropRole.ForeColor = System.Drawing.Color.White;
            this.btnDropRole.Location = new System.Drawing.Point(84, 185);
            this.btnDropRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(158, 43);
            this.btnDropRole.TabIndex = 9;
            this.btnDropRole.Text = "Xóa Role";
            this.btnDropRole.UseVisualStyleBackColor = false;
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateRole.FlatAppearance.BorderSize = 0;
            this.btnCreateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRole.ForeColor = System.Drawing.Color.White;
            this.btnCreateRole.Location = new System.Drawing.Point(84, 110);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(158, 43);
            this.btnCreateRole.TabIndex = 8;
            this.btnCreateRole.Text = "Tạo Role";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // tpManagePrivileges
            // 
            this.tpManagePrivileges.Controls.Add(this.tabControl3);
            this.tpManagePrivileges.Location = new System.Drawing.Point(4, 34);
            this.tpManagePrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManagePrivileges.Name = "tpManagePrivileges";
            this.tpManagePrivileges.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManagePrivileges.Size = new System.Drawing.Size(1090, 457);
            this.tpManagePrivileges.TabIndex = 3;
            this.tpManagePrivileges.Text = "Quản lý quyền";
            this.tpManagePrivileges.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Location = new System.Drawing.Point(5, 2);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1079, 464);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Controls.Add(this.dtgvManagePrivilegeUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1071, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnRemovePrivilegeForUser);
            this.panel10.Controls.Add(this.btnAddRoleForUser);
            this.panel10.Controls.Add(this.btnAddPrivilegeForUser);
            this.panel10.Location = new System.Drawing.Point(763, 3);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(318, 416);
            this.panel10.TabIndex = 7;
            // 
            // btnRemovePrivilegeForUser
            // 
            this.btnRemovePrivilegeForUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemovePrivilegeForUser.FlatAppearance.BorderSize = 0;
            this.btnRemovePrivilegeForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrivilegeForUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrivilegeForUser.ForeColor = System.Drawing.Color.White;
            this.btnRemovePrivilegeForUser.Location = new System.Drawing.Point(84, 259);
            this.btnRemovePrivilegeForUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePrivilegeForUser.Name = "btnRemovePrivilegeForUser";
            this.btnRemovePrivilegeForUser.Size = new System.Drawing.Size(158, 43);
            this.btnRemovePrivilegeForUser.TabIndex = 10;
            this.btnRemovePrivilegeForUser.Text = "Thu hồi quyền";
            this.btnRemovePrivilegeForUser.UseVisualStyleBackColor = false;
            this.btnRemovePrivilegeForUser.Click += new System.EventHandler(this.btnRemovePrivilegeForUser_Click);
            // 
            // btnAddRoleForUser
            // 
            this.btnAddRoleForUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddRoleForUser.FlatAppearance.BorderSize = 0;
            this.btnAddRoleForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoleForUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoleForUser.ForeColor = System.Drawing.Color.White;
            this.btnAddRoleForUser.Location = new System.Drawing.Point(84, 185);
            this.btnAddRoleForUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoleForUser.Name = "btnAddRoleForUser";
            this.btnAddRoleForUser.Size = new System.Drawing.Size(158, 43);
            this.btnAddRoleForUser.TabIndex = 9;
            this.btnAddRoleForUser.Text = "Cấp Role";
            this.btnAddRoleForUser.UseVisualStyleBackColor = false;
            this.btnAddRoleForUser.Click += new System.EventHandler(this.btnAddRoleForUser_Click);
            // 
            // btnAddPrivilegeForUser
            // 
            this.btnAddPrivilegeForUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPrivilegeForUser.FlatAppearance.BorderSize = 0;
            this.btnAddPrivilegeForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrivilegeForUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrivilegeForUser.ForeColor = System.Drawing.Color.White;
            this.btnAddPrivilegeForUser.Location = new System.Drawing.Point(84, 110);
            this.btnAddPrivilegeForUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPrivilegeForUser.Name = "btnAddPrivilegeForUser";
            this.btnAddPrivilegeForUser.Size = new System.Drawing.Size(158, 43);
            this.btnAddPrivilegeForUser.TabIndex = 8;
            this.btnAddPrivilegeForUser.Text = "Cấp quyền";
            this.btnAddPrivilegeForUser.UseVisualStyleBackColor = false;
            this.btnAddPrivilegeForUser.Click += new System.EventHandler(this.btnAddPrivilegeForUser_Click);
            // 
            // dtgvManagePrivilegeUser
            // 
            this.dtgvManagePrivilegeUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvManagePrivilegeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManagePrivilegeUser.Location = new System.Drawing.Point(3, 4);
            this.dtgvManagePrivilegeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvManagePrivilegeUser.Name = "dtgvManagePrivilegeUser";
            this.dtgvManagePrivilegeUser.RowHeadersWidth = 51;
            this.dtgvManagePrivilegeUser.RowTemplate.Height = 29;
            this.dtgvManagePrivilegeUser.Size = new System.Drawing.Size(753, 413);
            this.dtgvManagePrivilegeUser.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.dtgvManagePrivilegeRole);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1071, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnRemovePrivilegeForRole);
            this.panel8.Controls.Add(this.btnAddPrivilegeForRole);
            this.panel8.Location = new System.Drawing.Point(757, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(318, 416);
            this.panel8.TabIndex = 8;
            // 
            // btnRemovePrivilegeForRole
            // 
            this.btnRemovePrivilegeForRole.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemovePrivilegeForRole.FlatAppearance.BorderSize = 0;
            this.btnRemovePrivilegeForRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrivilegeForRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrivilegeForRole.ForeColor = System.Drawing.Color.White;
            this.btnRemovePrivilegeForRole.Location = new System.Drawing.Point(84, 182);
            this.btnRemovePrivilegeForRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePrivilegeForRole.Name = "btnRemovePrivilegeForRole";
            this.btnRemovePrivilegeForRole.Size = new System.Drawing.Size(158, 43);
            this.btnRemovePrivilegeForRole.TabIndex = 10;
            this.btnRemovePrivilegeForRole.Text = "Thu hồi quyền";
            this.btnRemovePrivilegeForRole.UseVisualStyleBackColor = false;
            // 
            // btnAddPrivilegeForRole
            // 
            this.btnAddPrivilegeForRole.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPrivilegeForRole.FlatAppearance.BorderSize = 0;
            this.btnAddPrivilegeForRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrivilegeForRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrivilegeForRole.ForeColor = System.Drawing.Color.White;
            this.btnAddPrivilegeForRole.Location = new System.Drawing.Point(84, 110);
            this.btnAddPrivilegeForRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPrivilegeForRole.Name = "btnAddPrivilegeForRole";
            this.btnAddPrivilegeForRole.Size = new System.Drawing.Size(158, 43);
            this.btnAddPrivilegeForRole.TabIndex = 8;
            this.btnAddPrivilegeForRole.Text = "Cấp quyền";
            this.btnAddPrivilegeForRole.UseVisualStyleBackColor = false;
            this.btnAddPrivilegeForRole.Click += new System.EventHandler(this.btnAddPrivilegeForRole_Click);
            // 
            // dtgvManagePrivilegeRole
            // 
            this.dtgvManagePrivilegeRole.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvManagePrivilegeRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManagePrivilegeRole.Location = new System.Drawing.Point(1, 0);
            this.dtgvManagePrivilegeRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvManagePrivilegeRole.Name = "dtgvManagePrivilegeRole";
            this.dtgvManagePrivilegeRole.RowHeadersWidth = 51;
            this.dtgvManagePrivilegeRole.RowTemplate.Height = 29;
            this.dtgvManagePrivilegeRole.Size = new System.Drawing.Size(753, 417);
            this.dtgvManagePrivilegeRole.TabIndex = 7;
            // 
            // tpCheckPrivileges
            // 
            this.tpCheckPrivileges.Location = new System.Drawing.Point(4, 34);
            this.tpCheckPrivileges.Name = "tpCheckPrivileges";
            this.tpCheckPrivileges.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckPrivileges.Size = new System.Drawing.Size(1090, 457);
            this.tpCheckPrivileges.TabIndex = 4;
            this.tpCheckPrivileges.Text = "Quyền chủ thể";
            this.tpCheckPrivileges.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(935, 524);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 43);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // F_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.F_Manager_Load);
            this.panel1.ResumeLayout(false);
            this.tcManager.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            this.tpPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tpManageUser_Role.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpManageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageUser)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tpManageRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageRole)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tpManagePrivileges.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManagePrivilegeUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManagePrivilegeRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.TabPage tpPrivileges;
        private System.Windows.Forms.TabPage tpManageUser_Role;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpManageUser;
        private System.Windows.Forms.DataGridView dtgvManageUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tpManageRole;
        private System.Windows.Forms.DataGridView dtgvManageRole;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tpManagePrivileges;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvManagePrivilegeUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvManagePrivilegeRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDropUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnRemovePrivilegeForUser;
        private System.Windows.Forms.Button btnAddRoleForUser;
        private System.Windows.Forms.Button btnAddPrivilegeForUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnRemovePrivilegeForRole;
        private System.Windows.Forms.Button btnAddPrivilegeForRole;
        private System.Windows.Forms.DataGridView dtgvPrivileges;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewUserPrivileges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserRoleName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAllPrivileges;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabPage tpCheckPrivileges;
    }
}


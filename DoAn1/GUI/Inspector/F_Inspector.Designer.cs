
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
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.tpFacility = new System.Windows.Forms.TabPage();
            this.dtgvFacility = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tcManager.SuspendLayout();
            this.tpMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).BeginInit();
            this.tpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServices)).BeginInit();
            this.tpEmployee.SuspendLayout();
            this.tpPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.tpFacility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpMedicalRecord);
            this.tcManager.Controls.Add(this.tpService);
            this.tcManager.Controls.Add(this.tpEmployee);
            this.tcManager.Controls.Add(this.tpPatient);
            this.tcManager.Controls.Add(this.tpFacility);
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
            this.tpPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.tpFacility.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacility)).EndInit();
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
    }
}
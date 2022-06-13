
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
            this.tcManager.SuspendLayout();
            this.tpMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpMedicalRecord);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpMedicalRecord;
        private System.Windows.Forms.DataGridView dtgvMedicalRecords;
        private System.Windows.Forms.Button btnLogout;
    }
}
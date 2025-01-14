namespace LKS_Mart_2024.WinForms
{
    partial class FormDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNonAdmin = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pbUserRole = new System.Windows.Forms.PictureBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.panelAdminBtns = new System.Windows.Forms.Panel();
            this.btnLogActivity = new System.Windows.Forms.Button();
            this.btnKelolaLaporan = new System.Windows.Forms.Button();
            this.btnKelolaUser = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUCActive = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnNamaKasir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserRole)).BeginInit();
            this.panelAdminBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblNonAdmin);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.pbUserRole);
            this.panel1.Controls.Add(this.lblUserRole);
            this.panel1.Controls.Add(this.panelAdminBtns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 561);
            this.panel1.TabIndex = 0;
            // 
            // lblNonAdmin
            // 
            this.lblNonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonAdmin.ForeColor = System.Drawing.Color.White;
            this.lblNonAdmin.Location = new System.Drawing.Point(0, 260);
            this.lblNonAdmin.Name = "lblNonAdmin";
            this.lblNonAdmin.Size = new System.Drawing.Size(238, 159);
            this.lblNonAdmin.TabIndex = 4;
            this.lblNonAdmin.Text = "User Role";
            this.lblNonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonAdmin.Visible = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Crimson;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(23, 494);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(200, 36);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pbUserRole
            // 
            this.pbUserRole.Image = global::LKS_Mart_2024.Properties.Resources.administrator_1;
            this.pbUserRole.InitialImage = global::LKS_Mart_2024.Properties.Resources.Logo;
            this.pbUserRole.Location = new System.Drawing.Point(36, 92);
            this.pbUserRole.Name = "pbUserRole";
            this.pbUserRole.Size = new System.Drawing.Size(165, 165);
            this.pbUserRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUserRole.TabIndex = 3;
            this.pbUserRole.TabStop = false;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(3, 32);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(238, 37);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "User Role";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdminBtns
            // 
            this.panelAdminBtns.Controls.Add(this.btnLogActivity);
            this.panelAdminBtns.Controls.Add(this.btnKelolaLaporan);
            this.panelAdminBtns.Controls.Add(this.btnKelolaUser);
            this.panelAdminBtns.Location = new System.Drawing.Point(23, 272);
            this.panelAdminBtns.Name = "panelAdminBtns";
            this.panelAdminBtns.Size = new System.Drawing.Size(200, 159);
            this.panelAdminBtns.TabIndex = 0;
            this.panelAdminBtns.Visible = false;
            // 
            // btnLogActivity
            // 
            this.btnLogActivity.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogActivity.ForeColor = System.Drawing.Color.White;
            this.btnLogActivity.Location = new System.Drawing.Point(0, 107);
            this.btnLogActivity.Name = "btnLogActivity";
            this.btnLogActivity.Size = new System.Drawing.Size(200, 36);
            this.btnLogActivity.TabIndex = 2;
            this.btnLogActivity.Text = "Log Activity";
            this.btnLogActivity.UseVisualStyleBackColor = false;
            this.btnLogActivity.Click += new System.EventHandler(this.btnLogActivity_Click);
            // 
            // btnKelolaLaporan
            // 
            this.btnKelolaLaporan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaLaporan.ForeColor = System.Drawing.Color.White;
            this.btnKelolaLaporan.Location = new System.Drawing.Point(0, 65);
            this.btnKelolaLaporan.Name = "btnKelolaLaporan";
            this.btnKelolaLaporan.Size = new System.Drawing.Size(200, 36);
            this.btnKelolaLaporan.TabIndex = 3;
            this.btnKelolaLaporan.Text = "Kelola Laporan";
            this.btnKelolaLaporan.UseVisualStyleBackColor = false;
            this.btnKelolaLaporan.Click += new System.EventHandler(this.btnKelolaLaporan_Click);
            // 
            // btnKelolaUser
            // 
            this.btnKelolaUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaUser.ForeColor = System.Drawing.Color.White;
            this.btnKelolaUser.Location = new System.Drawing.Point(0, 23);
            this.btnKelolaUser.Name = "btnKelolaUser";
            this.btnKelolaUser.Size = new System.Drawing.Size(200, 36);
            this.btnKelolaUser.TabIndex = 4;
            this.btnKelolaUser.Text = "Kelola User";
            this.btnKelolaUser.UseVisualStyleBackColor = false;
            this.btnKelolaUser.Click += new System.EventHandler(this.btnKelolaUser_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDashboard.Location = new System.Drawing.Point(241, 49);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(643, 512);
            this.panelDashboard.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Page / Dashboard";
            // 
            // lblUCActive
            // 
            this.lblUCActive.AutoSize = true;
            this.lblUCActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCActive.ForeColor = System.Drawing.Color.Black;
            this.lblUCActive.Location = new System.Drawing.Point(247, 22);
            this.lblUCActive.Name = "lblUCActive";
            this.lblUCActive.Size = new System.Drawing.Size(154, 18);
            this.lblUCActive.TabIndex = 4;
            this.lblUCActive.Text = "User Control active";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblDateTime.Location = new System.Drawing.Point(641, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(231, 37);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Selasa, 24 Desember 2024 12:32:13";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnNamaKasir
            // 
            this.btnNamaKasir.AutoSize = true;
            this.btnNamaKasir.Enabled = false;
            this.btnNamaKasir.Location = new System.Drawing.Point(797, 17);
            this.btnNamaKasir.Name = "btnNamaKasir";
            this.btnNamaKasir.Size = new System.Drawing.Size(75, 23);
            this.btnNamaKasir.TabIndex = 6;
            this.btnNamaKasir.Text = "Kasir 1";
            this.btnNamaKasir.UseVisualStyleBackColor = true;
            this.btnNamaKasir.Visible = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnNamaKasir);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUCActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDashboard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserRole)).EndInit();
            this.panelAdminBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdminBtns;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.PictureBox pbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnKelolaUser;
        private System.Windows.Forms.Button btnLogActivity;
        private System.Windows.Forms.Button btnKelolaLaporan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUCActive;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNonAdmin;
        private System.Windows.Forms.Button btnNamaKasir;
    }
}
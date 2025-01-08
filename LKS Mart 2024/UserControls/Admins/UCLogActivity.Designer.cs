namespace LKS_Mart_2024.UserControls.Admins
{
    partial class UCLogActivity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUCActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvLogActivity = new System.Windows.Forms.DataGridView();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUCActive
            // 
            this.lblUCActive.AutoSize = true;
            this.lblUCActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCActive.ForeColor = System.Drawing.Color.Black;
            this.lblUCActive.Location = new System.Drawing.Point(38, 44);
            this.lblUCActive.Name = "lblUCActive";
            this.lblUCActive.Size = new System.Drawing.Size(98, 18);
            this.lblUCActive.TabIndex = 5;
            this.lblUCActive.Text = "Dari tanggal";
            this.lblUCActive.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sampai tanggal";
            this.label1.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(41, 66);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(194, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpUntil
            // 
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntil.Location = new System.Drawing.Point(255, 66);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(194, 20);
            this.dtpUntil.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSize = true;
            this.btnFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(480, 61);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(109, 35);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvLogActivity
            // 
            this.dgvLogActivity.AllowUserToAddRows = false;
            this.dgvLogActivity.AllowUserToDeleteRows = false;
            this.dgvLogActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvLogActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmUsername,
            this.clmDateTime,
            this.clmActivity});
            this.dgvLogActivity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLogActivity.Location = new System.Drawing.Point(0, 132);
            this.dgvLogActivity.MultiSelect = false;
            this.dgvLogActivity.Name = "dgvLogActivity";
            this.dgvLogActivity.ReadOnly = true;
            this.dgvLogActivity.Size = new System.Drawing.Size(643, 380);
            this.dgvLogActivity.TabIndex = 9;
            this.dgvLogActivity.TabStop = false;
            // 
            // clmNo
            // 
            this.clmNo.HeaderText = "No";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            // 
            // clmUsername
            // 
            this.clmUsername.HeaderText = "Username";
            this.clmUsername.Name = "clmUsername";
            this.clmUsername.ReadOnly = true;
            // 
            // clmDateTime
            // 
            this.clmDateTime.HeaderText = "Waktu";
            this.clmDateTime.Name = "clmDateTime";
            this.clmDateTime.ReadOnly = true;
            // 
            // clmActivity
            // 
            this.clmActivity.HeaderText = "Aktivitas";
            this.clmActivity.Name = "clmActivity";
            this.clmActivity.ReadOnly = true;
            // 
            // UCLogActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLogActivity);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUCActive);
            this.Name = "UCLogActivity";
            this.Size = new System.Drawing.Size(643, 512);
            this.Load += new System.EventHandler(this.UCLogActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUCActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvLogActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivity;
    }
}

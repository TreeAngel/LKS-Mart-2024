namespace LKS_Mart_2024.WinForms
{
    partial class FormReport
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
            this.keranjangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keranjangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rvKeranjang = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.keranjangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // keranjangBindingSource
            // 
            this.keranjangBindingSource.DataSource = typeof(LKS_Mart_2024.Util.Keranjang);
            // 
            // keranjangBindingSource1
            // 
            this.keranjangBindingSource1.DataSource = typeof(LKS_Mart_2024.Util.Keranjang);
            // 
            // rvKeranjang
            // 
            this.rvKeranjang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvKeranjang.LocalReport.ReportEmbeddedResource = "LKS_Mart_2024.Util.TransaksiReport.rdlc";
            this.rvKeranjang.Location = new System.Drawing.Point(0, 0);
            this.rvKeranjang.Name = "rvKeranjang";
            this.rvKeranjang.ServerReport.BearerToken = null;
            this.rvKeranjang.Size = new System.Drawing.Size(868, 522);
            this.rvKeranjang.TabIndex = 0;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.ControlBox = false;
            this.Controls.Add(this.rvKeranjang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keranjangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjangBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource keranjangBindingSource;
        private System.Windows.Forms.BindingSource keranjangBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer rvKeranjang;
    }
}
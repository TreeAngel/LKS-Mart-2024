﻿namespace LKS_Mart_2024.UserControls
{
    partial class UCKasir
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHargaSatuan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamaPelanggan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCash2Pay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.numQty);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.tbTelepon);
            this.panelInput.Controls.Add(this.cbMenu);
            this.panelInput.Controls.Add(this.btnReset);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.tbHargaSatuan);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.tbTotalHarga);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.tbNamaPelanggan);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(643, 160);
            this.panelInput.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilih Menu";
            // 
            // tbTelepon
            // 
            this.tbTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelepon.Location = new System.Drawing.Point(47, 79);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(194, 20);
            this.tbTelepon.TabIndex = 3;
            // 
            // cbMenu
            // 
            this.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Items.AddRange(new object[] {
            "gudang",
            "kasir"});
            this.cbMenu.Location = new System.Drawing.Point(47, 34);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(194, 21);
            this.cbMenu.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(486, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telepon";
            // 
            // tbHargaSatuan
            // 
            this.tbHargaSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHargaSatuan.Enabled = false;
            this.tbHargaSatuan.Location = new System.Drawing.Point(257, 35);
            this.tbHargaSatuan.Name = "tbHargaSatuan";
            this.tbHargaSatuan.ReadOnly = true;
            this.tbHargaSatuan.Size = new System.Drawing.Size(194, 20);
            this.tbHargaSatuan.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(486, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Harga";
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalHarga.Enabled = false;
            this.tbTotalHarga.Location = new System.Drawing.Point(257, 124);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.ReadOnly = true;
            this.tbTotalHarga.Size = new System.Drawing.Size(194, 20);
            this.tbTotalHarga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantitas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama Pelanggan";
            // 
            // tbNamaPelanggan
            // 
            this.tbNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamaPelanggan.Location = new System.Drawing.Point(47, 123);
            this.tbNamaPelanggan.Name = "tbNamaPelanggan";
            this.tbNamaPelanggan.Size = new System.Drawing.Size(194, 20);
            this.tbNamaPelanggan.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoSize = true;
            this.btnSimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(436, 436);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(172, 30);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Print/Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBayar
            // 
            this.btnBayar.AutoSize = true;
            this.btnBayar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(47, 436);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(194, 30);
            this.btnBayar.TabIndex = 24;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cash";
            // 
            // tbCash2Pay
            // 
            this.tbCash2Pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCash2Pay.Location = new System.Drawing.Point(93, 413);
            this.tbCash2Pay.Name = "tbCash2Pay";
            this.tbCash2Pay.Size = new System.Drawing.Size(148, 20);
            this.tbCash2Pay.TabIndex = 12;
            this.tbCash2Pay.Text = "Rp.000.000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(44, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Jumlah Kembalian:";
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKembalian.Location = new System.Drawing.Point(177, 479);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(82, 17);
            this.lblKembalian.TabIndex = 26;
            this.lblKembalian.Text = "Rp.000.000";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalHarga.Location = new System.Drawing.Point(526, 399);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(82, 17);
            this.lblTotalHarga.TabIndex = 28;
            this.lblTotalHarga.Text = "Rp.000.000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(433, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total Harga:";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDisc.Location = new System.Drawing.Point(526, 416);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(82, 17);
            this.lblDisc.TabIndex = 30;
            this.lblDisc.Text = "Rp.000.000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(433, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Disc:";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmIdBarang,
            this.clmKodeBarang,
            this.clmNamaBarang,
            this.clmExpiredDate,
            this.clmQty,
            this.clmSatuan,
            this.clmHargaSatuan});
            this.dgvKeranjang.Location = new System.Drawing.Point(0, 184);
            this.dgvKeranjang.MultiSelect = false;
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.RowHeadersVisible = false;
            this.dgvKeranjang.Size = new System.Drawing.Size(643, 208);
            this.dgvKeranjang.TabIndex = 31;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmIdBarang
            // 
            this.clmIdBarang.HeaderText = "ID Barang";
            this.clmIdBarang.Name = "clmIdBarang";
            this.clmIdBarang.ReadOnly = true;
            // 
            // clmKodeBarang
            // 
            this.clmKodeBarang.HeaderText = "Kode Barang";
            this.clmKodeBarang.Name = "clmKodeBarang";
            this.clmKodeBarang.ReadOnly = true;
            // 
            // clmNamaBarang
            // 
            this.clmNamaBarang.HeaderText = "Nama Barang";
            this.clmNamaBarang.Name = "clmNamaBarang";
            this.clmNamaBarang.ReadOnly = true;
            // 
            // clmExpiredDate
            // 
            this.clmExpiredDate.HeaderText = "Expired Date";
            this.clmExpiredDate.Name = "clmExpiredDate";
            this.clmExpiredDate.ReadOnly = true;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "Qty";
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            // 
            // clmSatuan
            // 
            this.clmSatuan.HeaderText = "Satuan";
            this.clmSatuan.Name = "clmSatuan";
            this.clmSatuan.ReadOnly = true;
            // 
            // clmHargaSatuan
            // 
            this.clmHargaSatuan.HeaderText = "Harga Satuan";
            this.clmHargaSatuan.Name = "clmHargaSatuan";
            this.clmHargaSatuan.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "Keranjang";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(257, 80);
            this.numQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(194, 20);
            this.numQty.TabIndex = 12;
            // 
            // UCKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCash2Pay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.panelInput);
            this.Name = "UCKasir";
            this.Size = new System.Drawing.Size(643, 512);
            this.Load += new System.EventHandler(this.UCKasir_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHargaSatuan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNamaPelanggan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCash2Pay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaSatuan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numQty;
    }
}

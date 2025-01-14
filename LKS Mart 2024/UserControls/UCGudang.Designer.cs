namespace LKS_Mart_2024.UserControls
{
    partial class UCGudang
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
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSatuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.panelInput = new System.Windows.Forms.Panel();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.numJumlahBarang = new System.Windows.Forms.NumericUpDown();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKode
            // 
            this.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKode.Location = new System.Drawing.Point(144, 35);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(253, 20);
            this.tbKode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kode Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jumlah Barang";
            // 
            // tbSatuan
            // 
            this.tbSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSatuan.Location = new System.Drawing.Point(144, 123);
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.Size = new System.Drawing.Size(253, 20);
            this.tbSatuan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Satuan ";
            // 
            // tbNama
            // 
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNama.Location = new System.Drawing.Point(144, 92);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(253, 20);
            this.tbNama.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nama Barang";
            // 
            // tbHarga
            // 
            this.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHarga.Location = new System.Drawing.Point(144, 180);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(253, 20);
            this.tbHarga.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Harga Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Expired Date";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(477, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(475, 113);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(475, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpExpired
            // 
            this.dtpExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpired.Location = new System.Drawing.Point(144, 149);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.Size = new System.Drawing.Size(252, 20);
            this.dtpExpired.TabIndex = 19;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.numJumlahBarang);
            this.panelInput.Controls.Add(this.dtpExpired);
            this.panelInput.Controls.Add(this.tbKode);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.btnEdit);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.tbHarga);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.tbNama);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.tbSatuan);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(643, 232);
            this.panelInput.TabIndex = 20;
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmIdBarang,
            this.clmKodeBarang,
            this.clmNamaBarang,
            this.clmExpiredDate,
            this.clmQty,
            this.clmSatuan,
            this.clmHargaSatuan});
            this.dgvBarang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBarang.Location = new System.Drawing.Point(0, 294);
            this.dgvBarang.MultiSelect = false;
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersVisible = false;
            this.dgvBarang.Size = new System.Drawing.Size(643, 218);
            this.dgvBarang.TabIndex = 21;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellContentClick);
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
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(556, 249);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(378, 256);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(173, 20);
            this.tbSearch.TabIndex = 22;
            // 
            // numJumlahBarang
            // 
            this.numJumlahBarang.Location = new System.Drawing.Point(144, 66);
            this.numJumlahBarang.Name = "numJumlahBarang";
            this.numJumlahBarang.Size = new System.Drawing.Size(253, 20);
            this.numJumlahBarang.TabIndex = 20;
            // 
            // UCGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.panelInput);
            this.Name = "UCGudang";
            this.Size = new System.Drawing.Size(643, 512);
            this.Load += new System.EventHandler(this.UCGudang_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSatuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaSatuan;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.NumericUpDown numJumlahBarang;
    }
}

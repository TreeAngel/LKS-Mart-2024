using LKS_Mart_2024.Helper;
using LKS_Mart_2024.Util;
using LKS_Mart_2024.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Mart_2024.UserControls
{
    public partial class UCKasir : UserControl
    {
        List<tbl_barang> menuList = new List<tbl_barang>();
        List<Keranjang> keranjang = new List<Keranjang>();
        tbl_barang barang = new tbl_barang();
        tbl_pelanggan customer = new tbl_pelanggan();
        bool isPayed = false;
        string transaksiId;

        public UCKasir()
        {
            InitializeComponent();
        }

        private void UCKasir_Load(object sender, EventArgs e)
        {
            HelperClass.ClearValue(this);
            if (keranjang.Count <= 0)
            {
                btnSimpan.Enabled = false;
            }
            tbTelepon.KeyPress += HelperClass.TextBoxNumberOnly;
            GetMenu();
        }

        private void GetMenu()
        {
            if (menuList.Count > 0)
            {
                menuList.Clear();
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            try
            {
                var data = entities.tbl_barang.ToList();
                cbMenu.Items.Clear();
                foreach (var item in data)
                {
                    menuList.Add(item);
                    cbMenu.Items.Add($"{item.kode} - {item.nama}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!HelperClass.ValidateValue(panelInput) || barang.id <= 0)
            {
                MessageBox.Show("Isi semua data penting");
                return;
            }
            if (customer.id <= 0)
            {
                if (MessageBox.Show("Pelanggan tidak terdaftar, tambah baru?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (String.IsNullOrEmpty(tbNamaPelanggan.Text))
                {
                    MessageBox.Show("Isi nama pelanggan untuk tambah baru");
                    return;
                }
                try
                {
                    LKSMart2024Entities entities = new LKSMart2024Entities();
                    entities.tbl_pelanggan.Add(new tbl_pelanggan
                    {
                        nama = tbNamaPelanggan.Text,
                        telepon = tbTelepon.Text,
                    });
                    entities.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            if (MessageBox.Show("Tambah ke keranjang?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                LKSMart2024Entities entities = new LKSMart2024Entities();
                Keranjang itemAlreadyExist = keranjang.FirstOrDefault(x => x.barangId.Equals(barang.id));
                if (String.IsNullOrEmpty(transaksiId) && barang.id > 0)
                {
                    int trNum = entities.tbl_transaksi.Count();
                    transaksiId = $"TR{trNum + 1}";
                }
                if (itemAlreadyExist != null)
                {
                    itemAlreadyExist.qty += (int)numQty.Value;
                }
                else
                {
                    keranjang.Add(new Keranjang
                    {
                        userId = HelperClass.userSession.id,
                        barangId = barang.id,
                        kodeTransaksi = transaksiId,
                        kodeBarang = barang.kode,
                        namaBarang = barang.nama,
                        harga = (int)barang.harga_satuan,
                        qty = (int)numQty.Value,
                    });
                }
                dgvKeranjang.Rows.Clear();
                foreach (var item in keranjang)
                {
                    dgvKeranjang.Rows.Add(new object[]
                    {
                        item.kodeTransaksi,
                        item.kodeBarang,
                        item.namaBarang,
                        item.harga,
                        item.qty,
                        item.subtotal,
                    });
                }
                if (keranjang.Count <= 0)
                {
                    btnSimpan.Enabled = false;
                }
                else
                {
                    btnSimpan.Enabled = true;
                }
                lblTotalHarga.Text = $"Rp.{keranjang.Sum(x => x.subtotal)}";
                HelperClass.ClearValue(panelInput);

                MessageBox.Show("Item berhasil ditambah ke keranjang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset input?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HelperClass.ClearValue(panelInput);
            }
            if (MessageBox.Show("Kosongkan keranjang?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetTransaksi();
            }
        }

        private void ResetTransaksi()
        {
            HelperClass.ClearValue(panelInput1);
            HelperClass.ClearValue(panelInput2);
            tbCash2Pay.Clear();
            keranjang.Clear();
            dgvKeranjang.Rows.Clear();
            lblKembalian.Text = "Rp.000.000";
            lblTotalHarga.Text = "Rp.000.000";
            isPayed = false;
            tbCash2Pay.Enabled = true;
            btnBayar.Enabled = true;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == -1)
            {
                return;
            }
            barang = menuList[cb.SelectedIndex];
            tbHargaSatuan.Text = $"Rp.{barang.harga_satuan}";
            numQty.Maximum = barang.jumlah;
            tbTotalHarga.Text = $"Rp.{numQty.Value * barang.harga_satuan}";
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            if (barang.id <= 0)
            {
                return;
            }
            else
            {
                tbTotalHarga.Text = $"Rp.{numQty.Value * barang.harga_satuan}";
            }
        }

        private void tbTelepon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LKSMart2024Entities entities = new LKSMart2024Entities();
                tbl_pelanggan curCustomer = entities.tbl_pelanggan.FirstOrDefault(x => x.telepon.Equals(tbTelepon.Text));
                if (curCustomer == null)
                {
                    tbNamaPelanggan.Clear();
                    tbNamaPelanggan.ReadOnly = false;
                    return;
                }
                customer = curCustomer;
                tbNamaPelanggan.Text = customer.nama;
                tbNamaPelanggan.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCash2Pay.Text))
            {
                MessageBox.Show("Isi jumlah uang yang dibayarkan");
                return;
            }
            long exchange = Convert.ToInt64(tbCash2Pay.Text) - Convert.ToInt64(keranjang.Sum(x => x.subtotal));
            if (exchange < 0)
            {
                MessageBox.Show("Uang pembayaran kurang!");
                return;
            }
            else
            {
                lblKembalian.Text = $"Rp.{exchange}";
                isPayed = true;
                tbCash2Pay.Enabled = false;
                btnBayar.Enabled = false;
            }
            if (MessageBox.Show("Simpan data transaksi?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveTransactionToDB();
            }
        }

        private void SaveTransactionToDB()
        {
            try
            {
                LKSMart2024Entities entities = new LKSMart2024Entities();
                DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                foreach (var item in keranjang)
                {
                    entities.tbl_transaksi.Add(new tbl_transaksi
                    {
                        no = transaksiId,
                        tanggal = currentDate,
                        nama_kasir = HelperClass.userSession.nama,
                        total_bayar = item.subtotal,
                        user_id = HelperClass.userSession.id,
                        pelanggan_id = customer.id,
                        barang_id = item.barangId,
                    });
                }
                entities.SaveChanges();
                if (MessageBox.Show("Reset transaksi?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetTransaksi();
                }
                MessageBox.Show("Transaksi berhasil disimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (keranjang.Count <= 0)
            {
                MessageBox.Show("Keranjang kosong!");
                return;
            }
            if (!isPayed)
            {
                MessageBox.Show("Selesaikan pembayaran!");
                return;
            }
            SaveTransactionToDB();
            if (MessageBox.Show("Print data transaksi?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new FormReport(keranjang).ShowDialog();
            }
            if (MessageBox.Show("Reset transaksi", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetTransaksi();
            }
        }

        private void panelInput2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbNamaPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbTelepon_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                LKSMart2024Entities entities = new LKSMart2024Entities();
                tbl_pelanggan curCustomer = entities.tbl_pelanggan.FirstOrDefault(x => x.telepon.Equals(tbTelepon.Text));
                if (curCustomer == null)
                {
                    tbNamaPelanggan.Clear();
                    tbNamaPelanggan.ReadOnly = false;
                    return;
                }
                customer = curCustomer;
                tbNamaPelanggan.Text = customer.nama;
                tbNamaPelanggan.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == -1)
            {
                return;
            }
            barang = menuList[cb.SelectedIndex];
            tbHargaSatuan.Text = $"Rp.{barang.harga_satuan}";
            numQty.Maximum = barang.jumlah;
            tbTotalHarga.Text = $"Rp.{numQty.Value * barang.harga_satuan}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset input?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HelperClass.ClearValue(panelInput);
            }
            if (MessageBox.Show("Kosongkan keranjang?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetTransaksi();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!HelperClass.ValidateValue(panelInput) || barang.id <= 0)
            {
                MessageBox.Show("Isi semua data penting");
                return;
            }
            if (customer.id <= 0)
            {
                if (MessageBox.Show("Pelanggan tidak terdaftar, tambah baru?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (String.IsNullOrEmpty(tbNamaPelanggan.Text))
                {
                    MessageBox.Show("Isi nama pelanggan untuk tambah baru");
                    return;
                }
                try
                {
                    LKSMart2024Entities entities = new LKSMart2024Entities();
                    entities.tbl_pelanggan.Add(new tbl_pelanggan
                    {
                        nama = tbNamaPelanggan.Text,
                        telepon = tbTelepon.Text,
                    });
                    entities.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            if (MessageBox.Show("Tambah ke keranjang?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                LKSMart2024Entities entities = new LKSMart2024Entities();
                Keranjang itemAlreadyExist = keranjang.FirstOrDefault(x => x.barangId.Equals(barang.id));
                if (String.IsNullOrEmpty(transaksiId) && barang.id > 0)
                {
                    int trNum = entities.tbl_transaksi.Count();
                    transaksiId = $"TR{trNum + 1}";
                }
                if (itemAlreadyExist != null)
                {
                    itemAlreadyExist.qty += (int)numQty.Value;
                }
                else
                {
                    keranjang.Add(new Keranjang
                    {
                        userId = HelperClass.userSession.id,
                        barangId = barang.id,
                        kodeTransaksi = transaksiId,
                        kodeBarang = barang.kode,
                        namaBarang = barang.nama,
                        harga = (int)barang.harga_satuan,
                        qty = (int)numQty.Value,
                    });
                }
                dgvKeranjang.Rows.Clear();
                foreach (var item in keranjang)
                {
                    dgvKeranjang.Rows.Add(new object[]
                    {
                        item.kodeTransaksi,
                        item.kodeBarang,
                        item.namaBarang,
                        item.harga,
                        item.qty,
                        item.subtotal,
                    });
                }
                if (keranjang.Count <= 0)
                {
                    btnSimpan.Enabled = false;
                }
                else
                {
                    btnSimpan.Enabled = true;
                }
                lblTotalHarga.Text = $"Rp.{keranjang.Sum(x => x.subtotal)}";
                HelperClass.ClearValue(panelInput1);
                HelperClass.ClearValue(panelInput2);
                MessageBox.Show("Item berhasil ditambah ke keranjang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void numQty_ValueChanged_1(object sender, EventArgs e)
        {
            if (barang.id <= 0)
            {
                return;
            }
            else
            {
                tbTotalHarga.Text = $"Rp.{numQty.Value * barang.harga_satuan}";
            }
        }
    }
}

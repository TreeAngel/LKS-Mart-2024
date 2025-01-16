using LKS_Mart_2024.Helper;
using LKS_Mart_2024.Util;
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
                    transaksiId = Guid.NewGuid().ToString();
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
            HelperClass.ClearValue(panelInput);
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == -1)
            {
                return;
            }
            barang = menuList[cb.SelectedIndex];
            tbHargaSatuan.Text = barang.harga_satuan.ToString();
            numQty.Maximum = barang.jumlah;
            tbCash2Pay.Text = $"{numQty.Value * barang.harga_satuan}";
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            if (barang.id <= 0)
            {
                return;
            }
            else
            {
                tbTotalHarga.Text = $"{numQty.Value * barang.harga_satuan}";
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
            if (Convert.ToInt32(tbCash2Pay.Text) < keranjang.Sum(x => x.subtotal))
            {
                MessageBox.Show("Uang pembayaran kurang!");
                return;
            }
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
                        barang_id = item.barangId,
                    });
                }
                entities.SaveChanges();
                if (MessageBox.Show("Reset transaksi?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvKeranjang.Rows.Clear();
                    HelperClass.ClearValue(this);
                    lblKembalian.Text = "Rp.000.000";
                    lblTotalHarga.Text = "Rp.000.000";
                }
                MessageBox.Show("Transaksi berhasil disimpan");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UCGudang : UserControl
    {
        private tbl_barang selectedBarang;

        public UCGudang()
        {
            InitializeComponent();
        }

        private void UCGudang_Load(object sender, EventArgs e)
        {
            HelperClass.ClearValue(this);
            GetData(null);
            tbHarga.KeyPress += HelperClass.TextBoxNumberOnly;
        }

        private void GetData(string search)
        {
            LKSMart2024Entities entities = new LKSMart2024Entities();
            var data = entities.tbl_barang.ToList();
            if (!String.IsNullOrEmpty(search))
            {
                data = data.Where(x => x.nama.Equals(search)).ToList();
            }
            if (data.Count <= 0)
            {
                MessageBox.Show("Data kosong");
                return;
            }
            dgvBarang.Rows.Clear();
            foreach (var item in data)
            {
                dgvBarang.Rows.Add(new object[]
                {
                    item.id,
                    $"BRG{item.id}",
                    item.kode,
                    item.nama,
                    item.expired_date.ToShortTimeString(),
                    item.jumlah,
                    item.satuan,
                    $"Rp.{item.harga_satuan}",
                });
            }
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            int barangId = Convert.ToInt32(dgvBarang.Rows[rowIndex].Cells[0].Value.ToString());
            if (barangId <= 0)
            {
                MessageBox.Show("Barang tidak ada");
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            selectedBarang = entities.tbl_barang.Find(barangId);
            if (selectedBarang != null)
            {
                tbKode.Text = selectedBarang.kode;
                numJumlahBarang.Value = Convert.ToInt32(selectedBarang.jumlah);
                tbNama.Text = selectedBarang.nama;
                tbSatuan.Text = selectedBarang.satuan;
                dtpExpired.Value = Convert.ToDateTime(selectedBarang.expired_date);
                tbHarga.Text = selectedBarang.harga_satuan.ToString();
            }
            else
            {
                MessageBox.Show("Barang tidak ada");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearch.Text))
            {
                GetData(tbSearch.Text);
            }
            else
            {
                GetData(null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!HelperClass.ValidateValue(panelInput))
            {
                MessageBox.Show("Isi semua data");
                return;
            }
            if (MessageBox.Show("Tambah data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            try
            {
                tbl_barang newBarang = new tbl_barang
                {
                    kode = tbKode.Text,
                    nama = tbNama.Text,
                    expired_date = Convert.ToDateTime(dtpExpired.Value.ToShortDateString()),
                    jumlah = Convert.ToInt32(numJumlahBarang.Value),
                    satuan = tbSatuan.Text,
                    harga_satuan = Convert.ToInt32(tbHarga.Text),
                };
                entities.tbl_barang.Add(newBarang);
                entities.SaveChanges();
                GetData(null);
                HelperClass.ClearValue(panelInput);
                selectedBarang = new tbl_barang();
                MessageBox.Show("Data berhasil ditambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedBarang is null)
            {
                MessageBox.Show("Pilih barang");
                return;
            }
            if (!HelperClass.ValidateValue(panelInput))
            {
                MessageBox.Show("Isi semua data");
                return;
            }
            if (MessageBox.Show("Ubah data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            try
            {
                tbl_barang editedBarang = entities.tbl_barang.Find(selectedBarang.id);
                if (editedBarang is null)
                {
                    MessageBox.Show("Barang not found");
                    return;
                }
                editedBarang.kode = tbKode.Text;
                editedBarang.jumlah = Convert.ToInt32(numJumlahBarang.Value);
                editedBarang.nama = tbNama.Text;
                editedBarang.satuan = tbSatuan.Text;
                editedBarang.expired_date = Convert.ToDateTime(dtpExpired.Value.ToShortDateString());
                editedBarang.harga_satuan = Convert.ToInt32(tbHarga.Text);
                entities.SaveChanges();
                GetData(null);
                HelperClass.ClearValue(panelInput);
                selectedBarang = new tbl_barang();
                MessageBox.Show("Data berhasil diubah");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBarang is null)
            {
                MessageBox.Show("Pilih barang");
                return;
            }
            if (MessageBox.Show("Hapus data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            try
            {
                tbl_barang deletedBarang = entities.tbl_barang.Find(selectedBarang.id);
                if (deletedBarang is null)
                {
                    MessageBox.Show("Barang not found");
                    return;
                }
                entities.tbl_barang.Remove(deletedBarang);
                entities.SaveChanges();
                GetData(null);
                HelperClass.ClearValue(panelInput);
                selectedBarang = new tbl_barang();
                MessageBox.Show("Data berhasil dihapus");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}

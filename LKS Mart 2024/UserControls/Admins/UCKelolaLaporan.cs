using LKS_Mart_2024.Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LKS_Mart_2024.UserControls.Admins
{
    public partial class UCKelolaLaporan : UserControl
    {
        public UCKelolaLaporan()
        {
            InitializeComponent();
        }

        private void UCKelolaLaporan_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpUntil.Value = DateTime.Now;
            GetTransaction();
        }

        private void GetTransaction()
        {
            DateTime from = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
            string untl = $"{dtpUntil.Value.ToShortDateString()} 23:59:59";
            DateTime until = Convert.ToDateTime(untl);
            if (String.IsNullOrEmpty(from.ToString()) || String.IsNullOrEmpty(until.ToString()))
            {
                MessageBox.Show("Pilih rentang waktu laporan");
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            var data = entities.tbl_transaksi.Where(x => x.tanggal >= from && x.tanggal <= until).ToList();
            dgvLaporanTransaksi.Rows.Clear();
            foreach (var item in data)
            {
                dgvLaporanTransaksi.Rows.Add(new object[]
                {
                    item.id,
                    item.no,
                    item.tanggal,
                    item.total_bayar,
                    item.nama_kasir,
                    item.tbl_pelanggan.nama,
                });
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            GetTransaction();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime from = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
            string untl = $"{dtpUntil.Value.ToShortDateString()} 23:59:59";
            DateTime until = Convert.ToDateTime(untl);
            if (String.IsNullOrEmpty(from.ToString()) || String.IsNullOrEmpty(until.ToString()))
            {
                MessageBox.Show("Pilih rentang waktu laporan");
                return;
            }
            LKSMart2024Entities entities = new LKSMart2024Entities();
            var data = entities.tbl_transaksi.Where(x => x.tanggal >= from && x.tanggal <= until).GroupBy(x => x.tanggal).Select(t => new
            {
                t.Key,
                Omset = t.Sum(x => x.total_bayar),
            }).ToList();
            var chartOmset = chartLaporan.Series["Omset"];
            chartOmset.Points.Clear();
            foreach (var item in data)
            {
                chartOmset.Points.AddXY(item.Key.ToShortDateString(), item.Omset);

            }
        }
    }
}

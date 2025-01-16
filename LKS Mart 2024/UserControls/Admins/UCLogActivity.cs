using LKS_Mart_2024.Helper;
using LKS_Mart_2024.Util; 
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LKS_Mart_2024.UserControls.Admins
{
    public partial class UCLogActivity : UserControl
    {
        public UCLogActivity()
        {
            InitializeComponent();
        }

        private void UCLogActivity_Load(object sender, EventArgs e)
        {
            ResetDate();
        }

        private void ResetDate() { dtpFrom.Value = DateTime.Now; dtpUntil.Value = DateTime.Now; }

        private void btnFilter_Click(object sender, EventArgs e) => ShowLog();

        private void ShowLog()
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
            var data = entities.tbl_log.Where(x => x.waktu >= from && x.waktu <= until).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("Tidak ada data untuk rentang waktu yang dipilih");
                return;
            }
            int no = 1;
            dgvLogActivity.Rows.Clear();
            foreach (var item in data)
            {
                dgvLogActivity.Rows.Add(new object[] {
                    no,
                    item.tbl_user.username,
                    item.waktu,
                    item.aktivitas,
                });
                no++;
            }
        }
    }
}

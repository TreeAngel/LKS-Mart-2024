using LKS_Mart_2024.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Mart_2024.WinForms
{
    public partial class FormReport : Form
    {
        private readonly List<Keranjang> keranjang;

        public FormReport(List<Keranjang> keranjang)
        {
            InitializeComponent();
            this.keranjang = keranjang;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ReportDataSource data = new ReportDataSource
            {
                Name = "Transaksi",
                Value = keranjang,
            };
            rvKeranjang.LocalReport.DataSources.Add(data);
            rvKeranjang.RefreshReport();
        }
    }
}

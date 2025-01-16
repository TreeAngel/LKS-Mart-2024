using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Mart_2024.Util
{
    public class Keranjang
    {
        public int userId { get; set; }
        public int barangId { get; set; }
        public string kodeTransaksi { get; set; }
        public string kodeBarang { get; set; }
        public string namaBarang { get; set; }
        public int harga { get; set; }
        public int qty { get; set; }
        public int subtotal { get { return harga * qty; } }
    }
}

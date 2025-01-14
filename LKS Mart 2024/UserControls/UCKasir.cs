using LKS_Mart_2024.Helper;
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
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
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
    }
}

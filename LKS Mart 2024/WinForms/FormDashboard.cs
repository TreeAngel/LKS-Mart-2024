using LKS_Mart_2024.Helper;
using LKS_Mart_2024.UserControls;
using LKS_Mart_2024.UserControls.Admins;
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
    public partial class FormDashboard : Form
    {
        readonly UCKelolaLaporan kelolaLaporan = new UCKelolaLaporan();
        readonly UCKelolaUser kelolaUser = new UCKelolaUser();
        readonly UCLogActivity logActivity = new UCLogActivity();
        readonly UCGudang gudang = new UCGudang();
        readonly UCKasir kasir = new UCKasir();

        tbl_user session = HelperClass.userSession;
        int selectedBtn = 1;

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (session.tipe_user.ToLower().Contains("admin"))
            {
                UserAdmin();
                timer.Start();
            }
            if (session.tipe_user.ToLower().Contains("gudang"))
            {
                UserGudang();
                timer.Start();
            }
            if (session.tipe_user.ToLower().Contains("kasir"))
            {
                UserKasir();
            }
            BtnActiveColor();
        }

        private void UserAdmin()
        {
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(logActivity);
            panelAdminBtns.Visible = true;
            lblNonAdmin.Visible = false;
            lblDateTime.Visible = true;

            lblUCActive.Text = "LOG ACTIVITY";
            lblUserRole.Text = "Admin";
            pbUserRole.Image = Properties.Resources.administrator_1;
        }

        private void UserGudang()
        {
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(gudang);
            panelAdminBtns.Visible = false;
            lblNonAdmin.Visible = true;
            lblDateTime.Visible = true;

            lblNonAdmin.Text = "KELOLA\nBARANG";
            lblUCActive.Text = "KELOLA BARANG";
            lblUserRole.Text = "Gudang";
            pbUserRole.Image = Properties.Resources.Gudang;
        }

        private void UserKasir()
        {
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(kasir);
            panelAdminBtns.Visible = false;
            lblNonAdmin.Visible = true;
            lblDateTime.Visible = false;
            btnNamaKasir.Visible = true;

            btnNamaKasir.Text = session.nama;
            lblNonAdmin.Text = "KELOLA\nTRANSAKSI";
            lblUCActive.Text = "FORM TRANSAKSI";
            lblUserRole.Text = "Kasir";
            pbUserRole.Image = Properties.Resources.cashier_1;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDateTime.Text = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            selectedBtn = 3;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(kelolaUser);
            BtnActiveColor();
        }

        private void btnKelolaLaporan_Click(object sender, EventArgs e)
        {
            selectedBtn = 2;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(kelolaLaporan);
            BtnActiveColor();
        }

        private void btnLogActivity_Click(object sender, EventArgs e)
        {
            selectedBtn = 1;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(logActivity);
            BtnActiveColor();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            HelperClass.userSession = null;
            this.Close();
        }

        private void BtnActiveColor()
        {
            switch (selectedBtn)
            {
                case 1:
                    btnKelolaUser.BackColor = Color.SteelBlue;
                    btnKelolaLaporan.BackColor = Color.SteelBlue;
                    btnLogActivity.BackColor = Color.SkyBlue;
                    break;
                case 2:
                    btnKelolaUser.BackColor = Color.SteelBlue;
                    btnKelolaLaporan.BackColor = Color.SkyBlue;
                    btnLogActivity.BackColor = Color.SteelBlue;
                    break;
                case 3:
                    btnKelolaUser.BackColor = Color.SkyBlue;
                    btnKelolaLaporan.BackColor = Color.SteelBlue;
                    btnLogActivity.BackColor = Color.SteelBlue;
                    break;
                default:
                    break;
            }
        }
    }
}

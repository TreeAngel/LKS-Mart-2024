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

namespace LKS_Mart_2024
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //HelperClass.ClearValue(panelInput);
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HelperClass.ClearValue(panelInput);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.ToString();
            string password = tbPassword.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Isi username dan password");
                return;
            }
            try
            {

                LKSMart2024Entities entities = new LKSMart2024Entities();
                tbl_user user = entities.tbl_user.FirstOrDefault(x => x.username.Equals(username) && x.password.Equals(password));
                if (user == null)
                {
                    MessageBox.Show("Username atau password salah");
                    return;
                }
                HelperClass.userSession = user;
                new FormDashboard().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}

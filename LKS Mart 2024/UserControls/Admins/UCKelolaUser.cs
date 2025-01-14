using LKS_Mart_2024.Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LKS_Mart_2024.UserControls.Admins
{
    public partial class UCKelolaUser : UserControl
    {
        private tbl_user selectedUser;

        public UCKelolaUser()
        {
            InitializeComponent();
        }

        private void UCKelolaUser_Load(object sender, EventArgs e)
        {
            HelperClass.ClearValue(this);
            GetUsers(null);
            tbPhone.KeyPress += HelperClass.TextBoxNumberOnly;
        }

        private void GetUsers(String find)
        {
            //LKSMart2024Entities entities = new LKSMart2024Entities();
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
            var data = entities.tbl_user.Where(x => !x.tipe_user.ToLower().Contains("admin")).ToList();
            if (find != null)
            {
                data = data.Where(x => x.nama.ToLower().Contains(find)).ToList();
            }
            if (data.Count <= 0)
            {
                MessageBox.Show("Data kosong");
                return;
            }
            int no = 1;
            dgvUser.Rows.Clear();
            foreach (var item in data)
            {
                dgvUser.Rows.Add(new object[]
                {
                    item.id,
                    no,
                    item.tipe_user,
                    item.username,
                    item.alamat,
                    item.telepon,
                });
                no++;
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            int userId = Convert.ToInt32(dgvUser.Rows[rowIndex].Cells[0].Value.ToString());
            if (userId <= 0)
            {
                MessageBox.Show("User not found");
                return;
            }
            //LKSMart2024Entities entities = new LKSMart2024Entities();
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
            selectedUser = entities.tbl_user.Find(userId);
            if (selectedUser != null)
            {
                cbRole.SelectedItem = selectedUser.tipe_user;
                tbUsername.Text = selectedUser.username;
                tbName.Text = selectedUser.nama;
                tbPassword.Text = selectedUser.password;
                tbPhone.Text = selectedUser.telepon;
                tbAddress.Text = selectedUser.alamat;
            } else
            {
                MessageBox.Show("User tidak ada");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearch.Text))
            {
                GetUsers(tbSearch.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!HelperClass.ValidateValue(panelInput))
            {
                MessageBox.Show("Isi data yang diperlukan");
                return;
            }
            if (MessageBox.Show("Tambah data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //LKSMart2024Entities entities = new LKSMart2024Entities();
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
            tbl_user newUser = new tbl_user
            {
                tipe_user = cbRole.SelectedItem.ToString(),
                nama = tbName.Text.ToString(),
                alamat = tbAddress.Text.ToString(),
                username = tbUsername.Text.ToString(),
                telepon = tbPhone.Text.ToString().Trim(),
                password = tbPassword.Text.ToString().Trim(),
            };
            entities.tbl_user.Add(newUser);
            entities.SaveChanges();
            GetUsers(null);
            HelperClass.ClearValue(panelInput);
            selectedUser = new tbl_user();
            MessageBox.Show("Data berhasil ditambah");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedUser is null)
            {
                MessageBox.Show("Pilih user");
                return;
            }
            if (!HelperClass.ValidateValue(panelInput))
            {
                MessageBox.Show("Isi data yang diperlukan");
                return;
            }
            if (MessageBox.Show("Ubah data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //LKSMart2024Entities entities = new LKSMart2024Entities();
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
            tbl_user editedUser = entities.tbl_user.Find(selectedUser.id);
            if (editedUser is null)
            {
                MessageBox.Show("User not found");
                return;
            }
            editedUser.tipe_user = cbRole.SelectedItem.ToString();
            editedUser.username = tbUsername.Text.ToString();
            editedUser.nama = tbName.Text.ToString();
            editedUser.password = tbPassword.Text.ToString().Trim();
            editedUser.telepon = tbPhone.Text.ToString().Trim();
            editedUser.alamat = tbAddress.Text.ToString();
            entities.SaveChanges();
            GetUsers(null);
            HelperClass.ClearValue(panelInput);
            selectedUser = new tbl_user();
            MessageBox.Show("Data berhasil diubah");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser is null)
            {
                MessageBox.Show("Pilih user yang ada");
                return;
            }
            if (MessageBox.Show("Hapus data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //LKSMart2024Entities entities = new LKSMart2024Entities();
            LKSMart2024Entities2 entities = new LKSMart2024Entities2();
            tbl_user deletedUser = entities.tbl_user.Find(selectedUser.id);
            if (deletedUser is null)
            {
                MessageBox.Show("User not found");
                return;
            }
            entities.tbl_user.Remove(deletedUser);
            entities.SaveChanges();
            GetUsers(null);
            HelperClass.ClearValue(panelInput);
            selectedUser = new tbl_user();
            MessageBox.Show("Data berhasil dihapus");
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbPassword.Checked;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

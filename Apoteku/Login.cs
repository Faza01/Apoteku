using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteku
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                Main form1 = new Main();
                form1.Show();
                this.Hide();
                MessageBox.Show("Login Berhasil!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                username.Focus();
                username.Clear();
                password.Clear();
                MessageBox.Show("Login Gagal!, Perhatikan usernmae dan password anda", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

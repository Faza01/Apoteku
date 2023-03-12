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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard();

            // Change the color of the button
            btn_dashboard.ForeColor = Color.DeepSkyBlue;
            btn_manage.ForeColor = Color.Black;
            panel1.Visible = true;
            panel2.Visible = false;

            // Navigate to the UserControl by setting its Dock property to Fill on the container panel
            dashboard.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(dashboard);
        }
        private void btn_manage_Click(object sender, EventArgs e)
        {
            var manage = new Manage();

            // Change the color of the button
            btn_manage.ForeColor = Color.DeepSkyBlue;
            btn_dashboard.ForeColor = Color.Black;
            panel2.Visible = true;
            panel1.Visible = false;

            // Navigate to the UserControl by setting its Dock property to Fill on the container panel
            manage.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(manage);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btn_dashboard_Click(sender, e);
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

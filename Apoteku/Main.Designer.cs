namespace Apoteku
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel_sidebar = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btn_manage = new Button();
            btn_dashboard = new Button();
            panel_main = new Panel();
            panel_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.White;
            panel_sidebar.Controls.Add(panel4);
            panel_sidebar.Controls.Add(panel3);
            panel_sidebar.Controls.Add(panel2);
            panel_sidebar.Controls.Add(panel1);
            panel_sidebar.Controls.Add(btn_manage);
            panel_sidebar.Controls.Add(btn_dashboard);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(175, 708);
            panel_sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 76);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 642);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 66);
            panel3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 56);
            button1.TabIndex = 6;
            button1.Text = "          Quit";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Location = new Point(0, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(12, 56);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 56);
            panel1.TabIndex = 2;
            // 
            // btn_manage
            // 
            btn_manage.BackColor = Color.Transparent;
            btn_manage.FlatAppearance.BorderSize = 0;
            btn_manage.FlatStyle = FlatStyle.Flat;
            btn_manage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_manage.Location = new Point(0, 176);
            btn_manage.Name = "btn_manage";
            btn_manage.Size = new Size(175, 56);
            btn_manage.TabIndex = 1;
            btn_manage.Text = "Manage";
            btn_manage.UseVisualStyleBackColor = false;
            btn_manage.Click += btn_manage_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.Transparent;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.Location = new Point(0, 95);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(175, 56);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(175, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(960, 708);
            panel_main.TabIndex = 2;
            panel_main.Paint += panel_main_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 708);
            Controls.Add(panel_main);
            Controls.Add(panel_sidebar);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel_sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Button btn_dashboard;
        private Panel panel_main;
        private Button btn_manage;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Button button1;
    }
}
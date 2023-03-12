namespace Apoteku
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new TextBox();
            password = new TextBox();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(490, 169);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(224, 23);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(490, 234);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(224, 23);
            password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DeepSkyBlue;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(490, 321);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(224, 39);
            btn_login.TabIndex = 2;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(485, 148);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(485, 213);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(757, 437);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(password);
            Controls.Add(username);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "text";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button btn_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}
namespace Apoteku
{
    partial class Manage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            label1 = new Label();
            id_barang = new TextBox();
            nama = new TextBox();
            label2 = new Label();
            deskripsi = new TextBox();
            label3 = new Label();
            gambar = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            label7 = new Label();
            stock = new TextBox();
            label4 = new Label();
            harga = new TextBox();
            label5 = new Label();
            kategori = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            delete = new Button();
            search = new TextBox();
            btn_tambah = new Button();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)gambar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 203);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // id_barang
            // 
            id_barang.Location = new Point(51, 203);
            id_barang.Name = "id_barang";
            id_barang.Size = new Size(32, 23);
            id_barang.TabIndex = 1;
            // 
            // nama
            // 
            nama.Location = new Point(25, 37);
            nama.Name = "nama";
            nama.Size = new Size(198, 23);
            nama.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 2;
            label2.Text = "Nama Obat";
            // 
            // deskripsi
            // 
            deskripsi.Location = new Point(25, 96);
            deskripsi.Multiline = true;
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(198, 81);
            deskripsi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 74);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 4;
            label3.Text = "Deskripsi";
            // 
            // gambar
            // 
            gambar.BackColor = Color.White;
            gambar.BorderStyle = BorderStyle.FixedSingle;
            gambar.Location = new Point(499, 37);
            gambar.Name = "gambar";
            gambar.Size = new Size(136, 140);
            gambar.SizeMode = PictureBoxSizeMode.StretchImage;
            gambar.TabIndex = 12;
            gambar.TabStop = false;
            gambar.Click += gambar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(21, 231);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(892, 452);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Obat";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Deskripsi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kategori";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Stock";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Gambar";
            Column7.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(499, 15);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 14;
            label7.Text = "Gambar";
            // 
            // stock
            // 
            stock.Location = new Point(260, 154);
            stock.Name = "stock";
            stock.Size = new Size(198, 23);
            stock.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(255, 132);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 19;
            label4.Text = "Stock";
            // 
            // harga
            // 
            harga.Location = new Point(260, 96);
            harga.Name = "harga";
            harga.Size = new Size(198, 23);
            harga.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(255, 74);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 17;
            label5.Text = "Harga";
            // 
            // kategori
            // 
            kategori.Location = new Point(260, 37);
            kategori.Name = "kategori";
            kategori.Size = new Size(198, 23);
            kategori.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(255, 15);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 15;
            label6.Text = "Kategori";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 203);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(771, 46);
            button3.Name = "button3";
            button3.Size = new Size(99, 47);
            button3.TabIndex = 25;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.OrangeRed;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(771, 109);
            delete.Name = "delete";
            delete.Size = new Size(99, 47);
            delete.TabIndex = 26;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(128, 203);
            search.Name = "search";
            search.Size = new Size(343, 23);
            search.TabIndex = 27;
            search.TextChanged += search_TextChanged;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.DeepSkyBlue;
            btn_tambah.FlatStyle = FlatStyle.Flat;
            btn_tambah.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.Location = new Point(655, 46);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(99, 47);
            btn_tambah.TabIndex = 28;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 128, 0);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(655, 109);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(99, 47);
            btn_update.TabIndex = 29;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_update);
            Controls.Add(btn_tambah);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(stock);
            Controls.Add(label4);
            Controls.Add(harga);
            Controls.Add(label5);
            Controls.Add(kategori);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(gambar);
            Controls.Add(deskripsi);
            Controls.Add(label3);
            Controls.Add(nama);
            Controls.Add(label2);
            Controls.Add(id_barang);
            Controls.Add(label1);
            Name = "Manage";
            Size = new Size(934, 700);
            Load += Manage_Load;
            ((System.ComponentModel.ISupportInitialize)gambar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id_barang;
        private TextBox nama;
        private Label label2;
        private TextBox deskripsi;
        private Label label3;
        private PictureBox gambar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
        private Label label7;
        private TextBox stock;
        private Label label4;
        private TextBox harga;
        private Label label5;
        private TextBox kategori;
        private Label label6;
        private PictureBox pictureBox2;
        private Button button3;
        private Button delete;
        private TextBox search;
        private Button btn_tambah;
        private Button btn_update;
    }
}

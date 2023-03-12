using MySql.Data.MySqlClient;
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
    public partial class Manage : UserControl
    {
        // koneksi ke database
        MySqlConnection koneksi = Koneksi.getConnection();
        // membuat objek dari class DataTable
        DataTable dataTable = new DataTable();

        //Tampilan MySql
        public DataTable getDataTable()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM apoteku", koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        // method mengambil data tabel dan memasukannya ke column yang ada di gridview
        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 170;
            dataGridView1.DataSource = getDataTable();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "nama";
            Column3.DataPropertyName = "deskripsi";
            Column4.DataPropertyName = "kategori";
            Column5.DataPropertyName = "harga";
            Column6.DataPropertyName = "stock";
            Column7.DataPropertyName = "gambar";

        }

        // method menghapus isi field
        public void clear()
        {
            id_barang.Clear();
            nama.Clear();
            kategori.Clear();
            deskripsi.Clear();
            harga.Clear();
            stock.Clear();
            gambar.Image = null;
        }

        // method mengurutkan id
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update apoteku SET id = @id := (@id+1); " + "ALTER TABLE apoteku AUTO_INCREMENT = 1;");
            script.Execute();
        }

        // method mencari data
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM apoteku WHERE CONCAT (id, nama, deskripsi, kategori, harga, stock) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Manage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            id_barang.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            deskripsi.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            kategori.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            harga.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            stock.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            // mengambil data gambar BLOB untuk baris yang diklik dan buat objek Gambar
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;

            //MemoryStream digunakan untuk membaca dan menulis data ke dalam memori yang diwakili oleh objek byte[].
            MemoryStream ms = new MemoryStream(img);
            gambar.Image = Image.FromStream(ms);
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // mengecek apakah ada field yang kosong
            if ((nama.Text == string.Empty || deskripsi.Text == string.Empty || kategori.Text == string.Empty || harga.Text == string.Empty || stock.Text == string.Empty || gambar.Image == null))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlCommand cmd;
                // error handling jika data tidak masuk
                try
                {
                    // Convert image ke byte array
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    resetIncrement();
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "INSERT INTO apoteku(nama, deskripsi, kategori, harga, stock, gambar) VALUE(@nama, @deskripsi, @kategori,  @harga, @stock, @gambar)";
                    cmd.Parameters.AddWithValue("@nama", nama.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                    cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                    cmd.Parameters.AddWithValue("@harga", harga.Text);
                    cmd.Parameters.AddWithValue("@stock", stock.Text);
                    cmd.Parameters.AddWithValue("@gambar", imageData);
                    cmd.ExecuteNonQuery();

                    koneksi.Close();

                    MessageBox.Show("Data berhasil disimpan ke database!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldataTable();
                    clear();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memasukkan data: " + ex.Message, "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // mengecek apakah ada field yang kosong
            if ((nama.Text == string.Empty || deskripsi.Text == string.Empty || kategori.Text == string.Empty || harga.Text == string.Empty || stock.Text == string.Empty))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // membuat objek objek dari class MySqlCommand
                MySqlCommand cmd;
                // error handling jika data tidak masuk
                try
                {
                    // Convert image to byte array
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "UPDATE apoteku SET nama = @nama, kategori = @kategori, deskripsi = @deskripsi, harga = @harga, stock = @stock ,gambar = @gambar WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id_barang.Text);
                    cmd.Parameters.AddWithValue("@nama", nama.Text);
                    cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                    cmd.Parameters.AddWithValue("@harga", harga.Text);
                    cmd.Parameters.AddWithValue("@stock", stock.Text);
                    cmd.Parameters.AddWithValue("@gambar", imageData);
                    cmd.ExecuteNonQuery();

                    clear();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil diupdate!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldataTable();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memasukkan data: " + ex.Message, "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "DELETE from apoteku WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id_barang.Text);
                cmd.ExecuteNonQuery();

                resetIncrement();
                clear();
                koneksi.Close();
                MessageBox.Show("Data berhasil dihapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data Gagal Dihapus = " + ex.Message, "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                var fileSize = new FileInfo(openfd.FileName).Length; // get the size of the selected file
                if (fileSize > 1000000) // check if the size is more than 1000KB
                {
                    MessageBox.Show("Ukuran file gambar terlalu besar! (max = 1000kb)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gambar.Image = new Bitmap(openfd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData(search.Text);
        }
    }
}

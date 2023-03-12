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
    public partial class Dashboard : UserControl
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

        // method mencari data
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM apoteku WHERE CONCAT (id, nama, deskripsi, kategori, harga, stock) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData(search.Text);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            filldataTable();
        }
    }
}

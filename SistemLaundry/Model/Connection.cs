using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace SistemLaundry.Model
{
    public  class Connection
    {
        public MySqlCommand cmd;//untuk menjalankan perintah sql
        public DataSet ds; //wadah untuk menyimpan data
        public MySqlDataAdapter da; //penghubung antara databse dengan data table nya

        public MySqlConnection GetConn()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(
                    "server=localhost;user=root;password=;database=sistem_laundry"
                );
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi database gagal:\n" + ex.Message);
                return null;  
            }
        }

    }
}

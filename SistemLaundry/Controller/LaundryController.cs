using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Drawing;
using SistemLaundry.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// WAJIB

namespace SistemLaundry.Controller
{
    public class LaundryController : Model.Connection      // LaundryController MEWARISI class Connection
    {
        public static string KasirAktif;
        public static string RoleAktif;
        public enum ModeDetailTransaksi
        {
            Admin,
            Kasir
        }
        // ========================================================================================================//
        public bool LoginAdmin(string username, string password)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = @"SELECT * FROM manajemen_admin_kasir
                         WHERE username=@u 
                         AND PASSWORD=@p
                         AND ROLE='admin'
                         AND STATUS='aktif'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public int LoginKasir(string username, string password)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = @"SELECT STATUS FROM manajemen_admin_kasir
                         WHERE username=@u 
                         AND PASSWORD=@p
                         AND ROLE='kasir'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                object result = cmd.ExecuteScalar();

                if (result == null) return 0;           // username/password salah
                if (result.ToString() == "nonaktif") return 2; // belum aktif
                return 1;                               // aktif & boleh login
            }
        }
        public bool DaftarKasir(string username, string password)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = @"INSERT INTO manajemen_admin_kasir
                        (username, PASSWORD, ROLE, STATUS)
                        VALUES (@u, @p, 'kasir', 'nonaktif')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // =====================================================================
        // ================= CONTROLLER FORM DATA PELANGGAN =====================
        // =====================================================================

        public DataTable tampilkanPelanggan(MySqlCommand cmd)
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT * FROM pelanggan ORDER BY id_pelanggan ASC";
                cmd = new MySqlCommand(query, GetConn());
                da = new MySqlDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data pelanggan : " + ex.Message);
            }

            return data;
        }


        public bool TambahPelanggan(string id, string nama, string notelp, string alamat)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = @"INSERT INTO pelanggan 
                            (id_pelanggan, nama_pelanggan, no_hp, alamat)
                            VALUES (@id, @nama, @notelp, @alamat)";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@notelp", notelp);
                cmd.Parameters.AddWithValue("@alamat", alamat);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data pelanggan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool EditPelanggan(string id, string nama, string notelp, string alamat)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = @"UPDATE pelanggan SET 
                            nama_pelanggan=@nama,
                            no_hp=@notelp,
                            alamat=@alamat
                            WHERE id_pelanggan=@id";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@notelp", notelp);
                cmd.Parameters.AddWithValue("@alamat", alamat);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit data pelanggan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool HapusPelanggan(string id)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = "DELETE FROM pelanggan WHERE id_pelanggan=@id";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data pelanggan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Search(string search)
        {
            DataTable data = new DataTable();
            string query = @"SELECT * FROM pelanggan 
                             WHERE CONCAT(id_pelanggan, nama_pelanggan, no_hp, alamat) 
                             LIKE @search";

            try
            {
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                da = new MySqlDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Gagal: " + ex.Message);
            }

            return data;
        }

        // ===== WRAPPER =====
        public DataTable GetDataPelanggan()
        {
            return tampilkanPelanggan(cmd);
        }

        public bool CekPelangganPunyaTransaksi(string idPelanggan)
        {
            try
            {
                MySqlConnection conn = GetConn();
                if (conn == null) return true;

                string query = "SELECT COUNT(*) FROM transaksi WHERE id_pelanggan=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idPelanggan);

                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return jumlah > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cek transaksi:\n" + ex.Message);
                return true;
            }
        }

        // =============================== CONTROLLER FORM DATA LAYANAN =============================== //
        public DataTable TampilkanLayanan()
        {
            DataTable data = new DataTable();
            string query = "SELECT id_layanan, nama_layanan, jenis_layanan, harga, estimasi_selesai, gambar FROM layanan";

            try
            {
                cmd = new MySqlCommand(query, GetConn());
                da = new MySqlDataAdapter(cmd);
                da.Fill(data);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data layanan:\n" + ex.Message);
            }

            return data;
        }


        public bool TambahLayanan(string id, string nama, string jenis, int harga, int estimasi, byte[] gambar)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = @"INSERT INTO layanan 
                     (id_layanan, nama_layanan, jenis_layanan, harga, estimasi_selesai, gambar)
                     VALUES (@id, @nama, @jenis, @harga, @estimasi, @gambar)";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@estimasi", estimasi);
                cmd.Parameters.Add("@gambar", MySqlDbType.LongBlob).Value = gambar;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah layanan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool EditLayanan(string id, string nama, string jenis, int harga, int estimasi, byte[] gambar)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = @"UPDATE layanan SET 
                     nama_layanan=@nama,
                     jenis_layanan=@jenis,
                     harga=@harga,
                     estimasi_selesai=@estimasi,
                     gambar=@gambar
                     WHERE id_layanan=@id";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@estimasi", estimasi);
                cmd.Parameters.Add("@gambar", MySqlDbType.LongBlob).Value = gambar;

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit layanan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool HapusLayanan(string id)
        {
            MySqlConnection conn = GetConn();
            if (conn == null) return false;

            string query = "DELETE FROM layanan WHERE id_layanan=@id";

            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus layanan:\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchLayanan(string search)
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM layanan WHERE CONCAT(id_layanan, nama_layanan, jenis_layanan, harga, estimasi_selesai) LIKE @search";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(query, GetConn());
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                da = new MySqlDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Gagal: " + ex.Message);
            }
            return data;
        }

        public bool CekLayananDipakai(string idLayanan)
        {
            try
            {
                MySqlConnection conn = GetConn();
                if (conn == null) return true;

                string query = "SELECT COUNT(*) FROM detail_transaksi WHERE id_layanan=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idLayanan);

                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return jumlah > 0; // TRUE = SUDAH DIPAKAI
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cek layanan:\n" + ex.Message);
                return true;
            }
        }
        // ============================ END CONTROLLER FORM DATA LAYANAN ============================= //

        // ============================ CONTROLLER FORM TRANSAKSI ============================= //
        public DataTable TampilkanTransaksi()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConn()) // GetConn() harus dipastikan membuka koneksi
                {
                    if (conn.State == ConnectionState.Closed) conn.Open(); // Tambahkan ini

                    string query = "SELECT * FROM transaksi";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database: " + ex.Message);
            }
            return dt;
        }

        public DataTable SearchTransaksi(string search)
        {
            DataTable data = new DataTable();
            string query = @"SELECT 
                        t.id_transaksi,
                        p.nama_pelanggan,
                        t.tanggal_masuk,
                        t.tanggal_selesai,
                        t.total,
                        t.status_laundry,
                        t.status_pembayaran
                     FROM transaksi t
                     JOIN pelanggan p 
                        ON t.id_pelanggan = p.id_pelanggan
                     WHERE CONCAT(
                        t.id_transaksi,
                        p.nama_pelanggan,
                        t.status_laundry,
                        t.status_pembayaran
                     ) LIKE @keyword";

            try
            {
                using (var conn = GetConn())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + search + "%");

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Gagal: " + ex.Message);
            }

            return data;
        }

        // ===================== END CONTROLLER FORM TRANSAKSI ==================================== //

        // ====================== CONTROLLER FROM TAMBAH TRANSAKSI ================================ //
        public DataTable GetPelanggan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id_pelanggan, nama_pelanggan FROM pelanggan";
            cmd = new MySqlCommand(query, GetConn());
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetJenisLayanan()
        {
            DataTable dt = new DataTable();
            string q = "SELECT DISTINCT jenis_layanan FROM layanan";
            cmd = new MySqlCommand(q, GetConn());
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetLayananByJenis(string jenis)
        {
            DataTable dt = new DataTable();
            string q = "SELECT id_layanan, nama_layanan, harga, estimasi_selesai FROM layanan WHERE jenis_layanan=@jenis";
            cmd = new MySqlCommand(q, GetConn());
            cmd.Parameters.AddWithValue("@jenis", jenis);
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public void SimpanTransaksi(
    string idTransaksi,
    string idPelanggan,
    DateTime masuk,
    DateTime selesai,
    int total,
    int bayar,
    int kembali,
    DataTable detail)
        {
            MySqlConnection conn = GetConn();
            if (conn.State == ConnectionState.Closed) conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                string q1 = @"INSERT INTO transaksi 
        (id_transaksi, id_pelanggan, tanggal_masuk, tanggal_selesai, total, status_laundry, status_pembayaran, uang_bayar, kembalian)
        VALUES (@id, @idpelanggan, @masuk, @selesai, @total, 'Proses', 'Lunas', @bayar, @kembali)";

                cmd = new MySqlCommand(q1, conn, trans);
                cmd.Parameters.AddWithValue("@id", idTransaksi);
                cmd.Parameters.AddWithValue("@idpelanggan", idPelanggan);
                cmd.Parameters.AddWithValue("@masuk", masuk);
                cmd.Parameters.AddWithValue("@selesai", selesai);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@bayar", bayar);
                cmd.Parameters.AddWithValue("@kembali", kembali);
                cmd.ExecuteNonQuery();

                // SIMPAN DETAIL TRANSAKSI
                foreach (DataRow r in detail.Rows)
                {
                    string idDetail = "DTL" + Guid.NewGuid().ToString("N").Substring(0, 5);

                    string q2 = @"INSERT INTO detail_transaksi
            (id_detail, id_transaksi, id_layanan, harga, jumlah, subtotal)
            VALUES (@iddetail, @id, @lay, @harga, @jumlah, @sub)";

                    cmd = new MySqlCommand(q2, conn, trans);
                    cmd.Parameters.AddWithValue("@iddetail", idDetail);
                    cmd.Parameters.AddWithValue("@id", idTransaksi);
                    cmd.Parameters.AddWithValue("@lay", r["id_layanan"]);
                    cmd.Parameters.AddWithValue("@harga", r["harga"]);
                    cmd.Parameters.AddWithValue("@jumlah", r["jumlah"]);
                    cmd.Parameters.AddWithValue("@sub", r["subtotal"]);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Transaksi berhasil disimpan");

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show("Gagal menyimpan transaksi:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        // ====================== END CONTROLLER FROM TAMBAH TRANSAKSI ================================ //

        // ====================== CONTROLLER FORM EDIT TRANSAKSI ================================ //
        public bool UpdateStatusLaundry(string idTransaksi, string statusBaru)
        {
            try
            {
                MySqlConnection conn = GetConn();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "UPDATE transaksi SET status_laundry=@status WHERE id_transaksi=@id";
                cmd = new MySqlConnector.MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", statusBaru);
                cmd.Parameters.AddWithValue("@id", idTransaksi);

                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update: " + ex.Message);
                return false;
            }
        }

        // ===================== END CONTROLLER FORM EDIT TRANSAKSI ================================ //

        // ==================== CONTROLLER FORM DETAIL TRANSAKSI ============================= //
        public DataTable GetDetailItemTransaksi(string idTransaksi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    string query = @"SELECT 
                                l.nama_layanan,
                                d.harga,
                                d.jumlah,
                                d.subtotal
                             FROM detail_transaksi d
                             JOIN layanan l 
                                ON d.id_layanan = l.id_layanan
                             WHERE d.id_transaksi = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idTransaksi);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil detail transaksi: " + ex.Message);
            }
            return dt;
        }
        public DataTable GetDetailTransaksi(string idTransaksi, ModeDetailTransaksi mode)
        {
            DataTable dt = new DataTable();
            string query;

            if (mode == ModeDetailTransaksi.Admin)
            {
                query = @"SELECT t.id_transaksi, p.nama_pelanggan, 
                         t.total, t.uang_bayar, t.kembalian
                  FROM transaksi t
                  JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan
                  WHERE t.id_transaksi = @id";
            }
            else // Kasir
            {
                query = @"SELECT t.id_transaksi, p.nama_pelanggan, 
                         t.total
                  FROM transaksi t
                  JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan
                  WHERE t.id_transaksi = @id";
            }

            using (MySqlConnection conn = GetConn())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idTransaksi);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable AmbilDataTransaksiLengkap(string IdTransaksi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // Query JOIN dengan filter WHERE agar hanya mengambil 1 ID yang sedang dibuka
                    string query = @"SELECT t.*, p.nama_pelanggan 
                             FROM transaksi t 
                             JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan 
                             WHERE t.id_transaksi = @id";

                    using (MySqlCommand cmdLengkap = new MySqlCommand(query, conn))
                    {
                        cmdLengkap.Parameters.AddWithValue("@id", IdTransaksi);
                        using (MySqlDataAdapter daLengkap = new MySqlDataAdapter(cmdLengkap))
                        {
                            daLengkap.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database: " + ex.Message);
            }
            return dt;
        }

        // ================= CONTROLLER FORM DATA ADMIN ================= //

        public DataTable TampilkanAdmin()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    string query = @"SELECT id_admin, username, ROLE, STATUS 
                             FROM manajemen_admin_kasir
                             ORDER BY id_admin ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data admin:\n" + ex.Message);
            }
            return dt;
        }


        public bool AktifkanAdmin(int idAdmin)
        {
            try
            {
                MySqlConnection conn = GetConn();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = @"UPDATE manajemen_admin_kasir 
                         SET STATUS='aktif'
                         WHERE id_admin=@id";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idAdmin);

                int result = cmd.ExecuteNonQuery();
                conn.Close();

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengaktifkan admin:\n" + ex.Message);
                return false;
            }
        }

    }
}

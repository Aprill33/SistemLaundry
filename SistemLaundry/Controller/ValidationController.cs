using System;
using System.Windows.Forms;

namespace SistemLaundry.Controller
{
    internal class ValidationController
    {
        // =========================================================
        // VALIDASI USERNAME
        // =========================================================
        public bool ValidasiUsername(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Username tidak boleh kosong",
                    "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (user.Length != 6)
            {
                MessageBox.Show("Username harus tepat 6 karakter",
                    "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (user[0] == ' ' || user[user.Length - 1] == ' ')
            {
                MessageBox.Show("Username tidak boleh diawali atau diakhiri spasi",
                    "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in user)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    MessageBox.Show("Username hanya boleh huruf dan angka",
                        "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        // =========================================================
        // VALIDASI PASSWORD
        // =========================================================
        public bool ValidasiPassword(string pass)
        {
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Password tidak boleh kosong",
                    "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pass.Length != 6)
            {
                MessageBox.Show("Password harus 6 angka",
                    "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in pass)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Password hanya boleh berisi angka",
                        "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        // =========================================================
        // VALIDASI DATA PELANGGAN (TAMBAH & EDIT)
        // isEdit = false → Tambah (ID divalidasi)
        // isEdit = true  → Edit  (ID dilewati)
        // =========================================================
        public bool ValidasiPelanggan(string id, string nama, string notelp, string alamat, bool isEdit)
        {
            // =====================================================
            // VALIDASI ID (HANYA SAAT TAMBAH DATA)
            // =====================================================
            if (!isEdit)
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("ID pelanggan tidak boleh kosong");
                    return false;
                }

                if (id.Length > 4)
                {
                    MessageBox.Show("ID pelanggan maksimal 4 karakter");
                    return false;
                }

                foreach (char c in id)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        MessageBox.Show("ID pelanggan tidak boleh mengandung simbol");
                        return false;
                    }
                }
            }

            // =====================================================
            // VALIDASI NAMA
            // =====================================================
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama pelanggan tidak boleh kosong");
                return false;
            }

            if (nama.Length < 2 || nama.Length > 30)
            {
                MessageBox.Show("Nama pelanggan minimal 2 dan maksimal 30 huruf");
                return false;
            }

            foreach (char c in nama)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Nama pelanggan hanya boleh huruf");
                    return false;
                }
            }

            // =====================================================
            // VALIDASI NO HP (KOMPLEKS)
            // =====================================================
            if (string.IsNullOrWhiteSpace(notelp))
            {
                MessageBox.Show("No HP tidak boleh kosong");
                return false;
            }

            if (notelp[0] == ' ')
            {
                MessageBox.Show("No HP tidak boleh diawali spasi");
                return false;
            }

            if (notelp.Contains(" "))
            {
                MessageBox.Show("No HP tidak boleh mengandung spasi");
                return false;
            }

            if (!(notelp.StartsWith("08") || notelp.StartsWith("+62")))
            {
                MessageBox.Show("No HP harus diawali dengan 08 atau +62");
                return false;
            }

            if (notelp.StartsWith("+62"))
            {
                string sisa = notelp.Substring(1);
                foreach (char c in sisa)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("No HP hanya boleh angka setelah +62");
                        return false;
                    }
                }
            }
            else
            {
                foreach (char c in notelp)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("No HP hanya boleh angka");
                        return false;
                    }
                }
            }

            int panjangDigit = notelp.StartsWith("+62")
                ? notelp.Length - 1
                : notelp.Length;

            if (panjangDigit < 10 || panjangDigit > 13)
            {
                MessageBox.Show("No HP harus 10 - 13 digit");
                return false;
            }

            bool semuaSama = true;
            for (int i = 1; i < notelp.Length; i++)
            {
                if (notelp[i] != notelp[0])
                {
                    semuaSama = false;
                    break;
                }
            }

            if (semuaSama)
            {
                MessageBox.Show("No HP tidak valid");
                return false;
            }

            // =====================================================
            // VALIDASI ALAMAT
            // =====================================================
            if (string.IsNullOrWhiteSpace(alamat))
            {
                MessageBox.Show("Alamat tidak boleh kosong");
                return false;
            }

            if (alamat.Length < 5)
            {
                MessageBox.Show("Alamat terlalu pendek");
                return false;
            }

            return true;
        }

        // =========================================================
        // VALIDASI DATA LAYANAN
        // =========================================================
        public bool ValidasiLayanan(string id, string nama, string jenis, string harga, string estimasi)
        {
            if (string.IsNullOrWhiteSpace(id) || id.Length > 5)
            {
                MessageBox.Show("ID layanan wajib dan maksimal 5 karakter");
                return false;
            }

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama layanan tidak boleh kosong");
                return false;
            }

            if (string.IsNullOrWhiteSpace(jenis))
            {
                MessageBox.Show("Jenis layanan harus dipilih");
                return false;
            }

            if (!int.TryParse(harga, out _))
            {
                MessageBox.Show("Harga harus berupa angka");
                return false;
            }

            if (!int.TryParse(estimasi, out _))
            {
                MessageBox.Show("Estimasi harus berupa angka");
                return false;
            }

            return true;
        }

        // =========================================================
        // VALIDASI JUMLAH TRANSAKSI
        // =========================================================
        public bool ValidasiJumlahLayanan(string jumlahText, string jenisLayanan)
        {
            if (string.IsNullOrWhiteSpace(jumlahText))
            {
                MessageBox.Show("Jumlah tidak boleh kosong");
                return false;
            }

            if (!double.TryParse(jumlahText, out double jumlah))
            {
                MessageBox.Show("Jumlah harus berupa angka");
                return false;
            }

            if (jenisLayanan.Contains("Kilo") && jumlah < 3)
            {
                MessageBox.Show("Minimal layanan kiloan adalah 3 kg");
                return false;
            }

            if (jenisLayanan.Contains("Satuan") && jumlah < 1)
            {
                MessageBox.Show("Minimal layanan satuan adalah 1 pcs");
                return false;
            }

            return true;
        }
    }
}

# Sistem Informasi Laundry

## Deskripsi
Sistem Informasi Laundry ini dibuat untuk membantu proses pengelolaan operasional usaha laundry agar berjalan lebih efektif, terstruktur, dan terkomputerisasi. Sistem ini menggantikan proses pencatatan manual yang berpotensi menimbulkan kesalahan, kehilangan data, serta kesulitan dalam pencarian informasi transaksi dan pelanggan[cite: 8].

Tujuan utama dari program ini adalah:
* Mengelola data pelanggan dan layanan laundry secara terpusat[cite: 8].
* Mempermudah proses transaksi laundry mulai dari pencatatan hingga pembayaran[cite: 8].
* Memisahkan hak akses pengguna antara admin dan kasir[cite: 8].
* Menjamin keamanan data melalui sistem login dan aktivasi akun[cite: 8].
* Menyediakan informasi transaksi dan status laundry secara real-time[cite: 8].

---

## Fitur Utama & Alur Sistem

### 1. Konsep Hak Akses Pengguna
Sistem memiliki dua jenis pengguna (*role*), yaitu **Admin** dan **Kasir**[cite: 8]:
* **Admin:** Memiliki hak akses penuh terhadap sistem meliputi login admin, manajemen data pelanggan, manajemen data layanan, manajemen transaksi laundry, manajemen akun admin dan kasir, aktivasi akun kasir, serta logout[cite: 8].
* **Kasir:** Memiliki hak akses terbatas yang berfokus pada operasional transaksi meliputi login kasir, pendaftaran akun kasir, penambahan data pelanggan, penambahan transaksi laundry, proses pembayaran, penyimpanan transaksi, dan logout[cite: 8].

### 2. Fitur Umum Sistem
* Sistem login *multi-role* (Admin dan Kasir)[cite: 8].
* Validasi username, password, dan status akun (aktif/nonaktif) ke database[cite: 8].
* Manajemen hak akses menu berdasarkan *role*[cite: 8].
* Validasi input data pada setiap form[cite: 8].
* Navigasi halaman yang interaktif (kembali, keluar, dan logout)[cite: 8].

### 3. Alur dan Menu Admin
* **Halaman Awal & Login Admin:** Pengguna memilih masuk sebagai admin melalui `Masuk.cs` dengan validasi role dan status akun[cite: 8].
* **Menu Data Pelanggan:** Menampilkan data pelanggan dalam `DataGridView`, edit data, hapus data (jika belum memiliki transaksi), validasi relasi, dan pencarian data[cite: 8].
* **Menu Data Layanan:** Menampilkan, menambah, mengedit, menghapus, serta mencari data layanan[cite: 8].
* **Menu Transaksi:** Menampilkan seluruh transaksi, monitoring status laundry, mengubah status laundry (*Proses*), melihat detail transaksi, dan monitoring status pembayaran[cite: 8].
* **Manajemen Akun:** Menampilkan data akun, aktivasi akun kasir baru, perubahan status akun dari nonaktif menjadi aktif, serta manajemen *logout*[cite: 8].

### 4. Alur dan Menu Kasir
* **Login & Pendaftaran Kasir:** Kasir login melalui `MasukKasir.cs` (memerlukan aktivasi oleh admin). Kasir baru dapat mendaftar melalui `DaftarKasir.cs` dengan status awal nonaktif[cite: 8].
* **Tambah Pelanggan:** Input data pelanggan baru dan menyimpannya langsung ke database[cite: 8].
* **Tambah Transaksi & Pembayaran:** Pemilihan pelanggan, pemilihan multi-layanan ke `DataGridView` sementara, kalkulasi total otomatis, input uang bayar dengan validasi, perhitungan kembalian otomatis, serta pembaruan status pembayaran menjadi *Lunas*[cite: 8].

---

## ERD
![ERD Sistem Informasi Laundry](https://github.com/Aprill33/SistemLaundry/blob/master/ERD%20-%20sistem%20informasi%20laundry.jpeg)

---

## Tech Stack
- **Framework Tampilan:** Guna.UI
- **Backend:** C#
- **Database (DB):** MySQL
- **Database Connector:** MySqlConnector

---

## h. 🖼️ Screenshot Tampilan Aplikasi

### 1. Halaman Awal Program (Run Program)
<img width="800" alt="Halaman Awal" src="<img width="624" height="330" alt="Project_ NET_Fundamental" src="https://github.com/user-attachments/assets/c7344674-6849-4418-abd8-5a48653a848d" />
" />

---

### 2. Tampilan Menu Role Admin
* **Halaman Login Admin**  
  <img width="800" alt="<img width="624" height="328" alt="HalamanLoginAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/9af51117-b0d8-4b39-a848-45dfea10dd02" />
" />

* **Halaman Beranda Admin**  
  <img width="800" alt="Beranda Admin" src="<img width="626" height="328" alt="HalamanBerandaAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/e0ce572b-c6ab-40fc-8780-fba9d37ab86f" />
" />

* **Halaman Data Pelanggan Admin**  
  <img width="800" alt="Pelanggan Admin" src="<img width="628" height="329" alt="HalamanPelangganAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/15d00750-ca3e-44e3-9f24-5e01537227c6" />
" />

* **Halaman Data Layanan Admin**  
  <img width="800" alt="Layanan Admin" src="<img width="625" height="328" alt="HalamanLayananAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/42ea2efb-7650-4d2d-894e-dc37d1654dcc" />
" />

* **Halaman Transaksi Admin**  
  <img width="800" alt="Transaksi Admin" src="<img width="625" height="329" alt="HalamanTransaksiAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/11eb3595-31a5-4136-b2b9-4bd8680eb7d5" />
" />

* **Halaman Detail Transaksi Admin**  
  <img width="800" alt="Detail Transaksi Admin" src="<img width="626" height="328" alt="HalamanDetailTransaksiAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/c1e983f0-124b-45b7-9127-b4e0d7b239c8" />
" />

* **Halaman Edit Transaksi Admin**  
  <img width="800" alt="Edit Transaksi Admin" src="<img width="626" height="330" alt="HalamanEditTransaksiAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/959a6931-b70d-46d2-9318-f60b9e539909" />
" />

* **Halaman Kelola Admin / Akun**  
  <img width="800" alt="Kelola Admin" src="<img width="625" height="327" alt="HalamanKelolaAdmin_CSharp_Fundamental" src="https://github.com/user-attachments/assets/2e7a4e99-88e4-4427-bd9b-934ca3b9d862" />
" />

---

### 3. Tampilan Menu Role Kasir
* **Halaman Login Kasir**  
  <img width="800" alt="Login Kasir" src="MASUKKAN_LINK_GAMBAR_LOGIN_KASIR_DISINI" />

* **Halaman Pendaftaran Kasir (Register)**  
  <img width="800" alt="Daftar Kasir" src="MASUKKAN_LINK_GAMBAR_DAFTAR_KASIR_DISINI" />

* **Halaman Beranda Kasir**  
  <img width="800" alt="Beranda Kasir" src="MASUKKAN_LINK_GAMBAR_BERANDA_KASIR_DISINI" />

* **Halaman Tambah Pelanggan (Kasir)**  
  <img width="800" alt="Tambah Pelanggan Kasir" src="MASUKKAN_LINK_GAMBAR_TAMBAH_PELANGGAN_KASIR_DISINI" />

* **Halaman Tambah Transaksi (Kasir)**  
  <img width="800" alt="Tambah Transaksi Kasir" src="MASUKKAN_LINK_GAMBAR_TAMBAH_TRANSAKSI_KASIR_DISINI" />

* **Halaman Pembayaran (Kasir)**  
  <img width="800" alt="Pembayaran Kasir" src="MASUKKAN_LINK_GAMBAR_PEMBAYARAN_KASIR_DISINI" />

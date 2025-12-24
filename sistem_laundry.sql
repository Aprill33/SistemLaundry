CREATE DATABASE sistem_laundry;
USE sistem_laundry;

CREATE TABLE manajemen_admin_kasir (
    id_admin INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(30) NOT NULL UNIQUE,
    PASSWORD VARCHAR(100) NOT NULL,
    ROLE ENUM('admin','kasir') NOT NULL,
    STATUS ENUM('aktif','nonaktif') DEFAULT 'nonaktif'
);

CREATE TABLE pelanggan(
id_pelanggan VARCHAR(30) PRIMARY KEY,
nama_pelanggan VARCHAR(30),
no_hp VARCHAR(13),
alamat VARCHAR(50)
);

CREATE TABLE layanan(
id_layanan VARCHAR(30) PRIMARY KEY,
nama_layanan VARCHAR(30),
jenis_layanan VARCHAR(30),
harga INT,
estimasi_selesai INT,
gambar LONGBLOB
);

CREATE TABLE transaksi(
id_transaksi VARCHAR(30) PRIMARY KEY,
id_pelanggan VARCHAR(30) NOT NULL,
tanggal_masuk DATE,
tanggal_selesai DATE,
total INT,
status_laundry VARCHAR(30) DEFAULT 'Proses',
status_pembayaran VARCHAR(30) DEFAULT 'Menunggu Pembayaran',
uang_bayar INT DEFAULT 0,
kembalian INT DEFAULT 0,
FOREIGN KEY (id_pelanggan) REFERENCES pelanggan(id_pelanggan)
);

CREATE TABLE detail_transaksi(
 id_detail VARCHAR(30) PRIMARY KEY,
 id_transaksi VARCHAR(30) NOT NULL,
 id_layanan VARCHAR(30) NOT NULL,
 harga INT NOT NULL,
 jumlah DOUBLE NOT NULL,
 subtotal INT NOT NULL,
 FOREIGN KEY (id_transaksi) REFERENCES transaksi(id_transaksi),
 FOREIGN KEY (id_layanan) REFERENCES layanan(id_layanan)
);



INSERT INTO manajemen_admin_kasir (username, PASSWORD, ROLE, STATUS) VALUES
('admin1', '030405', 'admin', 'aktif'),
('kasir1', '190773', 'kasir', 'nonaktif');


INSERT INTO pelanggan VALUES
('P01', 'Nuroh Meilani', '087718676894', 'Asrama Baru Putri PUB'),
('P02', 'Nadhifa Almaira', '089773322242', 'Jl.Mentor 1 , No.8a'),
('P03', 'Keenan Kivandra', '087712633451', 'Asrama Putra PUB'),
('P04', 'Sandiaga Malik', '081915464987', 'Asrama Putra PUB'),
('P06', 'Alvand Ayani', '081915464988', 'Asrama Putra PUB'),
('P07', 'Lubnaa Naafisah', '089766722425', 'Asrama Baru Putri PUB');

INSERT INTO layanan(id_layanan, nama_layanan, jenis_layanan, harga, estimasi_selesai) VALUES
('L01', 'Cuci Setrika', 'Kiloan/Kg', 8000, 3),
('L02', 'Cuci Lipat', 'Kiloan/Kg', 7500, 2),
('L03', 'Cuci Bantal', 'Satuan/pcs', 10000, 2),
('L04', 'Cuci Boneka', 'Satuan/pcs', 10000, 2),
('L05', 'Cuci Selimut/Seprei', 'Satuan/pcs', 15000, 2),
('L06', 'Cuci Sepatu', 'Satuan/pcs', 10000, 2);

INSERT INTO transaksi (id_transaksi, id_pelanggan, tanggal_masuk, tanggal_selesai, total, status_laundry, status_pembayaran, uang_bayar, kembalian) VALUES 
('TRX001', 'P01', '2025-12-20', '2025-12-23', 26000, 'Selesai', 'Lunas', 30000, 4000),
('TRX002', 'P02', '2025-12-20', '2025-12-22', 15000, 'Selesai', 'Lunas', 20000, 5000),
('TRX003', 'P03', '2025-12-21', '2025-12-23', 20000, 'Selesai', 'Lunas', 20000, 0),
('TRX004', 'P04', '2025-12-21', '2025-12-23', 55000, 'Selesai', 'Lunas', 60000, 5000),
('TRX005', 'P06', '2025-12-21', '2025-12-23', 8000, 'Selesai', 'Lunas', 10000, 2000);

INSERT INTO detail_transaksi (id_detail, id_transaksi, id_layanan, harga, jumlah, subtotal) VALUES 
('DTL001', 'TRX001', 'L01', 8000, 2, 16000),
('DTL002', 'TRX001', 'L03', 10000, 1, 10000),
('DTL003', 'TRX002', 'L02', 7500, 2, 15000),
('DTL004', 'TRX003', 'L06', 10000, 2, 20000),
('DTL005', 'TRX004', 'L01', 8000, 5, 40000),
('DTL006', 'TRX004', 'L05', 15000, 1, 15000),
('DTL007', 'TRX005', 'L01', 8000, 1, 8000);

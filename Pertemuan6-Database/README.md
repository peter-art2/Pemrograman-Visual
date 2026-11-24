Nama: Peter Rangga Situmorang
NIM: 241712039

# Catatan Pertemuan 6: Integrasi Database PostgreSQL

Pada pertemuan ini dipelajari cara menghubungkan aplikasi Windows Forms dengan database PostgreSQL:
- **Koneksi Database (`NpgsqlConnection`)**: Membuka dan mengelola sesi koneksi ke basis data PostgreSQL.
- **Konfigurasi `appsettings.json`**: Menyimpan dan membaca connection string secara terpisah menggunakan pustaka `Microsoft.Extensions.Configuration.Json`.
- **Modul Utilitas Database (`ModDatabase`, `ModFunction`)**:
  - `AmbilData`: Menjalankan query SELECT dan memuat hasilnya ke dalam objek `DataTable` melalui `NpgsqlDataAdapter`.
  - `EksekusiData`: Menjalankan query INSERT, UPDATE, atau DELETE secara aman menggunakan parameter query (`NpgsqlCommand`) untuk mencegah celah keamanan SQL Injection.
- **Modul Query (`ModQuery`)**: Menyediakan fungsi logika transaksi data mahasiswa (`TambahData` dan `TampilkanData`).
- **Komponen DataGridView (`dgvForm1`)**: Menampilkan representasi data tabular dari `DataTable` pada antarmuka aplikasi.

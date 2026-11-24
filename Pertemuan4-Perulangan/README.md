Nama: Peter Rangga Situmorang
NIM: 241712039

# Catatan Pertemuan 4: Struktur Perulangan (Looping)

Pada pertemuan ini dipelajari penerapan struktur perulangan dan validasi input pada Windows Forms:
- **ListBox (`lstHasil`)**: Komponen untuk menampilkan sekumpulan data hasil iterasi secara berurutan.
- **TextBox (`txtNilaiAwal`, `txtNilaiAkhir`)**: Kotak isian untuk menentukan batas nilai awal dan batas nilai akhir perulangan.
- **Validasi Input (`KeyPress`)**: Memastikan input pada TextBox hanya berupa angka dan tombol kontrol seperti Backspace (`Char.IsDigit` dan `Char.IsControl`).
- **Validasi Tipe Data (`Integer.TryParse`)**: Memvalidasi teks masukan ke tipe data integer secara aman guna mencegah terjadinya crash pada aplikasi.
- **Perulangan `For...To...Next`**: Menjalankan blok perintah berulang kali dari nilai awal sampai nilai akhir.
- **Metode `lstHasil.Items.Clear()`**: Mengosongkan data ListBox sebelum hasil iterasi baru ditampilkan.

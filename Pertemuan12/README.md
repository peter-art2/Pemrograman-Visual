Nama: Peter Rangga Situmorang
NIM: 241712039

# Catatan Pertemuan 12: Aplikasi Multiple Document Interface (MDI)

Pada pertemuan ini dipelajari pembuatan aplikasi berbasis MDI (Multiple Document Interface) pada Windows Forms:
- **Form Induk MDI (`FrmUtama`)**: Mengaktifkan properti `IsMdiContainer = True` sebagai wadah form-form anak.
- **Form Anak MDI (`FrmMahasiswa`, `FrmJurusan`, `FrmTentang`)**: Mengaitkan form anak ke form induk melalui properti `MdiParent = Me`.
- **Pengelolaan Form Anak Aktif**: Iterasi pada `Me.MdiChildren` untuk mendeteksi apakah form sudah terbuka, mengaktifkannya (`Activate()`), dan mengembalikan ukurannya (`WindowState = FormWindowState.Normal`) jika terminimalisasi.
- **Pengaturan Tata Letak Jendela (`MdiLayout`)**:
  - `LayoutMdi(MdiLayout.Cascade)`: Mengatur susunan jendela form anak secara bertumpuk.
  - `LayoutMdi(MdiLayout.TileHorizontal)`: Mengatur susunan jendela form anak secara horizontal.
  - `LayoutMdi(MdiLayout.TileVertical)`: Mengatur susunan jendela form anak secara vertikal.
- **Navigasi Menu**: Penggunaan komponen `MenuStrip` untuk membuka data master mahasiswa, data jurusan, informasi tentang aplikasi, dan pengaturan tampilan jendela.

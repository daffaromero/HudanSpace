![Class Diagram](https://github.com/daffaromero/HudanSpace/blob/master/class%20diagram.png)
![Database Diagram](https://github.com/daffaromero/HudanSpace/blob/master/database%20diagram.png)
Untuk database diagram, semua tabel dibuat secara otomatis menggunakan ORM Entity Framework (EF), menggunakan perintah "add-migration" di Package Manager Console. Kami menambahkan 4 migrations di dalam proyek kami, yang menggunakan ASP.NET.

Gambar database diagram diambil menggunakan Microsoft SQL Server Management Studio 18. Database yang digunakan berasal dari (localdb)\MSSQLLocalDB, sehingga file-file database telah kami upload ke folder 'Database' tersendiri, yang terdiri dari file database (.mdf), file log (.ldf). Di dalamnya terdapat folder 'Tables' yang berisikan semua tabel (.sql).


Petunjuk Penggunaan :
Hudan Space merupakan website terbuka untuk setiap orang yang akan berbagi dan mencari ilmu tentang Al Quran. Sebagai MVP, website dapat digunakan untuk mengumpulkan link yang berisi courses. Siapapun dapat memberi penilaian terhadap course-nya. User cukup mengunjungi https://hudanspace.azurewebsites.net/, kemudian pada landing page klik “visit courses”. Di sana setiap user dapat mengupload link course mereka, dan user lain dapat saling berkunjung. Kedepannya pengembangan dari aplikasi ini diharapkan dapat menyediakan channel untuk user yang akan konsisten berbagi ilmu melalui website ini.

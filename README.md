## Project Base Learn .NET Console
Project console .NET basic from 0 to hero

## a. Format Literal String - Character escape sequences
Urutan karakter escape adalah instruksi ke runtime untuk menyisipkan karakter khusus yang akan memengaruhi output string Anda. Dalam C#, urutan karakter escape dimulai dengan garis miring \ terbalik diikuti oleh karakter yang Anda kabur. Misalnya, urutan \n akan menambahkan baris baru, dan urutan \t akan menambahkan tab.

```.cs
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
```

Jika ekspektasi yang ingin kita tampilkan seperti `Hello "World"!` maka eksekusi programnya

Bukan seperti dibawah `X`

```.cs
Console.WriteLine("Hello "World"!");
```
Tapi menangani situasi tersebut \" , gunakan urutan escape, yaitu seperti berikut `√`
```.cs
Console.WriteLine("Hello \"World\"!");
```
Lalu jika Anda perlu menggunakan garis miring terbalik untuk tujuan lain, seperti menampilkan jalur file? gunakan karakter seperti berikut
```.cs
Console.WriteLine("c:\\source\\repos");
```
Ekspektasi output adalah `c:\source\repos`, lalu dibawah ini kita ingin membuat output seperti berikut
```.sh
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory: 
```
Ekseksui programnya adalah sebagai berikut
```.cs
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
```
## b. Format Literal String - Verbatim string literal
Akan menyimpan semua spasi kosong dan karakter tanpa perlu menghindari garis miring terbalik. Untuk membuat string verbatim, gunakan arahan `@` sebelum string literal.
```.cs
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
```
## c. Format Literal String - Unicode escape characters
Anda juga dapat menambahkan karakter yang dikodekan dalam string harfiah menggunakan urutan escape \u, lalu kode empat karakter yang mewakili beberapa karakter dalam Unicode (UTF-16).

Untuk melihat di online bisa cek di website https://symbl.cc/en/unicode-table/

Contoh implementasi

```.cs
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```
Output `こんにちは World!`

Jika kita merujuk pada laman online site diatas kita ingin menampilkan tanda `*` dengan karakter unicode kita gunakan code program berikut

![Screenshot 2025-02-12 at 00 27 26](https://github.com/user-attachments/assets/f2c51584-382f-4e9c-a5a6-b1a15e668f71)

```.cs
Console.WriteLine("\u002A");
```
## d. Combine strings using string concatenation
Sering kali, Anda harus menggabungkan data dari berbagai sumber, termasuk string harfiah dan variabel yang berisi data teks dan numerik. Di pelajaran ini, Anda akan menggunakan perangkaian string untuk menggabungkan dua atau lebih nilai menjadi string baru.

Sederhananya misal menggabungkan kata `Rumah Makan` rangkaian 2 kata dijadikan 1 `Rumah` dan `Makan`

String concatenationadalah "programmer speak" hanya untuk menggabungkan dua nilai atau lebih string ke dalam nilai baru string . Tidak seperti penambahan, nilai kedua ditambahkan ke akhir nilai pertama, dan seterusnya. Dalam latihan berikut, Anda akan menulis kode untuk menggabungkan string nilai bersama-sama.

### 1. Menggabungkan string literal dan variabel
Untuk menggabungkan dua string, Anda menggunakan operator perangkaian string, yang merupakan simbol plus `+`

```.cs
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
```
Perhatikan urutannya—string "Hello " pertama berada di string baru, dan nilai dalam firstName variabel ditambahkan ke akhir.

### 2. Concatenate multiple variables and literal strings
Anda dapat melakukan beberapa operasi perangkaian dalam baris kode yang sama. Di sini Anda membuat pesan yang lebih kompleks dengan menggabungkan beberapa variabel dan string literal.

```.cs
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
```

### 3. Avoiding intermediate variables
Pada langkah-langkah sebelumnya, Anda menggunakan variabel tambahan untuk menahan string baru yang dihasilkan dari operasi perangkaian (concatenation). Kecuali Anda memiliki alasan yang baik untuk melakukannya, Anda dapat (dan harus) menghindari penggunaan variabel perantara dengan melakukan operasi perangkaian sesuai kebutuhan.

```.cs
Console.WriteLine(greeting + " " + firstName + "!");
```
Output tetap sama sebenarnya
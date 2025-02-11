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

```.cs
Console.WriteLine("\u002A");
```
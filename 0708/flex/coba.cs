int angka = 57;
int tebakan = 0;

System.Console.WriteLine("Tebak angka 1-100");
System.Console.WriteLine("Masukkan angka tebakan anda:");
int tebakan = Convert.ToInt32(System.Console.ReadLine());

while (tebakan != angka)
{
    if (tebakan < angka) {
        System.Console.WriteLine("Angka terlalu kecil");
    }

    else {
        System.Console.WriteLine("Angka terlalu besar");
    }
    
    System.Console.WriteLine("Selamat, tebakan anda benar!");
    Console.ReadKey();

}

using Modul3_2311104041;

class MainClass
{
    static void Main()
    {
        Console.Write("Masukkan nama buah: ");
        string namaBuah = Console.ReadLine();

        // Mendapatkan kode buah dari kelas KodeBuah
        string kode = KodeBuah.GetKodeBuah(namaBuah);

        Console.WriteLine("Kode Buah: " + kode);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bebek
{
    // Bebek sınıfının özellikleri
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    // Parametre almayan default constructor
    public Bebek()
    {
        // "Ingaaaa" yazdır ve doğum tarihini şu an olarak ata
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now;
    }

    // Ad ve Soyad parametrelerini alan constructor
    public Bebek(string ad, string soyad)
    {
        // "Ingaaaa" yazdır, ad ve soyad property'lerine atama yap ve doğum tarihini şu an olarak ata
        Console.WriteLine("Ingaaaa");
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now;
    }

    // Bebek bilgilerini ekrana yazdıran metot
    public void DisplayInfo()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Default constructor ile bir Bebek nesnesi oluştur
        Bebek bebek1 = new Bebek();
        bebek1.Ad = "Esila";
        bebek1.Soyad = "Gönen";
        bebek1.DisplayInfo();

        // Ad ve Soyad parametreli constructor ile bir Bebek nesnesi oluştur
        Bebek bebek2 = new Bebek("Emre", "Polat");
        bebek2.DisplayInfo();
    }
}

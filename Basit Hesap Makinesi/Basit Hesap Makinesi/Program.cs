using System;

class Program
{
    static void Main(string[] args)
    {
        int secim;
       git: do
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.WriteLine("5- Mod alma");
            Console.WriteLine("0- Çıkış");
            if (int.TryParse(Console.ReadLine(),out secim))
            {
                Console.WriteLine("{0} Seçildi.",secim);
            }
            else
            {
                Console.WriteLine("Sayı Girişi Yapınız.");
                goto git;
            }
            switch (secim)
            {
                case 0:
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                case 1:
                    Toplama();
                    break;
                case 2:
                    Cikarma();
                    break;
                case 3:
                    Carpma();
                    break;
                case 4:
                    Bolme();
                    break;
                case 5:
                    ModAlma();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim!");
                    break;
            }
            Console.WriteLine();
        } while (secim != 0);
    }

    static void Toplama()
    {
        Console.WriteLine("Toplama işlemi yapılacak.");
        double sayi1 = 0;
        double sayi2 = 0;
        bool sayi1Gecerli = false;
        bool sayi2Gecerli = false;

        while (!sayi1Gecerli)
        {
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi1))
            {
                sayi1Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        while (!sayi2Gecerli)
        {
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi2))
            {
                sayi2Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        double toplam = sayi1 + sayi2;
        Console.WriteLine("Girilen sayıların toplamı: " + toplam);
        Console.WriteLine();
    }

    static void Cikarma()
    {
        Console.WriteLine("Çıkarma işlemi yapılacak.");
        double sayi1 = 0;
        double sayi2 = 0;
        bool sayi1Gecerli = false;
        bool sayi2Gecerli = false;

        while (!sayi1Gecerli)
        {
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi1))
            {
                sayi1Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        while (!sayi2Gecerli)
        {
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi2))
            {
                sayi2Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        double fark = sayi1 - sayi2;
        Console.WriteLine("Girilen sayıların farkı: " + fark);
        Console.WriteLine();
    }

    static void Carpma()
    {
        Console.WriteLine("Çarpma işlemi yapılacak.");
        double sayi1 = 0;
        double sayi2 = 0;
        bool sayi1Gecerli = false;
        bool sayi2Gecerli = false;

        while (!sayi1Gecerli)
        {
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi1))
            {
                sayi1Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        while (!sayi2Gecerli)
        {
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi2))
            {
                sayi2Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        double carpim = sayi1 * sayi2;
        Console.WriteLine("Girilen sayıların çarpımı: " + carpim);
        Console.WriteLine();
    }

    static void Bolme()
    {
        Console.WriteLine("Bölme işlemi yapılacak.");
        double sayi1 = 0;
        double sayi2 = 0;
        bool sayi1Gecerli = false;
        bool sayi2Gecerli = false;

        while (!sayi1Gecerli)
        {
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi1))
            {
                sayi1Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        while (!sayi2Gecerli)
        {
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out sayi2) && sayi2 != 0)
            {
                sayi2Gecerli = true;
            }
            else if (sayi2 == 0)
            {
                Console.WriteLine("Hatalı giriş! Sıfıra bölme hatası veya karakter girişi hatası.");
            }
        }

        double bolum = (double)sayi1 / sayi2;
        Console.WriteLine("Girilen sayıların bölümü: " + bolum);
        Console.WriteLine();
    }

    static void ModAlma()
    {
        Console.WriteLine("Mod alma işlemi yapılacak.");
        int sayi1 = 0;
        int sayi2 = 0;
        bool sayi1Gecerli = false;
        bool sayi2Gecerli = false;

        while (!sayi1Gecerli)
        {
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out sayi1))
            {
                sayi1Gecerli = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        while (!sayi2Gecerli)
        {
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out sayi2) && sayi2 != 0)
            {
                sayi2Gecerli = true;
            }
            else if (sayi2 == 0)
            {
                Console.WriteLine("Hatalı giriş! Sıfıra bölme hatası.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayısal veri giriniz.");
            }
        }

        double mod = sayi1 % sayi2;
        Console.WriteLine("{0} mod {1} = {2}: ", sayi1,sayi2, mod);

        Console.ReadKey();
    }
}
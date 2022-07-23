using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YAZILIMCI GELİŞTİRME KURSU";
            string kurs2 = "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS";
            string kurs3 = "JAVA KURSU";
            //array-dizi
            string[] kurslar = new string[] { "YAZILIMCI GELİŞTİRME KURSU", "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS", "JAVA KURSU","PYHTON" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }


            Console.WriteLine("SAYFA SONU- footer");
        }
    }
}

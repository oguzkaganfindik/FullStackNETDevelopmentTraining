using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090__StaticOrnek.Models
{
    internal static class Metotlar
    {
        public static double OrtalamaHesapla(double vize, double final)
        {
            double ortalama = vize * KatSayilar.VizeKatSayisi + final * KatSayilar.FinalKatSayisi;

            return ortalama;
        }

        public static void DurumBildir(double ort)
        {
            Console.WriteLine(ort >= 55 ? "GEÇTİNİZ." : "KALDINIZ.");
        }
    }
}

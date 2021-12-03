using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gıtar g1 = new Gıtar()
            {
                Markasi = "Fender",
                MuzikAletiAdi = "Gitar"
            };

            Flut f1 = new Flut();
            f1.Markasi = "Yamaha";
            f1.MuzikAletiAdi = "Flut";

            Muzisyen m1 = new Muzisyen();
            m1.AdiSoyadi = "Onur Şan";
            m1.CaldığıMuzikAleti = g1;

            Muzisyen m2 = new Muzisyen();
            m2.AdiSoyadi = "Leman Sam";
            m2.CaldığıMuzikAleti = f1;

            Console.WriteLine(m1.AdiSoyadi+" "+m1.CaldığıMuzikAleti.MuzikAletiAdi+" çalıyor....");
            m1.CaldığıMuzikAleti.Cal();

            Console.WriteLine(m2.AdiSoyadi + " " + m2.CaldığıMuzikAleti.MuzikAletiAdi + " çalıyor....");
            m2.CaldığıMuzikAleti.Cal();

            Console.ReadLine();




        }
    }
}

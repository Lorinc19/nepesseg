using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszaglista = new List<Orszag>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                orszaglista.Add(new Orszag(sr.ReadLine()));
            }
            sr.Close();
            //4 feladat
            Console.WriteLine("4.feladat");
            Console.WriteLine($"{orszaglista.Count()} db ország van felsorolva");

            //5 feladat
            Console.WriteLine("5.feladat");
            foreach (var item in orszaglista)
            {
                if (item.orszag =="Kína")
                {
                    Console.WriteLine($"Kína népessége: {item.Nepsurusseg(item.terulet,item.nepessegg)} fő/km2");
                }
            }
            //6.feladat
            Console.WriteLine("6.feladat");
            int k = 0;
            int ind = 0;
            foreach (var item in orszaglista)
            {

                if(item.orszag == "Kína" )
                {
                    k += item.nepessegg;
                }
                if(item.orszag == "India")
                {
                    ind += item.nepessegg;
                }
                
            }
            int tobb = k - ind;
            Console.WriteLine($"Kínában a lakosság {tobb} fővel volt több");

            //7. feladat
            Console.WriteLine("7. feladat");
            int hnagy = 0;
            string hnagyo = "";
            foreach(var item in orszaglista)
            {
                if (item.orszag!="Kína"||item.orszag!="India"&& hnagy<item.nepessegg)
                {
                    hnagy += item.nepessegg;
                    hnagyo = item.orszag;
                }
            }
            Console.WriteLine($"A harmadik legnagyobb ország: {hnagyo}, a lakossága: {hnagy} db fő");
            Console.ReadLine();
        }
        
    }
}

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
        }
    }
}

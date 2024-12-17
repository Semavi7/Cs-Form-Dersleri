using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kimlik kml = new kimlik();
            kml.AD = "Murat";
            kml.SOYAD = "Yücedağ";
            kml.MEMLEKET = "Elazığ";

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
        }
    }
}

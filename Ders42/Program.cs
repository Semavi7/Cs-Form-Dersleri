using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blg;
            Console.Write("Ad - Kulüp: ");
            blg = Console.ReadLine();
            Ogrenci org = new Ogrenci(blg);
        }
    }
}

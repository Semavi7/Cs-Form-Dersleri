using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();
            string ads;
            ads = Console.ReadLine();
            ks.kisilistesi(ads);
        }
    }
}

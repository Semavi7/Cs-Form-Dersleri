using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(4, 6);
            Console.WriteLine("\n");
            isl.kare(5);
        }
    }
}

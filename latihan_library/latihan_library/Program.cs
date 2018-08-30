using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using casio;

namespace latihan_library
{
    class Program
    {
        static void Main(string[] args)
        {

            menghitung hitung1 = new menghitung();
            Console.Write("Masukkan x   : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Masukkan y   : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("" + System.Environment.NewLine);
            Console.Write("Hasil Tambah  = ");
            Console.WriteLine(hitung1.add(x,y));
            Console.Write("Hasil Kurang  = ");
            Console.WriteLine(hitung1.min(x, y));
            Console.Write("Hasil Kali  = ");
            Console.WriteLine(hitung1.cross(x, y));
            Console.Write("Hasil Bagi  = ");
            Console.WriteLine(hitung1.devide(x, y));
            Console.ReadLine();
            
        }
    }
}

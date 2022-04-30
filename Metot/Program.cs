using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toplamak istediğiniz birinci sayıyı giriniz : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplamak istediğiniz ikinci sayıyı giriniz : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int toplam = Topla(x, y);
            Console.WriteLine("Toplam = " + toplam);
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}

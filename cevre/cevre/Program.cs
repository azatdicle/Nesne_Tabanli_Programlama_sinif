using Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cevre;
 internal class Program
{
    static void Main(string[] args)
    {

        sayibulucu nesne = new sayibulucu();
        //1.Şekil veri girme
        Console.WriteLine(nesne.BuyukOlaniBul(5, 6));
        
        //2 Şekil veri girme
        //nesne.BuyukOlaniBul(sayi1: 50, sayi2: 50);

        /*
        Ucgen ucgen1 = new Ucgen();
        ucgen1.A = 5;
        ucgen1.B = 5;
        ucgen1.C = 5;

        Console.WriteLine(ucgen1.Cevre); // Ucgen birin a + b + c değierini gösteriyor
        */

        Console.ReadKey();
        }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>();
            bank1.Input();
            Console.WriteLine(bank1.GetInfo());

            Bank<string> bank2 = new Bank<string>();
            bank2.Input();
            Console.WriteLine(bank2.GetInfo());

            Console.ReadKey();
        }
    }
}

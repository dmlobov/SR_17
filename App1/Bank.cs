using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Bank<T>
    {
        T Num { get; set; }
        string Name { get; set; }
        
        double Balans { get; set; }

        public string GetInfo()
        {
            return $"{Num}  {Name}  {Balans}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите имя сотрудника");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            Balans = Convert.ToDouble(Console.ReadLine());
        }
    }
}

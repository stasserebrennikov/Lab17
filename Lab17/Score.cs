using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Score<T>
    {
        public T Code { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return$"{Code} {Balance} {Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите счет");
            string stringCode = Console.ReadLine(); 
            Code = (T)Convert.ChangeType(stringCode,typeof(T));

            Console.WriteLine("Введите баланс  банковского счета");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();  




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberCheck
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете цяло число: ");
            int input = int.Parse(Console.ReadLine());
            if(input % 2 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Не");
            }
        }
    }
}

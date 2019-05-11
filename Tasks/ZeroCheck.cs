using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class ZeroCheck
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете цяло число: ");
            int input = int.Parse(Console.ReadLine());
            if(input == 0)
            {
                Console.WriteLine("Числото е равно на нула");
            }
            else if(input < 0)
            {
                Console.WriteLine("Числото е по-малко от нула");
            }
            else
            {
                Console.WriteLine("Числото е по-голямо от нула");
            }
        }
    }
}

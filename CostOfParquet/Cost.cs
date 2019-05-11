using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfParquet
{
    class Cost
    {
        static void Main(string[] args)
        {
            double rLength = 0;
            double rWidth = 0;
            double pForMeter = 0;
            var valid = false;

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Въведете дължина на стаята: ");
            while (!valid)
            {
                string roomLength = Console.ReadLine();

                if (double.TryParse(roomLength, out rLength))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Моля, въведете коректна дължина.");
                }
            }

            valid = false;

            Console.WriteLine("Въведете ширина на стаята: ");
            while (!valid)
            {
                string roomWidth = Console.ReadLine();

                if (double.TryParse(roomWidth, out rWidth))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Моля, въведете коректна ширина.");
                }
            }

            valid = false;

            Console.WriteLine("Въведете цена на паркета на 1 кв. м.: ");
            while (!valid)
            {
                string priceForMeter = Console.ReadLine();

                if (double.TryParse(priceForMeter, out pForMeter))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Моля, въведете коректна цена.");
                }
            }

            double areaOfRoom = rLength * rWidth;
            double priceOfRoom = areaOfRoom * pForMeter;

            Console.WriteLine($"Цената на паркета е : { priceOfRoom.ToString("N2") } лв.");
        }
    }
}

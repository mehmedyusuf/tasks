namespace ClockValidation
{
    using System;
    using System.Text;

    class Clock
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете час и минути: ");
            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, System.StringSplitOptions.RemoveEmptyEntries);
            int hour;
            int minutes;
            bool correct = true;
            
            if(input.Length == 2)
            {
                if (int.TryParse(input[0], out hour))
                {
                    if (hour < 0 || hour > 23)
                    {
                        Console.WriteLine("Часът е невалиден.");
                        correct = false;
                    }
                }
                else
                {
                    Console.WriteLine("Въведете число.");
                }

                if (int.TryParse(input[1], out minutes))
                {
                    if (minutes < 0 || minutes > 59)
                    {
                        Console.WriteLine("Минутите са невалидни.");
                        correct = false;
                    }
                }
                else
                {
                    Console.WriteLine("Въведете число.");
                }

                if (correct)
                {
                    Console.WriteLine("Часът и минутите са коректно въведени.");
                }
            }
            else
            {
                Console.WriteLine("Въведете час и минути.");
            }
            
            


        }
    }
}

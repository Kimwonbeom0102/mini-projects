using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("Anykey to start Stopwatch");

                string s = Console.ReadLine();
                if (s != null)
                {
                    stopwatch.Start();

                    Console.WriteLine("Anykey to Stop in 3 seconds");
                    Console.ReadLine();

                    stopwatch.Stop();

                    Console.WriteLine("Anykey to check Duration time");
                    Console.ReadLine();
                    Console.WriteLine(stopwatch.GetDuration());
                    Console.WriteLine("Try again ? (y/n)");

                    string s2 = Console.ReadLine();
                    if (s2 != "y")
                        break;
                    else
                        Console.Clear();

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            part1();
            part2();
            part3();
        }

        static void part1()
        {
            int firstNum;
            int secondnum;
            int thirdnum;
            int sum;

            Console.WriteLine("enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine($"hello, {name} your birthday is 08/16/03");
            Console.ReadLine();

            Console.WriteLine("enter 3 numbers to get the sum...");
            Console.WriteLine("Please enter 3 numbers...");

            firstNum = Convert.ToInt32(Console.ReadLine());
            secondnum = Convert.ToInt32(Console.ReadLine());
            thirdnum = Convert.ToInt32(Console.ReadLine());

            sum = (firstNum + secondnum + thirdnum);
            Console.WriteLine($"The sum of your numbers is... {sum}");
            
            Console.WriteLine("Press any key to close");
            Console.ReadLine();

        }
                    
        static void part2()
        {
            double firstnum;
            double secondnum;
            double thirdnum;
            double sum;
            double total;


            Console.WriteLine("Please enter 3 numbers to calculate the average...");


            firstnum = Convert.ToDouble(Console.ReadLine());

            secondnum = Convert.ToDouble(Console.ReadLine());

            thirdnum = Convert.ToDouble(Console.ReadLine());
            sum = firstnum + secondnum + thirdnum;
            total = sum / 3;

            Console.WriteLine("Please press 'Enter' to get the average...");
            Console.ReadLine();
            Math.Round(total, 2);
            Console.WriteLine($" The average is...  {total}");

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

        static void part3()
        {
            double leg1;
            double leg2;
            double hypotenuse;


            Console.WriteLine("Please enter 2 numbers...");
            leg1 = Convert.ToDouble(Console.ReadLine());
            leg2 = Convert.ToDouble(Console.ReadLine());


            leg1 = leg1 * leg1;
            leg2 = leg2 * leg2;
            hypotenuse = leg1 + leg2;
            hypotenuse = Math.Sqrt(hypotenuse);
            hypotenuse = Math.Round(hypotenuse, 2);


            Console.WriteLine($"Answer is...{hypotenuse}");

            Console.WriteLine("Press 'Any Key' to close...");
            Console.ReadLine();
        }































































    }
    }


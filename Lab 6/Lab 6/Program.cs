using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int iSides;
            string sSides;
            int counter = 0;
            bool valid = true;
            string cont;
            Random rnd = new Random();

            //header
            Console.WriteLine("Dice Rolling Console Application");
            Console.WriteLine("======================================");
            while (valid)
            {
                Console.WriteLine("Please enter the number of sides for your pair of dice:");
                sSides = Console.ReadLine();
                while ((!(Int32.TryParse(sSides, out iSides))))
                {
                    Console.WriteLine("ERROR:Please enter a valid number of sides:");
                    sSides = Console.ReadLine();
                }

                counter++;

                Console.WriteLine("Roll " + counter + ":");
                string num1 = rnd.Next(1, iSides).ToString();
                string num2 = rnd.Next(1, iSides).ToString();
                Console.WriteLine(num1);
                Console.WriteLine(num2);



                //exit
                Console.WriteLine("Press y to roll again or press any other key to exit");
                cont = Console.ReadLine();
                if (cont.ToLower() == "y")
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("Thanks for using my app");
            Console.WriteLine("*******************************");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;


            do
            {

                Console.Write("Zgadnij Liczbę w przedziale 0 do 100 s :  ");
                string p = Console.ReadLine();

                int i = int.Parse(p);

                if (i > winNum)
                {
                    Console.WriteLine("Za duża liczba zgaduj dalej!!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Liczba za niska zgaduj dalej!!");
                }

                else if (i == winNum)
                {
                    Console.WriteLine("Wygrałeś!!!");
                    win = true;
                }
                Console.WriteLine();
                
               
            } while (win == false);

            Console.WriteLine("Dziękuje za gre!!!!!");

            Console.WriteLine("Naciśnij dowolny klawisz żeby zakończyc");

            Console.ReadKey();

        }

    }
}

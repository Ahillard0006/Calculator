using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        public static bool AppIsRunning = true;
        static void Main(string[] args)
        {
            while (AppIsRunning == true)
            {
                float Answer;
                float FirstNumber;
                float SecondNumber;
                FirstNumber = float.Parse(Console.ReadLine());
                Console.WriteLine("What would you like to do?");
                string MagicSauce = Console.ReadLine();
                SecondNumber = float.Parse(Console.ReadLine());
                if (MagicSauce == "+")
                {
                    Answer = FirstNumber + SecondNumber;
                    Console.WriteLine(Answer);
                }
                else if (MagicSauce == "/")
                {
                    Answer = FirstNumber / SecondNumber;
                    Console.WriteLine(Answer);
                }
                else if (MagicSauce == "*" || MagicSauce == "x" || MagicSauce == "X")
                {
                    Answer = FirstNumber * SecondNumber;
                    Console.WriteLine(Answer);
                }
                else if (MagicSauce == "-")
                {
                    Answer = FirstNumber - SecondNumber;
                    Console.WriteLine(Answer);
                }
                else
                {
                    Answer = Convert.ToString("Error");
                }
                Console.WriteLine(Answer);
                Console.WriteLine("Would you like to try again?");
            }
        }
    }
}

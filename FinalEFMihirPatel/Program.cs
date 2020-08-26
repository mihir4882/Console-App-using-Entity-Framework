using System;

using System.IO;

namespace FinalEFMihirPatel
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("\t\t\n Book Database using Entity Framework");
            do
            {
                try
                {

                    Console.WriteLine("\n\t\t 1 - View all authors");
                    Console.WriteLine("\t\t 2 - Add author");
                    Console.WriteLine("\t\t 3 - Update author");
                    Console.WriteLine("\t\t 4 - Exit");

                    Console.WriteLine("\n Select your option:");
                    input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            methods.View();
                            continue;
                        case 2:
                            methods.Add();
                            continue;
                        case 3:
                            methods.Update();
                            continue;
                        case 4:
                            break;

                        default:
                            Console.WriteLine("\nInvalid Entry!!!");
                            continue;
                    }
                }


                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid Entry!!!");
                }


            }
            while (input != 4);

        }
    }
}


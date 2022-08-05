using System;

namespace CSharp_One
{


    enum choices
    {
        Add,
        Multiple,
        Divise,
        Subtract,
        Exit
    }

    internal class Program
    {

        static void Main()
        {
            ConsoleKey click = new ConsoleKey();

            int choice = 0;
            choices[] Choices = { choices.Add, choices.Multiple, choices.Divise, choices.Subtract, choices.Exit };

            while (true)
            {

                Console.Clear();
                foreach (var item in Choices)
                {
                    if (choice == (int)item)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    else
                        Console.WriteLine(item);
                }

                click = Console.ReadKey().Key;

                if (click == ConsoleKey.UpArrow)
                    choice--;
                else if (click == ConsoleKey.DownArrow)
                    choice++;


                if (choice == -1)
                    choice = 4;
                else if (choice == 5)
                    choice = 0;

                if (click == ConsoleKey.Enter)
                {
                    switch (choice)
                    {
                        case (int)choices.Add:
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write("Enter First Number: ");
                                    string? input_number_one = Console.ReadLine();

                                    Console.Clear();
                                    Console.Write($"{input_number_one} + ");
                                    string? input_number_second = Console.ReadLine();

                                    double number_one = default;
                                    double number_second = default;
                                    double.TryParse(input_number_one, out number_one);
                                    double.TryParse(input_number_second, out number_second);

                                    Console.Clear();

                                    Console.WriteLine($"{number_one} + {number_second} = {(double)number_one + number_second}");
                                    Console.WriteLine("Do You Want Continue?(Y or N): ");
                                    string key = Console.ReadLine();
                                    if (key == "N" || key == "n")
                                        break;
                                }
                                break;
                            }
                        case (int)choices.Multiple:
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write("Enter First Number: ");
                                    string? input_number_one = Console.ReadLine();

                                    Console.Clear();
                                    Console.Write($"{input_number_one} * ");
                                    string? input_number_second = Console.ReadLine();

                                    double number_one = default;
                                    double number_second = default;
                                    double.TryParse(input_number_one, out number_one);
                                    double.TryParse(input_number_second, out number_second);

                                    Console.Clear();
                                    Console.WriteLine($"{number_one} * {number_second} = {(double)number_one * number_second}");
                                    Console.WriteLine("Do You Want Continue?(Y or N): ");
                                    string key = Console.ReadLine();
                                    if (key == "N" || key == "n")
                                        break;
                                }
                                break;
                            }
                        case (int)choices.Divise:
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write("Enter First Number: ");
                                    string? input_number_one = Console.ReadLine();

                                    Console.Clear();
                                    Console.Write($"{input_number_one} / ");
                                    string? input_number_second = Console.ReadLine();

                                    double number_one = default;
                                    double number_second = default;
                                    double.TryParse(input_number_one, out number_one);
                                    double.TryParse(input_number_second, out number_second);

                                    Console.Clear();
                                    Console.WriteLine($"{number_one} / {number_second} = {(double)number_one / number_second}");
                                    Console.WriteLine("Do You Want Continue?(Y or N): ");
                                    string key = Console.ReadLine();
                                    if (key == "N" || key == "n")
                                        break;
                                }
                                break;
                            }
                        case (int)choices.Subtract:
                            {

                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write("Enter First Number: ");
                                    string? input_number_one = Console.ReadLine();

                                    Console.Clear();
                                    Console.Write($"{input_number_one} - ");
                                    string? input_number_second = Console.ReadLine();

                                    double number_one = default;
                                    double number_second = default;
                                    double.TryParse(input_number_one, out number_one);
                                    double.TryParse(input_number_second, out number_second);

                                    Console.Clear();
                                    Console.WriteLine($"{number_one} - {number_second} = {(double)number_one - number_second}");
                                    Console.WriteLine("Do You Want Continue?(Y or N): ");
                                    string key = Console.ReadLine();
                                    if (key == "N" || key == "n")
                                        break;
                                }
                                break;
                            }
                        default:
                            break;
                    }
                }

                if (click == ConsoleKey.Enter && choice == (int)choices.Exit)
                    break;
            }
        }
    }
}

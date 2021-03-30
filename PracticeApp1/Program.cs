using System;
using System.Collections.Generic;

namespace PracticeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Excuting code and test here
            try
            {
                Book book1 = new Book("New Book", "Andy", 30, 2);
                Console.WriteLine(book1.GetString());
                Console.WriteLine(Book.bookCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            PopUpBook popUpBook = new PopUpBook("PopUp Book", "AndyJPG", 30, 2);
            Console.WriteLine(popUpBook.GetString());*/

            //FibonacciNumbers101();
            ReadJsonFile.ReadPortfolioDataToJson();
        }

        static void Numbers()
        {
            Console.WriteLine($"The range of short is {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"The range of integers is {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"The range of decimal is {decimal.MinValue} to {decimal.MaxValue}");

            Console.WriteLine($"Integer percision {1/3}");
            Console.WriteLine($"Double percision {1.0 / 3.0}");
            Console.WriteLine($"Decimal percision {1.0M / 3.0M}");
        }

        static void StaticMethod()
        {
            // Math static method
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Andy");
        }

        static void Exception()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

        }

        static void TwoDArray()
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 1]);
        }

        static double GetPow(double baseNum, double powNum)
        {
            return Math.Pow(baseNum, powNum);
        }

        static void FibonacciNumbers101()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            int stopPoint = 20;

            while (fibonacciNumbers.Count < stopPoint)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void SortSearchIndexLists101()
        {
            var names = new List<string> { "<name>", "Ana", "Emily", "Andy", "Claire" };
            int index = names.IndexOf("Andy");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"Found {names[index]} at {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void ListPractice101()
        {
            // List<string> names = new List<string> { "<name>", "Andy", "Ana" };
            var names = new List<string> { "<name>", "Andy", "Ana" };

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            Console.WriteLine(names[2]);

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
        }

        static void ForLoopChallenge101()
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        static void ForLoop()
        {
            int[] luckyNumbers = { 4, 8, 9, 12, 34, 52 };

            for (int index = 1; index < luckyNumbers.Length; index++)
            {
                Console.WriteLine(luckyNumbers[index]);
            }
        }

        static void GuessingGame()
        {
            string secretWord = "andy";
            string guess;
            int guessLimit = 3;
            int guessCount = 0;

            do
            {
                Console.Write("Guess a word: ");
                guess = Console.ReadLine();
                
                guessCount++;
                Console.WriteLine("Guesses left: " + Convert.ToString(guessLimit - guessCount));
            } while (guess != secretWord && guessCount < guessLimit);

            if (guess == secretWord)
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("Out of guesses");
            }
            
        }

        static void WhileLoop()
        {
            int index = 1;
            while(index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
        }

        static string GetDay(int dayNum)
        {
            switch(dayNum)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return "Invalid";
            }
        }

        static void BetterCalculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }
        }

        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 == num2)
            {
                result = num1;

            } else if (num1 > num2)
            {
                result = num1;

            } else
            {
                result = num2;
            }

            return result;
        }

        static void IfStatement()
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && !isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale)
            {
                Console.WriteLine("You are a male");
            }
            else
            {
                Console.WriteLine("You are not male");
            }

        }

        static double Cube(double num)
        {
            double result = Math.Pow(num, 3);

            return result;
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);

        }

        static void Arrays()
        {
            int[] luckyNumbers = { 4, 9, 15, 23, 45};
            string[] friends = new string[5];
            friends[0] = "Jim";

            Console.WriteLine(luckyNumbers[1]);

        }

        static void Calculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your output is " + Convert.ToString(num1 + num2));
        }

        static void Practice()
        {
            string characterName = "Andy";
            char grade = 'A';
            int characterAge;
            characterAge = 28;
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello " + characterName);
            Console.WriteLine("My age is " + characterAge + " years old");
            Console.WriteLine("Another line \n Here is another line");
            Console.WriteLine(characterName.ToUpper());
            Console.WriteLine(characterName.Contains("A"));
            Console.WriteLine(characterName[0]);
            Console.WriteLine(characterName.IndexOf("An"));
            Console.WriteLine(characterName.Substring(1, 2));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Max(9, 1));
            Console.WriteLine(Math.Round(4.6));

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
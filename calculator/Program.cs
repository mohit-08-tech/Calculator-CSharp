using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator op = new Calculator();
        start:
            Console.Clear();
            int inputchoice = 0;
            double result = 0;
            char userin = 'Y';
            Console.WriteLine("                             ---------CALCULATOR | By - Mohit Kumar ---------");
            Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
            do
            {
                try
                {
                    Console.Write("\nEnter you choice: ");
                    inputchoice = int.Parse(Console.ReadLine());
                    if (inputchoice > 5)
                    {
                        Console.WriteLine("Wrong Choice!!!");
                        Thread.Sleep(1000);
                        goto start;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Invalid Choice!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto start;
                }
                switch (inputchoice)
                {

                    case 1:
                        {
                            Console.WriteLine("-------Addtion-------");
                            result = op.Addition();
                            Console.WriteLine("Answer is: {0}", result);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-------Subtraction-------");
                            result = op.Subtraction();
                            Console.WriteLine("Answer is: {0}", result);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-------Multiplication-------");
                            result = op.Multiplication();
                            Console.WriteLine("Answer is: {0}", result);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-------Division-------");
                            result = op.Division();
                            Console.WriteLine("Answer is: {0}", result);
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                }
            UserCh:
                try
                {
                    Console.Write("\nPress Y to continue or any other key to exit: ");
                    userin = char.Parse(Console.ReadLine());
                    if (userin == 'y' || userin == 'Y')
                    {
                        goto start;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Wrong Input!!!");
                    goto UserCh;

                }


            } while (userin == 'Y' || userin == 'y');
            Console.WriteLine("Thanks for using this calculator");
        }
    }
    class Calculator
    {
        double input1 = 0, input2 = 0;
        public double Addition()
        {
        Add1:
            try
            {
                Console.Write("Enter first number: ");
                input1 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Add1;
            }
        Add2:
            try
            {
                Console.Write("Enter second number: ");
                input2 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Add2;
            }

            return input1 + input2;
        }
        public double Subtraction()
        {
        Sub1:
            try
            {

                Console.Write("Enter first number: ");
                input1 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Sub1;
            }
        Sub2:
            try
            {
                Console.Write("Enter second number: ");
                input2 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Sub2;
            }
            return input1 - input2;
        }
        public double Multiplication()
        {
        Mul1:
            try
            {

                Console.Write("Enter first number: ");
                input1 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Mul1;
            }
        Mul2:
            try
            {
                Console.Write("Enter second number:");
                input2 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Mul2;
            }
            return input1 * input2;
        }
        public double Division()
        {
        Div1:
            try
            {

                Console.Write("Enter first number: ");
                input1 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Div1;
            }
        Div2:
            try
            {
                Console.Write("Enter second number: ");
                input2 = double.Parse(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.Write("Invalid Number!!");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                goto Div2;
            }
            return input1 / input2;
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}

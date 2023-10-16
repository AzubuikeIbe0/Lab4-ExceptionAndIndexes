using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab4_ExceptionAndIndexes
{

    public static class Calculator
    {
        public static double Divide(double lhs, double rhs)
        {
            if(rhs == 0)
            {
                throw new ArgumentException("Error: attempt to divide by 0");
            }
            else
            { 
                return lhs / rhs;
            }
        }
    }



    static class Test
    {
        static void Main(string[] args)
        {
            try
            {
                double num1 = 0, num2 = 0;
                // take inputs

                bool valid = true;
                

                    do
                    {
                        try
                        {
                            Console.Write("Enter 1st number: ");
                            num1=Double.Parse(Console.ReadLine());
                            valid = true;
                        }
                        catch (FormatException)
                        {
                            valid = false;
                        }
                        catch (OverflowException)
                        {
                            valid = false;
                        }
                    }
                    while (!valid);

                    do
                    {
                        try
                        {
                            Console.Write("Enter 2nd number: ");
                            num2 = Double.Parse(Console.ReadLine());
                            valid = true;
                        }
                        catch (Exception) // Catches both Format and Overflow
                        {
                            valid = false;
                        }
                    }
                    while (!valid);
                }
                catch (ArgumentException e1)
                {
                    Console.WriteLine(e1.Message);
                }

            }
        }

    }


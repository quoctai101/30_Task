using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _30_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 30 Tasks!");
            Console.WriteLine("Please choose one in a list below:");
            Console.WriteLine("1.  Factorial Number");
            Console.WriteLine("2.  Factorial Number (Detailed)");
            Console.WriteLine("3.  Divisor of an integer");
            Console.WriteLine("4.  Divide 10000d");
            Console.WriteLine("5.  Love & Hate");
            Console.WriteLine("6.  Optimize Divide 10000d");
            Console.WriteLine("7.  Check Prime");
            Console.WriteLine("8.  Check Prime (detailed)");
            Console.WriteLine("9.  Perfect Number");
            Console.WriteLine("10. Check number of integer");
            Console.WriteLine("11. Show number of integer");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FactorialNumber();
                    break;
                case 2:
                    detailFactorialNumber();
                    break;
                case 3:
                    divisorInteger();
                    break;
                case 4:
                    divide();
                    break;
                case 5:
                    lovehate();
                    break;
                case 6:
                    divideOptimized();
                    break;
                case 7:
                    checkPrime();
                    break;
                case 8:
                    checkPrimedetailed();
                    break;
                case 9:
                    perfectNumber();
                    break;
                case 10:
                    checkNumber();
                    break;
                case 11:
                    showNumber();
                    break;
                default:
                    Console.WriteLine("Updating...");
                    break;
            }
            Console.ReadKey();
        }
        static void FactorialNumber()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                BigInteger Fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    Fact *= i;
                }
                Console.WriteLine("{0}! = {1}", n, Fact);
            }
            else
            {
                Console.WriteLine("There's no factorial number!");
            }
        }
        static void detailFactorialNumber()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                BigInteger Fact = 1;
                Console.Write("{0}! = ", n);
                for (int i = 1; i <= n; i++)
                {
                    if (i != n) Console.Write("{0}*", i);
                    else Console.Write("{0} = ", i);
                    Fact *= i;
                }
                Console.Write("{0}", Fact);
            }
            else
            {
                Console.WriteLine("There's no factorial number!");
            }
        }
        static void divisorInteger()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.Write("Divisors of {0}: ", n);
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0) Console.Write(i + " ");
                }
                Console.WriteLine(n);
            }
            else Console.WriteLine("There's no divisor!");
        }
        static void divide()
        {
            int count = 0;
            for (int i = 0; i <= 10000 / 100; i++)
                for (int j = 0; j <= (10000 - 100 * i) / 200; j++)
                    for (int k = 0; k <= (10000 - 100 * i - 200 * j) / 500; k++)
                        if ((100 * i + 200 * j + 500 * k) == 10000)
                        {
                            count++;
                            Console.WriteLine("Phuong an {0}:\t {1} to 100d, {2} to 200d, {3} to 500d", count, i, j, k);
                        }
        }
        static void lovehate()
        {
            for (int i = 0; i <= 100; i++)
                for (int j = 0; j <= 100; j++)
                    if ((i + j == 100) && (((float)i / 3 + (float)j / 10) == 17))
                    {
                        Console.WriteLine("Co {0} nguoi thuong va {1} nguoi ghet", i, j);
                        break;
                    }
        }
        static void divideOptimized()
        {
            int[] numberPaper = { 0, 0, 0 };
            int[] value = { 500, 200, 100 };
            int mod = 10000;
            for (int i = 0; i < 3; i++)
            {
                numberPaper[i] = mod / value[i];
                mod -= value[i] * numberPaper[i];
            }
            for (int i = 1; i < 3; i++)
            {
                if(numberPaper[i] == 0)
                {
                    numberPaper[i - 1]--;
                    mod += value[i - 1];
                    for (int j = i; j < 3; j++)
                    {
                        numberPaper[j] = mod / value[j];
                        mod -= value[j] * numberPaper[j];
                    }
                }
            }
            Console.WriteLine("Phuong an toi uu: {0} to 100d, {1} to 200d, {2} to 500d",numberPaper[2],numberPaper[1],numberPaper[0]);
        }
        static void checkPrime()
        {
            Console.Write("Enter N(>1): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("Invalid input!");
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime == true) Console.WriteLine("N is prime!");
                else Console.WriteLine("N isn't prime");
            }
        }
        static void checkPrimedetailed()
        {
            Console.Write("Enter N(>1): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("Invalid input!");
            else
            {
                int tmp = 0;
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                    {
                        tmp = i;
                        isPrime = false;
                        break;
                    }
                if (isPrime == true) Console.WriteLine("N is prime!");
                else Console.WriteLine("N isn't prime because {0} * {1} = {2}",tmp,n/tmp,n);
            }
        }
        static void perfectNumber()
        {
            Console.Write("Enter N(>1): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("Invalid input!");
            else
            {
                int sum = 1;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                    {
                        if (i == Math.Sqrt(n)) sum += i;
                        else sum += i + n / i;
                        break;
                    }
                if (sum == n) Console.WriteLine(n + " is perfect number!");
                else Console.WriteLine(n + " isn't perfect number!");
            }
        }
        static void checkNumber()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("{0} has ", n);
                int count = 0;
                if (n == 0) count = 1;
                else
                {
                    while (n!=0)
                    {
                        count++;
                        n = n / 10;
                    }
                }
                Console.WriteLine("{0} numbers",count);
            }
        }
        static void showNumber()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("{0} has ", n);
                if (n == 0) Console.WriteLine(n);
                else 
                  while(n!=0)
                    {
                        Console.Write(n % 10 + " ");
                        n = n / 10;
                        if (n == 0) Console.WriteLine();
                    }
            }
        }
    }
}

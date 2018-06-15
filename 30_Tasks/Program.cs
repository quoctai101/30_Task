using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _30_Tasks
{
    class Program
    {
        //Dưới đây là một số func hỗ trợ
        static bool isPerfectNumber(int x)
        {
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                {
                    if (i == Math.Sqrt(x)) sum += i;
                    else sum += i + x / i;
                }
            if (sum == x) return true;
            else return false;
        }
        //Main, chủ yếu là menu và gọi các func khác
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
            Console.WriteLine("9.  Find Prime smaller");
            Console.WriteLine("10. Check Perfect Square");
            Console.WriteLine("11. Perfect Number");
            Console.WriteLine("12. Check number of integer");
            Console.WriteLine("13. Show number of integer");
            Console.WriteLine("14. Sum number of integer");
            Console.WriteLine("15. Max number of integer");
            Console.WriteLine("16. Check Amstrong");
            Console.WriteLine("17. GCD LCM");
            Console.WriteLine("18. Spell number");
            Console.WriteLine("19. Take a number from right");
            Console.WriteLine("20. Take a number from left");
            Console.WriteLine("21. Find perfect numbers lower than 9000");
            Console.WriteLine("22. Sum cubed equals to number (from 100 to 999)");
            Console.WriteLine("23. Show multiplication table");
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
                    findPrime();
                    break;
                case 10:
                    isPerfectSquare();
                    break;
                case 11:
                    perfectNumber();
                    break;
                case 12:
                    checkNumber();
                    break;
                case 13:
                    showNumber();
                    break;
                case 14:
                    sumNumber();
                    break;
                case 15:
                    maxNumber();
                    break;
                case 16:
                    isAmstrong();
                    break;
                case 17:
                    findGCDLCM();
                    break;
                case 18:
                    spellNumber();
                    break;
                case 19:
                    takeNumberRight();
                    break;
                case 20:
                    takeNumberLeft();
                    break;
                case 21:
                    perfectNumber9000();
                    break;
                case 22:
                    sumCubed();
                    break;
                case 23:
                    showMultiplyTable();
                    break;
                default:
                    Console.WriteLine("Updating...");
                    break;
            }
            Console.ReadKey();
        }
        //Các func cho từng bài toán
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
        static void findPrime()
        {
            Console.Write("Enter N(>1): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Prime numbers smaller than {0}: ",n);
                bool[] isPrime = new bool[n+1];
                isPrime[0] = false;
                isPrime[1] = false;
                for(int i = 2; i<=n; i++)
                {
                    isPrime[i] = true;
                }
                for(int i=2; i*i <= n; i++)
                {
                    if (isPrime[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                            isPrime[j] = false;
                    }
                }
                for(int i=2; i <= n; i++)
                {
                    if (isPrime[i])
                        Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
        static void isPerfectSquare()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                if ((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n)
                    Console.WriteLine("N is Perfect Square");
                else Console.WriteLine("N isn't Perfect Square");
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
        static void sumNumber()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Sum number of {0} is ", n);
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine("{0}", sum);
            }
        }
        static void maxNumber()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Max number of {0} is ",n);
                int max = 0;
                while (n != 0)
                {
                    if (n % 10 > max) max = n % 10;
                    n /= 10;
                }
                Console.WriteLine(max);
            }
        }
        static void isAmstrong()
        {
            Console.Write("Enter N(>=1): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1) Console.WriteLine("Invalid input!");
            else
            {
                byte length = (byte) n.ToString().Length;
                int tmp = n;
                int sum = 0;
                bool isOver = false;
                while (tmp!= 0)
                {
                    sum += (int)Math.Pow(tmp % 10, length);
                    if (sum > n)
                    {
                        isOver = true;
                        break;
                    }
                    tmp /= 10;
                }
                if(isOver == false)
                {
                    if (sum == n) Console.WriteLine("N is Amstrong Number");
                    else
                    {
                        Console.WriteLine("N isn't Amstrong Number");
                    }
                }
                else Console.WriteLine("N isn't Amstrong Number");
            }
        }
        static void findGCDLCM()
        {
            Console.Write("Enter 2 number (>0): ");
            string[] Input = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(Input[0]);
            int b = Convert.ToInt32(Input[1]);
            if ((a <= 0) || (b <= 0)) Console.WriteLine("Invalid value!");
            else
            {
                int x = a, y = b;
                while (y!=0)
                {
                    int tmp = x % y;
                    x = y;
                    y = tmp;
                }
                Console.WriteLine("GCD, LCM of {0} and {1} are: {2}, {3}",a,b,x,a*b/x);
            }
        }
        static void spellNumber()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Doc la:");
                if (n == 0) Console.WriteLine("khong");
                else
                {
                    string[] arrNum = new string[] { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
                    string result = "";
                    while (n != 0)
                    {
                        result = arrNum[n % 10] +" "+ result;
                        n /= 10;
                    }
                    Console.WriteLine(result);
                }
            }
        }
        static void takeNumberRight()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Which number you want to take (from right): ");
                int Pos = Convert.ToInt32(Console.ReadLine());
                if (Pos > n.ToString().Length) Console.WriteLine("Invalid position");
                else
                    Console.WriteLine("Number you want is: "+ (n.ToString())[n.ToString().Length-Pos]);
            }
        }
        static void takeNumberLeft()
        {
            Console.Write("Enter N(>=0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid input!");
            else
            {
                Console.Write("Which number you want to take (from right): ");
                int Pos = Convert.ToInt32(Console.ReadLine());
                if (Pos > n.ToString().Length) Console.WriteLine("Invalid position");
                else
                    Console.WriteLine("Number you want is: " + (n.ToString())[Pos-1]);
            }
        }
        static void perfectNumber9000()
        {
            Console.Write("Perfect numbers lower than 9000: ");
            for(int i = 6; i <= 9000; i++)
            {
                if (isPerfectNumber(i)) Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void sumCubed()
        {
            for (int i = 153; i <= 999; i++)
            {
                int tmp = i;
                int sum = 0;
                bool isOver = false;
                while (tmp != 0)
                {
                    sum += (int)Math.Pow(tmp % 10, 3);
                    if (sum > i)
                    {
                        isOver = true;
                        break;
                    }
                    tmp /= 10;
                }
                if (isOver == false)
                    if (sum == i) Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void showMultiplyTable()
        {
            for (int i = 1; i <= 9; i++)
                for (int j = 5; j <= 9; j++)
                {
                    if (i == 1) Console.Write(" {0} * {1} =  {2} |",j,i,i*j);
                    else Console.Write(" {0} * {1} = {2} |", j, i, i * j);
                    if (j == 9) Console.WriteLine();
                }
        }
    }
}

using System;


namespace MyProject1
{
    public class ProgramsExample
    {

        public static void Main(string[] args) 
        {
            int programs;
            Console.WriteLine("Enter the number which program wants to exicute first:");
            programs = Convert.ToInt32(Console.ReadLine());

            switch (programs)
            {
                case 1:
                    Prime();
                    break;
                case 2:
                    Palindrome();
                    break;
                case 3:
                    DecimalToBinary();
                    break;
                case 4:
                    Sum();
                    break;
                case 5:
                    FibonacciWithoutRecursion();
                    
                    break;
                case 6:
                    FibonacciWithRecursion();
                    break;
                default:
                    Console.WriteLine("Happy Day!!!!!!!!!");
                    break;
            }


        }
        static void Prime()
        {
            int n, i, flag = 0;
            Console.Write("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i =2 ; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }

        static void Palindrome()
        {

            int n1, r, sum = 0, temp;
            Console.Write("Enter the value: ");
            n1 = int.Parse(Console.ReadLine());
            temp = n1;
            while (n1 > 0)
            {
                r = n1 % 10;
                sum = (sum * 10) + r;
                n1 = n1 / 10;
            }
            if (temp == sum)
            {
                Console.Write("Number is Palindrome.");
            }
            else
            {
                Console.Write("Number is not Palindrome");
            }
        }


        static void DecimalToBinary()
        {
            int decVal;
            int val;
            string a = "";
            Console.WriteLine("enter the decimal value:");
            decVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decimal: {0}", decVal);
            while (decVal >= 1)
            {
                val = decVal / 2;
                a += (decVal % 2).ToString();
                decVal = val;
            }
            string binValue = "";
            for (int k = a.Length - 1; k >= 0; k--)
            {
                binValue = binValue + a[k];
            }
            Console.WriteLine("Binary: {0}", binValue);
            Console.Read();
        }


        static void Sum()
        {
            int n2, sum1 = 0, m1;
            Console.Write("Enter a number: ");
            n2 = int.Parse(Console.ReadLine());
            while (n2 > 0)
            {
                m1 = n2 % 10;
                sum1 = sum1 + m1;
                n2 = n2 / 10;
            }
            Console.Write("Sum is= " + sum1);
        }

        static void FibonacciWithoutRecursion() 
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number of element:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);//printing 0 and 1    
            for (i = 2; i < number;i++)//loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
          
        }



        static void FibonacciWithRecursion()
        {
            int fibonacci(int j)
            {
                if (j == 0) return 0;
                else if (j == 1) return 1;
                else return (fibonacci(j - 1) + fibonacci(j - 2));
            }


            int n, i;
            Console.WriteLine("Enter the number of element you want in series:");
            n = int.Parse(Console.ReadLine());
            Console.Write("fibonacci series is:");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + fibonacci(i));
            }
        }
        }
    }
    

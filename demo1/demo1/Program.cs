using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class program1
    {
        public static void Main(string[] args)
        {
            int programs;
            Console.WriteLine("Enter the number which program wants to exicute first:");
            programs = Convert.ToInt32(Console.ReadLine());

            switch (programs)
            {
                case 1:
                    Program1();
                    break;
                case 2:
                    Program2();
                    break;
                case 3:
                    Program3();
                    break;
                case 4:
                    Anagram();
                    break;
                default:
                    Console.WriteLine("Happy Day!!!!!!!!!");
                    break;
            }
    }
        static void Program1()
        {
            string data1;
            int count = 0;
            Console.WriteLine("Enter the data:");
            data1 = Console.ReadLine();
            foreach (char a in data1)
            {
                count = 0;
                foreach (char b in data1)
                {
                    if (a == b)
                    {
                        count++;
                    }
                }
                Console.WriteLine(a + "_" + count);
            }
        }
        static void Program2()
        {
            string data1 = string.Empty, data2 = string.Empty;
            Console.Write("Enter the string : ");
            data1 = Console.ReadLine();
            for (int i = data1.Length - 1; i >= 0; i--)
            {
                data2 += data1[i];
            }
            Console.WriteLine("The reverse string is {0}", data2);
            Console.ReadLine();
        }
        static void Program3()
        {
             void find_Substring(string data, int n)
             {
                for (int l = 1; l <= n; l++)
                {
                    for (int i = 0; i <= n - l; i++)
                    {
                        int q = i + l - 1;
                        for (int j = i; j <= q; j++)
                            Console.Write(data[j]);
                        Console.WriteLine();
                    }
                }
             }
                string data = Console.ReadLine();
                find_Substring(data, data.Length);
        }
         static void Anagram()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            };
            if (val1 == val2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
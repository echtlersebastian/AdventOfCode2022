using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode._2023
{
    public static class Tag1
    {
        public static void Run()
        {
            string[] input = Input2023.Tag1.Split("\r\n");

            int result = 0;
            foreach (string s in input)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int k;
                    if(Int32.TryParse(s[i].ToString(), out k))
                    {
                        result = result + (k * 10);
                        break;
                    };
                }
                for (int i = s.Length -1; i >= 0; i--)
                {
                    int k;
                    if (Int32.TryParse(s[i].ToString(), out k))
                    {
                        result += k ;

                        break;
                    };
                }
            }
            Console.WriteLine(result);

        }
        public static void RunPart2()
        {
            string[] input = Input2023.Tag1.Split("\r\n");

            int result = 0;
            foreach (string s in input)
            {


                string a = "";
                for(int i = 0;i < s.Length; i++)
                {
                    a += s[i];
                    a = a.Replace("one", "1");
                    a = a.Replace("two", "2");
                    a = a.Replace("three", "3");
                    a = a.Replace("four", "4");
                    a = a.Replace("five", "5");
                    a = a.Replace("six", "6");
                    a = a.Replace("seven", "7");
                    a = a.Replace("eight", "8");
                    a = a.Replace("nine", "9");


                }
                string b = "";
                for (int i = s.Length -1; i >= 0; i--)
                {
                    b = s[i] + b;
                    b = b.Replace("one", "1");
                    b = b.Replace("two", "2");
                    b = b.Replace("three", "3");
                    b = b.Replace("four", "4");
                    b = b.Replace("five", "5");
                    b = b.Replace("six", "6");
                    b = b.Replace("seven", "7");
                    b = b.Replace("eight", "8");
                    b = b.Replace("nine", "9");


                }
                if(a != b)
                {
                    Console.WriteLine(s);
                }

                int curr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    int k;
                    if (Int32.TryParse(a[i].ToString(), out k))
                    {
                        result = result + (k * 10);
                        curr = curr + (k * 10);
                        break;
                    };
                }
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    int k;
                    if (Int32.TryParse(b[i].ToString(), out k))
                    {
                        result += k;

                        curr += k;
                        break;
                    };
                }
            }
            Console.WriteLine(result);

        }
    }
}
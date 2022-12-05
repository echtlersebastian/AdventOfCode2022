using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    static class Day3
    {

        public static void Run()
        {
            List<char> result = new List<char>();


            foreach (string s in Inputs.Day3.Split("\r\n"))
            {

                string first = s.Substring(0, s.Length / 2);
                string secound = s.Substring(s.Length / 2, s.Length / 2);

                bool gefunden = false;
                foreach (char c in first)
                {
                    foreach (char st in secound)
                    {
                        if (c == st && gefunden == false)
                        {
                            gefunden = true;
                            result.Add(st);
                        }
                    }
                }

            // TODO: This Does not work, but it should... Check this out!

            //string common = string.Concat(first.TakeWhile((c, i) => c == secound[i]));
            //    if (common.Length > 0)
            //    {
            //        result.Add(common[0]);
            //    }

            }
            int intResult = 0;
            foreach (char c in result)
            {
                intResult += getValue(c);
            }
            Console.WriteLine("Result of Day 3 Part 1: " + intResult);
        }
        private static int getValue(char c)
        {
            if ((int)c >= 97)
            {
                return (int)c - 96;
            }
            else
            {
                return (int)c - 38;
            }
        }
    }
}

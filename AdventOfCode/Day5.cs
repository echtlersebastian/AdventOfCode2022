using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day5
    {
        List<char>[] chars = new List<char>[9];

        public Day5()
        {
            chars[0] = new List<char> { 'P', 'L', 'M', 'N', 'W', 'V', 'B', 'H' };
            chars[1] = new List<char> { 'H', 'Q', 'M' };
            chars[2] = new List<char> { 'L', 'M', 'Q', 'F', 'G', 'B', 'D', 'N' };
            chars[3] = new List<char> { 'G', 'W', 'M', 'Q', 'F', 'T', 'Z' };
            chars[4] = new List<char> { 'P', 'H', 'T', 'M' };
            chars[5] = new List<char> { 'T', 'G', 'H', 'D', 'J', 'M', 'B', 'C' };
            chars[6] = new List<char> { 'R', 'V', 'F', 'B', 'N', 'M' };
            chars[7] = new List<char> { 'S', 'G', 'R', 'M', 'H', 'L', 'P' };
            chars[8] = new List<char> { 'N', 'C', 'B', 'D', 'P' };

            chars[0] = Enumerable.Reverse(chars[0]).ToList();
            chars[1] = Enumerable.Reverse(chars[1]).ToList();
            chars[2] = Enumerable.Reverse(chars[2]).ToList();
            chars[3] = Enumerable.Reverse(chars[3]).ToList();
            chars[4] = Enumerable.Reverse(chars[4]).ToList();
            chars[5] = Enumerable.Reverse(chars[5]).ToList();
            chars[6] = Enumerable.Reverse(chars[6]).ToList();
            chars[7] = Enumerable.Reverse(chars[7]).ToList();
            chars[8] = Enumerable.Reverse(chars[8]).ToList();

        }


        public void runPart2()
        {
            foreach (string s in Inputs.Day5.Split("\r\n"))
            {
                string[] words = s.Split(' ');

                for (int i = Int32.Parse(words[1]) - 1; i >= 0; i--)
                {
                    int from = Int32.Parse(words[3]) - 1;
                    int to = Int32.Parse(words[5]) - 1;

                    chars[to].Add(chars[from][chars[from].Count() - i - 1]);

                    chars[from].RemoveAt(chars[from].Count() - i - 1);
                }


            }
            string result = "";
            foreach (List<char> lc in chars)
            {
                result += lc[lc.Count() - 1].ToString();
            }
            Console.WriteLine("Result of Day 5 Part 2: " + result);
        }
        public void runPart1()
        {

            foreach (string s in Inputs.Day5.Split("\r\n"))
            {
                string[] words = s.Split(' ');

                for (int i = 0; i < Int32.Parse(words[1]); i++)
                {
                    int from = Int32.Parse(words[3]) - 1;
                    int to = Int32.Parse(words[5]) - 1;

                    chars[to].Add(chars[from][chars[from].Count() - 1]);

                    chars[from].RemoveAt(chars[from].Count()- 1);
                }


            }
            string result = "";
            foreach (List<char> lc in chars)
            {
                result += lc[lc.Count() -1].ToString();
            }
                Console.WriteLine("Result of Day 5 Part 1: " + result);
        }
    }

}
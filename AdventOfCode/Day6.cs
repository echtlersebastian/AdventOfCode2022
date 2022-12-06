using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
   public static class Day6
    {
        public static char[] input = Inputs.Day6.ToCharArray();
        public static char[] buffer = new char[4];
        public static char[] messageBuffer = new char[14];

        public static void RunPart1()
        {
            for(int i = 3; i < input.Length; i++)
            {
                buffer[0] = input[i-3];
                buffer[1] = input[i-2];
                buffer[2] = input[i-1];
                buffer[3] = input[i];

                if (checkBuffer())
                {
                    Console.WriteLine("Result of Day 6 Part 1: " + (i +1));
                    return;
                }
            } 
        }

        public static void RunPart2()
        {
            for (int i = 13; i < input.Length; i++)
            {
                for(int ii = 0; ii < 14; ii++)
                {
                    messageBuffer[ii] = input[i - ii];
                }

                if (checkMessageBuffer())
                {
                    Console.WriteLine("Result of Day 6 Part 2: " + (i+1));
                    return;
                }
            }

        }

        private static bool checkMessageBuffer()
        {
            char[] s = messageBuffer.Distinct().ToArray();
            if (s.Count() == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkBuffer()
        {
            char[] s = buffer.Distinct().ToArray();
            if(s.Count() == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

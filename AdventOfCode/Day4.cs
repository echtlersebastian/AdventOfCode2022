using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day4
    {
        // I struggeled a lot, thats why this is a mess!..
        public static void Run()
        {
            string[] ins = Inputs.Day4.Split("\r\n");

            List<Pair> allPairs = new List<Pair>();

            foreach (string s in ins)
            {
                string[] sa = s.Split(',');

                int w1 = 0;
                int w2 = 0;
                int w3 = 0;
                int w4 = 0;

                string[] sa3 = sa[0].Split('-');

                int low = ReturnLower(Int32.Parse(sa3[0]), Int32.Parse(sa3[1]));
                int high = ReturnBigger(Int32.Parse(sa3[0]), Int32.Parse(sa3[1]));
                w1 = low;
                w2 = high;

                string[] sa4 = sa[1].Split('-');

                int low1 = ReturnLower(Int32.Parse(sa4[0]), Int32.Parse(sa4[1]));
                int high1 = ReturnBigger(Int32.Parse(sa4[0]), Int32.Parse(sa4[1]));

                w3 = low1;
                w4 = high1;

                Zuweisung a = new Zuweisung(w1, w2);
                Zuweisung b = new Zuweisung(w3, w4);

                Pair ab = new Pair(a, b);
                allPairs.Add(ab);

            }

            var r = from p in allPairs
                    where p.conatains == true
                    select p;

            Console.WriteLine("Result of Day 4 Part 1: " + r.Count());


            var r1 = from p in allPairs
                    where p.overlaps == true
                    select p;

            Console.WriteLine("Result of Day 4 Part 2: " + r1.Count());


        }
        public static int ReturnLower(int a, int b)
        {
            if (b > a)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int ReturnBigger(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }

    public class Pair
    {
        public Zuweisung z1;
        public Zuweisung z2;

        List<int> allFrom1 = new List<int>();

        public bool conatains;
        public bool overlaps = false;

        public Pair(Zuweisung zuw1, Zuweisung zuw2)
        {
            z1 = zuw1;
            z2 = zuw2;


            for (int i = z1.start; i <= z1.end; i++)
            {
                allFrom1.Add(i);
            }



            calculateContains();
            calculateOverlap();
        }

        private void calculateOverlap()
        {
            for (int i = z2.start; i <= z2.end; i++)
            {
                if (allFrom1.Contains(i))
                {
                    overlaps = true;
                }

            }

        }

        private void calculateContains()
        {
            //2 - 8
            //3 - 7
            if ((z1.start >= z2.start && z1.end <= z2.end) ||
                z2.start >= z1.start && z2.end <= z1.end)
            {
                conatains = true;
            }
            else
            {
                conatains = false;
            }
        }
    }


    public class Zuweisung
    {
        public int start;
        public int end;
        public Zuweisung(int s, int e)
        {
            start = s;
            end = e;
        }

    }


}

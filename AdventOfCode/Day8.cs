using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day8
    {

        static string[] input = Inputs.Day8.Split("\r\n");

        public static List<Tree> allTrees = new List<Tree>();


        public static void Run()
        {

            for (int y = 0; y < input.Length; y++)
            {
                string line = input[y];

                for (int x = 0; x < input[y].Length; x++)
                {
                    Tree t = new Tree();
                    var chararr = input[y].ToCharArray();
                    t.height = Int32.Parse(chararr[x].ToString());
                    t.X = x;
                    allTrees.Add(t);
                    t.Y = y;
                }
            }


            foreach (Tree t in allTrees)
            {
                t.visible = checkvisibility(t);

            }
            foreach (Tree t in allTrees)
            {

                int left = checkScenicScoreLeft(t);
                int right = checkScenicScoreRight(t);
                int up = checkScenicScoreUp(t);
                int down = checkScenicScoreDown(t);

                t.scenicScore = left * right * up * down;
            }

            var result = from b in allTrees
                         where b.visible == true
                         select b;

            Console.WriteLine("Result of Day 8 Part 1: " + result.Count());



            var resultPart2 = allTrees.OrderByDescending(t => t.scenicScore).ToList();
            Console.WriteLine("Result of Day 8 Part 2: " + resultPart2[0].scenicScore);

        }

        private static int checkScenicScoreLeft(Tree t)
        {
            var a = from b in allTrees
                    where b.Y == t.Y
                    where b.X < t.X
                    select b;
            var orderedLeft = a.OrderByDescending(x => x.X).ToArray();
            int j = 0;
            if (orderedLeft.Length == 0) { return 0; }
            for (int i = 0; i <= orderedLeft.Count() - 1; i++)
            {
                if (orderedLeft[i].height >= t.height)
                {
                    return i + 1;
                }
                j = i;
            }
            return j +1;
        }

        private static int checkScenicScoreRight(Tree t)
        {
            var a = from b in allTrees
                    where b.Y == t.Y
                    where b.X > t.X
                    select b;
            var orderedLeft = a.OrderBy(x => x.X).ToArray();
            int j = 0;
            if (orderedLeft.Length == 0) { return 0; }
            for (int i = 0; i <= orderedLeft.Count() - 1; i++)
            {
                if (orderedLeft[i].height >= t.height)
                {
                    return i + 1;
                }
                j = i;
            }
            return j +1;
        }

        private static int checkScenicScoreUp(Tree t)
        {
            var a = from b in allTrees
                    where b.X == t.X
                    where b.Y < t.Y
                    select b;
            var orderedLeft = a.OrderByDescending(x => x.Y).ToArray();
            int j = 0;
            if (orderedLeft.Length == 0) { return 0; }
            for (int i = 0; i <= orderedLeft.Count() - 1; i++)
            {
                if (orderedLeft[i].height >= t.height)
                {
                    return i + 1;
                }
                j = i;
            }
            return j + 1;
        }

        private static int checkScenicScoreDown(Tree t)
        {
            var a = from b in allTrees
                    where b.X == t.X
                    where b.Y > t.Y

                    select b;
            var orderedLeft = a.OrderBy(x => x.Y).ToArray();
            int j = 0;
            if (orderedLeft.Length == 0) { return 0; }
            for (int i = 0; i <= orderedLeft.Count() - 1; i++)
            {
                if (orderedLeft[i].height >= t.height)
                {
                    return i + 1;
                }
                j = i;
            }
            return j +1;
        }

        private static bool checkvisibility(Tree t)
        {
            var alleBäumedieLinksSind = from b in allTrees
                                        where b.Y == t.Y
                                        where b.X < t.X
                                        where b.height >= t.height
                                        select b;

            var alleBäumedieRechtsSind = from b in allTrees
                                         where b.Y == t.Y
                                         where b.X > t.X
                                         where b.height >= t.height
                                         select b;

            var alleBäumedieObenSind = from b in allTrees
                                       where b.X == t.X
                                       where b.Y > t.Y
                                       where b.height >= t.height
                                       select b;

            var alleBäumedieUntenSind = from b in allTrees
                                        where b.X == t.X
                                        where b.Y < t.Y
                                        where b.height >= t.height
                                        select b;

            if ((!alleBäumedieLinksSind.Any()) ||
               (!alleBäumedieRechtsSind.Any()) ||
                (!alleBäumedieObenSind.Any()) ||
                (!alleBäumedieUntenSind.Any()))
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }

    public class Tree
    {
        public int height;
        public bool visible;
        public int scenicScore;

        public int X;
        public int Y;

    }
}

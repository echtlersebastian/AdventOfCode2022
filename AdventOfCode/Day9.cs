using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day9
    {

        static string[] input = Inputs.Day9.Split("\r\n");

        public static void Run()
        {
            Snake snake = new Snake(10);

            foreach (string s in input)
            {
                int length = Int32.Parse(s.Substring(2, s.Length - 2));

                switch (s.First())
                {
                    case 'L':
                        for (int i = 0; i < length; i++)
                        {
                            snake.Knots[0].X -= 1;
                            snake.calculateTail();
                            snake.addCurrentPositionToList(snake.Knots.Last());
                        }
                        break;
                    case 'R':
                        for (int i = 0; i < length; i++)
                        {
                            snake.Knots[0].X += 1;
                            snake.calculateTail();
                            snake.addCurrentPositionToList(snake.Knots.Last());
                        }
                        break;
                    case 'U':
                        for (int i = 0; i < length; i++)
                        {
                            snake.Knots[0].Y += 1;
                            snake.calculateTail();
                            snake.addCurrentPositionToList(snake.Knots.Last());
                        }
                        break;
                    case 'D':
                        for (int i = 0; i < length; i++)
                        {
                            snake.Knots[0].Y -= 1;
                            snake.calculateTail();
                            snake.addCurrentPositionToList(snake.Knots.Last());
                        }
                        break;

                }

            }


            Console.WriteLine("Result of Day 9 Part 1: " + snake.ReachedPositions.Count());

        }


        public class Snake
        {
            public List<Position> ReachedPositions;
            public Position[] Knots;

            public Snake(int numberOfKnots)
            {

                ReachedPositions = new List<Position>();


                Knots = new Position[numberOfKnots];

                for (int i = 0; i < numberOfKnots; i++)
                {
                    Knots[i] = new Position();
                }
            }

            internal void addCurrentPositionToList(Position newPos)
            {
                var a = from p in ReachedPositions
                        where p.X == newPos.X
                        where p.Y == newPos.Y
                        select p;

                if (a.Count() == 0)
                {
                    ReachedPositions.Add(new Position(newPos.X, newPos.Y));
                }
            }

            internal void calculateTail()
            {
                for(int i = 0; i<Knots.Length -1; i++)
                {
                    calculatenewPosition(Knots[i], Knots[i + 1]);
                }
            }
            internal void calculatenewPosition(Position head, Position tail)
            {


                //wenn Movement linear
                if (tail.X == head.X)
                {
                    if (head.Y > tail.Y + 1)
                    {
                        tail.Y += 1;
                        return;
                    }
                    if (head.Y < tail.Y - 1)
                    {
                        tail.Y -= 1;
                        return;
                    }
                }
                if (tail.Y == head.Y)
                {
                    if (head.X > tail.X + 1)
                    {
                        tail.X += 1;
                        return;
                    }
                    if (head.X < tail.X - 1)
                    {
                        tail.X -= 1;
                        return;
                    }
                }


                //movement schräg:
                //checken ob ich direkt diagonal bin, dann auf den alten HEad setzten.
                if (System.Math.Abs(tail.X - head.X) == 1 && System.Math.Abs(tail.Y - head.Y) == 1)
                {
                    return;
                }
                if (head.Y - tail.Y == 2)
                {
                    tail.X = head.X;
                    tail.Y++;
                    return;
                }
                if (tail.Y - head.Y == 2)
                {
                    tail.X = head.X;
                    tail.Y--;
                    return;
                }
                if (head.X - tail.X == 2)
                {
                    tail.Y = head.Y;
                    tail.X++;
                    return;
                }
                if (tail.X - head.X == 2)
                {
                    tail.Y = head.Y;
                    tail.X--;
                    return;
                }
            }



        }
    }

    public class Position
    {
        public int X;
        public int Y;

        public Position(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }


}

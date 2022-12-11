using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day10
    {

        static string[] input = Inputs.Day10.Split("\r\n");
        static public List<Signal> allSignals = new List<Signal>();

        public static void Run()
        {
            int cycle = 1;
            int x = 1;
            string result = "";
            int cycleSubs = 1; // because cycle 10 prints the Pixel #9

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "noop")
                {
                    allSignals.Add(new Signal(cycle, x));
                    if (cycle - cycleSubs == x || cycle - cycleSubs == x - 1 || cycle - cycleSubs == x + 1)
                    {
                        result += "██";
                    }
                    else
                    {
                        result += "░░";
                    }
                    if (cycle % 40 == 0)
                    {
                        result += "\r\n";
                        cycleSubs += 40;
                    }


                    cycle++;
                }
                else
                {
                    allSignals.Add(new Signal(cycle, x));

                    if (cycle - cycleSubs == x || cycle - cycleSubs == x - 1 || cycle - cycleSubs == x + 1)
                    {
                        result += "██";
                    }
                    else
                    {
                        result += "░░";
                    }
                    if (cycle % 40 == 0)
                    {
                        result += "\r\n";
                        cycleSubs += 40;
                    }
                    cycle++;
                    allSignals.Add(new Signal(cycle, x));
                    if (cycle - cycleSubs == x || cycle - cycleSubs == x - 1 || cycle - cycleSubs == x + 1)
                    {
                        result += "██";
                    }
                    else
                    {
                        result += "░░";
                    }
                    if (cycle % 40 == 0)
                    {
                        result += "\r\n";
                        cycleSubs += 40;
                    }
                    cycle++;
                    int toAdd = Int32.Parse(input[i].Split(' ')[1]);
                    x += toAdd;
                }

            }

            int totalSignalStrength = allSignals[19].signalStrength;
            totalSignalStrength += allSignals[59].signalStrength;
            totalSignalStrength += allSignals[99].signalStrength;
            totalSignalStrength += allSignals[139].signalStrength;
            totalSignalStrength += allSignals[179].signalStrength;
            totalSignalStrength += allSignals[219].signalStrength;

            Console.WriteLine("Result of Day 10 Part 1: " + totalSignalStrength);

            Console.WriteLine("Result of Day 10 Part 2: ");
            Console.WriteLine(result);

        }

    }
    public class Signal
    {
        int cycle;
        int x;
        public int signalStrength;


        public Signal(int c, int x)
        {
            this.cycle = c;
            this.x = x;
            signalStrength = c * x;
        }

    }
}

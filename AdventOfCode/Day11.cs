using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static AdventOfCode.Day9;

namespace AdventOfCode
{
    public static class Day11
    {
        public static List<Monkey> Monkeys = new List<Monkey>();
        public const int goldenNumber = 9699690;
        //public const int goldenNumber = 96577;
       
        public static void Run()
        {
            Monkeys.Add(new Monkey0(new Int64[] { 65, 78 }, 5, 2, 3));
            Monkeys.Add(new Monkey1(new Int64[] { 54, 78, 86, 79, 73, 64, 85, 88 }, 11, 4, 7));
            Monkeys.Add(new Monkey2(new Int64[] { 69, 97, 77, 88, 87 }, 2, 5, 3));
            Monkeys.Add(new Monkey3(new Int64[] { 99 }, 13, 1, 5));
            Monkeys.Add(new Monkey4(new Int64[] { 60, 57, 52 }, 7, 7, 6));
            Monkeys.Add(new Monkey5(new Int64[] { 91, 82, 85, 73, 84, 53 }, 3, 4, 1));
            Monkeys.Add(new Monkey6(new Int64[] { 88, 74, 68, 56 }, 17, 0, 2));
            Monkeys.Add(new Monkey7(new Int64[] { 54, 82, 72, 71, 53, 99, 67 }, 19, 6, 0));

            //Monkeys.Add(new Monkey0t(new Int64[] { 79, 98 }, 23, 2, 3));
            //Monkeys.Add(new Monkey1t(new Int64[] { 54, 65, 75, 74 }, 19, 2, 0));
            //Monkeys.Add(new Monkey2t(new Int64[] { 79, 60, 97 }, 13, 1, 3));
            //Monkeys.Add(new Monkey3t(new Int64[] { 74 }, 17, 0, 1));

            using (var progress = new ProgressBar())
            {

                for (int round = 0; round < 10001; round++)
                {
                    for (int currentMonkey = 0; currentMonkey < Monkeys.Count(); currentMonkey++)
                    {
                        //Console.WriteLine("Monkey " + currentMonkey+ ":");
                        if (Monkeys[currentMonkey].Items.Count() > 0)
                        {
                            int initialItemCount = Monkeys[currentMonkey].Items.Count();
                            for (int itemNo = 0; itemNo < initialItemCount; itemNo++)
                            {
                                // Console.WriteLine("Monkey " + currentMonkey + " inspects an item with a worry level of " + Monkeys[currentMonkey].Items[0]);


                                Monkeys[currentMonkey].Operation(0);
                                //Console.WriteLine("Worry level after operation:" + Monkeys[currentMonkey].Items[0]);

                                if (Monkeys[currentMonkey].Test(0))
                                {
                                    //Console.WriteLine("Item with worry level " + +Monkeys[currentMonkey].Items[0] + " is thrown to monkey "+ Monkeys[currentMonkey].TestTrue + ".");
                                    Monkeys[Monkeys[currentMonkey].TestTrue].Items.Add(Monkeys[currentMonkey].Items[0]);
                                    Monkeys[currentMonkey].Items.RemoveAt(0);
                                }
                                else
                                {
                                    //Console.WriteLine("Item with worry level " + +Monkeys[currentMonkey].Items[0] + " is thrown to monkey " + Monkeys[currentMonkey].TestFalse + ".");
                                    Monkeys[Monkeys[currentMonkey].TestFalse].Items.Add(Monkeys[currentMonkey].Items[0]);
                                    Monkeys[currentMonkey].Items.RemoveAt(0);
                                }

                            }
                        }
                    }
                    if ((round + 1) % 10000 == 0)
                    {
                        //Activate for more Console Logs. Just for testing. 
                        var orderedMonkeys = Monkeys.OrderByDescending(x => x.numberOfTestedItems).ToArray();
                        int mcou = 0;
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine($@"== After Round {round + 1} ==");
                        foreach (Monkey m in Monkeys)
                        {
                            //Console.WriteLine($@"Monkey {mcou} inspected items {m.numberOfTestedItems} times."); mcou++;
                        }
                        Console.WriteLine("Result of Day 11 Part 2:");
                        Console.WriteLine("MonkeyBusiness after Round " + (round + 1) + ": " + orderedMonkeys[0].numberOfTestedItems * orderedMonkeys[1].numberOfTestedItems);
                    }
                    progress.Report((double)round / 10000);
                }
            }
        }
    }


    public class Monkey
    {
        public List<Int64> Items { get; set; }
        public int devider = 0;
        public int TestTrue = 0;
        public int TestFalse = 0;
        public Int64 numberOfTestedItems = 0;

        public Monkey(Int64[] items, int devider, int testTrue, int testFalse)
        {
            Items = items.ToList();
            this.devider = devider;
            TestTrue = testTrue;
            TestFalse = testFalse;
        }

        public bool Test(int i)
        {
            numberOfTestedItems++;
            return Items[i] % devider == 0;
        }
        public virtual void Operation(int index)
        {

        }
    }

    public class Monkey0 : Monkey
    {
        public Monkey0(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] * 3;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey1 : Monkey
    {
        public Monkey1(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 8;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey2 : Monkey
    {
        public Monkey2(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 2;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey3 : Monkey
    {
        public Monkey3(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 4;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey4 : Monkey
    {
        public Monkey4(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {

            Items[index] = Items[index] * 19;
            Items[index] %= Day11.goldenNumber;

        }
    }
    public class Monkey5 : Monkey
    {
        public Monkey5(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 5;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey6 : Monkey
    {
        public Monkey6(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {

            Items[index] = Items[index] * Items[index];
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey7 : Monkey
    {
        public Monkey7(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 1;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey0t : Monkey
    {
        public Monkey0t(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] * 19;
            Items[index] %= Day11.goldenNumber;


        }
    }
    public class Monkey1t : Monkey
    {
        public Monkey1t(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {

            Items[index] = Items[index] + 6;
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey2t : Monkey
    {
        public Monkey2t(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {

            Items[index] = Items[index] * Items[index];
           // if (Items[index] >= Day11.goldenNumber)
                //Console.WriteLine("jetzt wird gekürzt.");
            Items[index] %= Day11.goldenNumber;
        }
    }
    public class Monkey3t : Monkey
    {
        public Monkey3t(Int64[] items, int devider, int testTrue, int testFalse) : base(items, devider, testTrue, testFalse)
        {
        }
        public override void Operation(int index)
        {
            Items[index] = Items[index] + 3;
            Items[index] %= Day11.goldenNumber;
        }
    }
}

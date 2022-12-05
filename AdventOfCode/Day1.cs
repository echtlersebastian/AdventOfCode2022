using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day1
    {
        public static void run()
        {

          

            string[] test2 = Inputs.Day1.Split("\r\n");


            List<Elf> alleElfen = new List<Elf>();

            Elf aktuellerElf = new Elf();

            foreach (string s in test2)
            {
                if (s == String.Empty)
                {
                    alleElfen.Add(aktuellerElf);
                    aktuellerElf = new Elf();
                }
                else
                {
                    aktuellerElf.addToList(s);
                }

            }

            var a = alleElfen.OrderBy(x => x.combined).ToList();

            int a1 = a[a.Count() - 1].combined;
            int a2 = a[a.Count() - 2].combined;
            int a3 = a[a.Count() - 3].combined;

            int resultall = a1 + a2 + a3;

            Console.WriteLine("Result of Day 1 Part 1: " + a1);
            Console.WriteLine("Result of Day 1 Part 2: " + resultall);


        }
    }



    public class Elf
    {
       public List<int> kalorien = new List<int> ();
        public int combined = 0;

        public void addToList(string cal)
        {
            kalorien.Add(Int32.Parse (cal));

            int a = 0;
            foreach(int i in kalorien)
            {
                a = a + i;
            }
            combined= a;
        }

        

    }
    
}

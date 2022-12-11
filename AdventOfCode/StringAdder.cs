using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class StringAdder
    {
        public static string Add(string s1, string s2)
        {
            char[] chars = s1.ToCharArray().Reverse().ToArray();
            char[] chars2 = s2.ToCharArray().Reverse().ToArray();
            List<char> result = new List<char>();
            int gemerkt = 0;
            Console.WriteLine($@"Adding {s1} and {s2}!");

            if (s1 == "184780")
                Console.WriteLine("stop");
            for (int i = 0; i < Math.Max(chars.Length, chars2.Length); i++)
            {
                if (i >= chars.Length || i >= chars2.Length)
                {
                    if (chars.Length == chars2.Length)
                    {
                        result.Add(gemerkt.ToString().ToCharArray()[0]);
                        result.Reverse();
                        Console.WriteLine($@"Result: {new string(result.ToArray())}");
                        return new string(result.ToArray());
                    }
                    else if (chars.Length > chars2.Length)
                    {
                        chars = chars.Skip(chars2.Length).ToArray();

                        //das muss while gemerkt != 0 sein.
                        while (gemerkt != 0)
                        {
                            int toAdd = (Int32.Parse(chars[0].ToString()) + gemerkt);
                            if (toAdd > 9)
                            {
                                result.Add(toAdd.ToString().ToCharArray()[0]);
                                chars = chars.Skip(1).ToArray();
                                gemerkt = 0;
                            }
                            else
                            {
                                break;
                            }
                        }
                        for (int io = 0; io < chars.Length; io++)
                        {
                            result.Add((char)chars[io]);
                        }
                        result.Reverse();
                        Console.WriteLine($@"Result: {new string(result.ToArray())}");
                        return new string(result.ToArray());

                    }
                    else if (chars.Length < chars2.Length)
                    {
                        chars2 = chars2.Skip(chars.Length).ToArray();
                        while (gemerkt != 0)
                        {
                            int toAdd = (Int32.Parse(chars2[0].ToString()) + gemerkt);
                            if (toAdd <= 9)
                            {
                                result.Add(toAdd.ToString().ToCharArray()[0]);
                                chars2 = chars2.Skip(1).ToArray();
                                gemerkt = 0;
                            }
                            else
                            {
                                break;
                            }
                        }
                        for (int io = 0; io < chars2.Length; io++)
                        {
                            result.Add((char)chars2[io]);
                        }

                        result.Reverse();
                        Console.WriteLine($@"Result: {new string(result.ToArray())}");
                        return new string(result.ToArray());

                    }


                }

                int first = Int32.Parse(chars[i].ToString());
                int secound = Int32.Parse(chars2[i].ToString());

                int r = first + secound + gemerkt;
                if (r > 9)
                {
                    string rs = r.ToString();
                    char[] ra = rs.ToCharArray();
                    gemerkt = Int32.Parse(ra[0].ToString());
                    result.Add(ra[1]);
                }
                else
                {
                    gemerkt = 0;
                    result.Add(r.ToString().ToCharArray()[0]);
                }

            }

            if (gemerkt != 0)
            {
                result.Add(gemerkt.ToString().ToCharArray()[0]);
            }
            result.Reverse();
            Console.WriteLine($@"Result: {new string(result.ToArray())}");
            return new string(result.ToArray());
        }
    }
}

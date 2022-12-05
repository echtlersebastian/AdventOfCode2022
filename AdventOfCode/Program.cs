using AdventOfCode;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

Console.WriteLine("Willkommen zum Weltschönsten Advent Of Code 2022! Anschnallen und dann kanns auch schon los gehen!");
Console.WriteLine("Beschwerden und Kommentare zu meinem Code sind wie immer nicht erwünscht. Nur Pull requests sind erlaubt! :P \n");

//Day 1
Day1.Run();

//Day2
Day2.RunPart1();
Day2.RunPart2();

//Day3
Day3.RunPart1();
Day3.RunPart2();

// Day 5
// TODO: this is not static, because i work with the membervariabled directly. Part 2 ruined my logic, that's why this is a bit sloppy in here... Maybe i will fix it.
//initialize 2 Objects
Day5 d5Part1 = new Day5();
Day5 d5Part2 = new Day5();

//execute the Logic
d5Part1.runPart1();
d5Part2.runPart2();
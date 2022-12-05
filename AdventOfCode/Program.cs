using AdventOfCode;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

Console.WriteLine("Willkommen zum Weltschönsten Advent Of Code 2022! Anschnallen und dann kanns auch schon los gehen!");
Console.WriteLine("Beschwerden und Kommentare zu meinem Code sind wie immer nicht erwünscht. Nur Pull requests sind erlaubt! :P \n");

//Day 1
Day1.run();

Day2 day2= new Day2();
day2.run();
day2.runPart2();

// Day 5
Day5 d5Part1 = new Day5();
d5Part1.runPart1();

Day5 d5Part2 = new Day5();
d5Part2.runPart2();
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day2
    {

        string input = @$"C Y
A Z
B Y
A Z
A X
A Z
B Y
A Z
B Y
C Z
B Y
C Z
A Z
C Y
B Y
B Y
B Y
C Y
B Y
B Y
A X
B Y
A Y
B Y
B Y
B X
A Y
C Z
C X
A Z
B Y
A X
C Y
C X
C Z
C X
B Y
B Y
B X
A Z
A X
C Y
A Z
C Z
B X
C X
B Y
C X
C Z
C Y
C Z
A Y
A Z
C Z
A Z
A Z
A Z
A Z
B Y
A Z
B Y
B Y
B Y
B X
A Z
B X
C Z
C Z
A Z
A Z
B Y
C Y
A X
C Y
C Y
B Z
B Y
C X
A X
A Z
C Z
C X
B Y
A X
C X
B Y
C X
B Y
C X
B Y
C Y
A Z
C Z
B X
C Y
B Y
A Z
B X
C Z
C Z
B Y
C Z
C X
A X
A Z
A Z
A Y
C Z
C Y
A X
C Z
C Y
A Z
C X
B X
A Z
B Y
A Z
B X
C X
A Z
C Y
C Z
B Y
C Y
C X
A Z
C X
C X
B Y
B Z
A X
B X
C Y
A Z
B Y
C Z
B Y
C Z
B X
B Y
B X
B Y
B Y
B Y
C Y
A Z
A Y
A Z
C Z
B Y
C Z
B Y
C Y
A Z
B X
B Y
C Z
A X
A Y
C X
B X
A Z
C X
A Y
A X
A Z
A Z
A Z
B Y
B Y
B Z
B Y
C Y
B Y
A Z
C X
A Z
A X
B Y
A X
C X
C X
A X
B X
C X
C Z
B Y
B Y
C Y
B X
C X
A Z
B Y
B Y
C Z
A Z
B Y
B X
C Z
A Y
B Y
A Y
C Y
C X
A X
B Y
C X
B Z
B Y
B Y
A Z
C Y
B Y
B Y
A Y
B Z
B Z
A Y
B Y
C Y
A Z
B Y
C Z
A Z
B Y
A Z
C Y
A X
B Z
C X
C Y
B Y
C Y
A Z
A Z
B Y
B Y
C Y
A Y
A Y
C Y
A Z
C Y
B X
C X
A X
A Y
A Z
A Y
A Z
B Y
B Y
B Y
A Z
C Y
C Z
A Y
C Y
A Z
A Z
C Z
B Y
A Z
C Z
B Y
C Y
C Z
C X
B Y
A Z
B Y
B Y
A Z
C X
B Y
A Z
B Y
C Y
A Y
A Z
C X
A Z
A Y
C Y
A Z
C Y
C Y
B X
A Z
B Y
A Z
C Y
B Y
B Y
B Y
A Z
C Z
C Y
B Y
C Z
C Y
C Y
C Y
A X
B X
C X
B Y
B Y
B X
B Y
B Y
C Z
B Y
B Z
C X
B Y
C Y
C Y
B X
A Z
B Y
B Y
A Z
B Y
C Z
B Y
B Y
A Z
C Z
C Z
A Z
C Y
B Y
B Y
C Y
B Z
A Y
C X
A Z
B X
C Y
A Z
C Z
B Y
B X
B Y
B Y
B Y
C Z
A Z
B Y
B X
B Y
B X
B X
C Z
A Z
B Y
C Z
A Z
C Y
C Y
A Z
A Z
A Y
B Y
C X
A Z
B Y
A Z
A Z
A Z
A Y
A Z
A Z
A Y
A X
A Z
C Z
C Y
C Y
C X
A Z
A Y
B Y
A Z
A Z
B Y
B X
B Y
A Z
A X
B Y
C Y
C Y
A Z
C Y
C X
B Y
A X
A X
C Y
A X
C Z
C X
C Y
B Y
A Z
C Y
A Z
A Z
C Z
B Y
A Z
A Y
A X
C X
C X
B Y
C X
B Y
C Z
A Y
B Y
C Y
C X
B Y
C Y
A Z
B Y
A X
C Y
A Y
A Z
A Z
B Y
A Z
A Z
C X
B Y
B Y
A Z
B Y
C Y
C Z
A Z
C Z
C Z
B Y
A Z
B Y
A Z
B Z
C Z
A Y
B Y
B Y
B Y
C Y
A X
A X
B X
B Y
C Z
C Y
C Y
C Y
A X
B Y
B Y
C Z
C X
B Y
A X
A Z
C Y
C Y
A Z
A Z
C Z
A Z
C Y
B Y
A X
B Y
C Z
A Z
A Y
B Y
B Z
C Y
C Y
C X
B Y
C Y
C Y
C Y
C Z
B Y
A Y
A Y
A Z
B Y
C X
B X
B X
B X
A Z
B Y
C Z
C Z
C X
B Y
B Y
B Y
A X
A Z
A Z
B Y
C Y
B Y
C Y
B X
A Z
B Y
B Y
B Y
B Y
B Y
B Y
C X
A Y
B Y
B Y
C Y
A Z
B Y
C X
B X
C Z
C X
A X
C X
B Y
B Y
C X
B Y
C Y
A Z
B Y
A X
C Y
A X
C Y
C Y
B Y
A Y
A Z
B Y
C Z
C Z
B Y
C Z
A Z
A Y
A Z
C Y
C Z
B Y
C Z
A Z
C X
A Y
C Z
A Z
B Y
C Z
C Y
B Y
A Z
B X
A Z
B X
C Z
B Y
A X
C Y
A Z
C Y
B Y
B Y
B Y
C Y
B Y
B Y
C X
A Z
A Z
B Y
C Y
C Z
C X
A Z
C Y
B X
B Y
A X
B Y
A Z
A Z
B Y
B X
C Z
C X
B Z
A Y
B Y
B Z
C Y
A Z
B X
C Y
B Y
C Z
B Z
A Y
A X
C X
B Y
C Y
A X
A Z
B Y
A Y
B Z
C X
B Y
C Y
C X
A Z
A Y
A Z
B Y
C Z
B X
A X
B Y
B Z
A Z
C Y
C X
A Z
C Y
C Z
B X
A Z
B X
A Z
A Z
C Y
B Z
C Y
C Y
B Y
C X
B X
A X
A Z
C Z
B X
B X
B X
B Z
B Y
B Z
C Y
B Y
C Y
C Z
A Z
A X
B Y
B Y
B Y
B Y
C X
B Y
B Y
A X
C X
B Y
C Z
C Y
A Z
A Y
B Y
C Y
B Y
C X
C X
B Y
B Y
B Y
C Y
A Z
A Y
C X
A Z
A Z
B Y
C X
C Y
B Y
B Y
C Y
C X
B X
C Y
B X
A Z
B Y
C X
B X
C Y
C Y
A Z
B Y
A Z
C Y
A Z
A Z
C Z
C X
C Y
A Z
C Z
A Z
B Y
A X
B Y
B Y
A Z
C X
B Z
B Y
C X
A Y
B Y
A Z
C Z
A Z
A Z
A Z
B Y
B Y
B X
B Y
B Y
B Y
C Z
B Y
A Z
C X
C Z
A Z
C Z
C Y
B Y
C Y
B X
C Y
B Y
A Z
B Y
C X
B Y
A Z
C Y
B Y
C Y
C Z
A X
B X
C X
B X
A X
B Y
A X
C Z
B Y
C Z
B Y
B Y
C Z
B Y
A Y
C Z
B Z
A Z
C X
A Z
A Z
B Y
B Y
C Y
C Z
C X
A Y
B Y
B Y
A X
A Y
B X
C Z
C Z
B Y
C Y
B Y
C X
B Z
A Z
A Z
B Y
A Y
A Y
A X
A Z
B Y
A X
B Z
C Z
B X
C Z
B X
B Y
A Y
B X
A Z
A Z
C Z
A X
C Z
B Y
A Y
C Z
C X
B Y
B Y
A X
C Y
C X
C Y
C X
A X
B Y
B X
B Y
C Y
C Y
C X
A Y
A Z
C Y
C Y
B Y
B X
B Y
B X
A Z
A Z
C Z
B Y
B Y
B Y
B X
C Z
A Y
A Z
B Y
B Y
B Y
B X
A X
B Y
C Z
A Z
A Z
C Y
C Y
B Y
B Y
A Z
B Y
A X
A Z
C Z
A Z
B Y
C X
B Y
A X
B Y
B X
B Y
B X
C X
A Z
C Z
C Z
B X
A Z
B Y
A Z
B X
B Y
A Z
C Y
B Y
A Z
A X
B Y
A Z
B Y
B Y
C Y
A Z
B Y
B Y
C Y
A Z
C Z
A Z
C Z
B Y
A Z
B Y
A Z
C Y
B Y
A X
A Z
B Y
B Y
C Z
C Z
C Z
B Y
C Y
A X
C X
A X
C Y
A Y
B X
B Y
C Z
B Y
B Y
B X
C Z
B Y
C X
A Z
C X
B Y
A X
C X
C Y
A Z
A X
C Z
C Z
B Y
C Y
A Y
A Z
A Y
C X
C X
B Y
C Y
B Y
A Z
C X
B Y
C Y
A X
A Z
C Y
B Y
B Y
A Y
C X
B Y
C Y
B Y
B X
A Z
C Y
C Y
A X
C X
A Z
C X
B Y
A X
C Z
B Y
C X
B Y
A Z
A Y
B Y
B X
B Y
C Y
C Z
B Y
A Z
A X
B X
C X
C Z
B Y
B Y
C X
C Z
A Z
C Y
C Z
B Y
A Z
B Y
B Y
C Z
C Z
B Y
C Y
B Y
A Z
B X
B Y
B Y
C X
A Z
A Z
B Y
C Y
B Y
A Z
A Y
A X
C Z
C Y
C Z
C Z
C Z
A Z
B Y
C Z
A Z
C Y
A Z
B Y
B Y
B Y
A Z
B Y
B X
B Y
B Y
B Y
B Y
B Y
B Y
A X
C Z
B X
B Y
C X
A Z
B Y
B X
C Y
B Y
C Y
B Y
A Z
B Y
C Y
A X
B Y
C X
B X
B Y
C Z
B X
C X
C Y
C X
C Y
C X
A Z
C X
B Y
A Z
B X
A Z
B X
B X
A Z
C Z
A Z
B X
B Z
C X
C Y
A X
A Z
B X
C Y
A Z
C Z
B Y
B Y
C Y
B Z
B Y
B Y
C Y
C Z
B Y
A Z
A X
B X
B X
C X
A Z
C Y
B Y
B Y
A Z
B Y
A Z
A Z
B Y
B Y
B Y
B Y
C X
B Y
B X
C Z
B X
C X
B X
B Y
B Y
B Y
A Z
B Y
A X
A Y
C X
B X
B Y
B Y
C Z
A Y
C Z
C Y
A Z
C Z
C Z
B X
B Y
A Z
B Y
C X
C Y
C Y
B X
B Y
B Z
A Y
A Z
C X
A X
B X
C X
B Y
B Y
B Y
B X
C X
B Y
A Z
A Z
A Y
B X
C Y
C Z
A Z
A Z
B X
A Z
C Y
B Y
A X
B X
A Z
B Y
B Y
B Y
B Y
C Z
C Z
A Y
B Y
C Z
C Z
B Y
B X
A Z
C Y
C X
A Z
A Z
C Y
C X
C Y
A Y
B Y
C X
B Y
B X
C Z
C X
C Y
B Y
B Y
A Z
B Y
C Z
C Y
B X
B Y
A Z
A Z
B X
B Y
A X
A Z
B Y
B Y
B Y
B Y
B Y
C Y
B Y
B Y
C Y
B Y
B Y
C Z
B Y
A X
C Y
B Y
A Z
B Y
C Z
C Z
C Y
A Y
B Y
A Z
A X
C Y
C Z
C Y
C Z
C Z
C Y
B X
B Y
B Y
C Z
C X
A Y
C Y
B Y
B Y
A Y
A Y
C X
C Y
A Z
A Z
A X
B Z
B X
A X
A Y
A Z
B Y
C Y
B X
B Y
B Y
C Z
C X
B Y
B Y
B Y
B Y
C Y
B Y
B X
C X
C Y
B Y
A Z
A Y
A Z
C Z
C Y
A Z
A Z
B Y
B Y
C Y
A X
B Y
A Z
B Y
A Z
B Y
B X
C X
C Y
A Z
A Y
B Y
C X
A Z
B Y
A Z
C Y
B X
B Y
B X
C Z
C X
B Y
A Z
B Y
B X
A X
C Z
C X
A Z
A Y
A X
A Z
A Z
A Z
C Y
A Z
B Y
A Z
A Z
C Z
B X
B Y
B Y
B Y
B Y
A Z
B Y
C Y
A Z
A Y
B Y
B Y
C Y
C Y
A Z
C Z
A Z
B Y
B Y
A Z
A X
A Z
A Z
C Y
C Z
A Z
C X
A X
B Y
C Y
C X
C Z
B Y
C Y
A Z
A Z
C Z
A Z
A Z
A X
B Y
C Y
A Z
C X
C Y
B Y
C X
B X
B Y
C Y
A Z
A Z
A X
B Y
A Z
B Y
B Y
C Z
C Z
A X
A Y
B Y
C Z
B Y
B Y
C X
A Z
C Z
A X
B Y
A Y
B Y
C Z
B Y
C X
B Y
B X
B Y
B Y
C Y
B X
B Y
A Z
A Z
B Z
A Z
B Y
B Y
A Y
A Z
C Z
C Y
B X
B Y
C Y
B X
C X
B Y
C X
A Z
B Y
B Y
B Y
C Y
B Y
B Z
A Z
B Y
A Z
C Y
B Y
B Y
B Y
B Y
C Z
B Y
B Y
B Y
A Z
C Z
B Y
B X
A Z
C X
C Y
C Z
B Y
A Z
C Y
A Y
A X
C Y
A X
A Z
A Z
B X
B Y
B Y
C Y
B X
B Y
A Z
B X
B Y
C Y
B Y
C X
A Z
A Z
A Z
A Z
C Z
A Y
C Z
C Z
C Z
B X
B Y
B X
A Z
A Y
B Y
A X
C X
C X
B Y
B Y
B Y
A X
A X
B Y
C Z
B Y
A Z
C Y
B Y
B Y
A Z
C Y
C Z
A Y
A Z
B Y
C X
C X
A Z
B Y
C Y
A Z
A Z
C Z
C X
B Y
C Z
C Z
B Y
A Z
A Z
B X
C X
B Y
C Y
B Y
C Y
B Y
B Y
A Z
A Y
B X
C Y
B Y
C X
C X
C Y
A Z
B Y
C Y
B Y
C Y
B Y
A Y
B Y
A Z
C X
C Z
C Z
C Y
B Y
C Y
B X
B X
A X
B Y
A X
B Y
A Z
C X
B Y
A Z
B X
B Z
B Y
B Y
C Y
B Y
A Z
B Y
C Y
C Z
A Z
C Z
B Y
B Y
B Z
A Z
B Y
C Z
B X
A Z
A X
B X
B Y
A X
B Y
C Y
A Z
A Y
B Y
A Z
B Y
A Y
B Y
C Z
C Z
C Y
C Z
B Y
A Z
B X
B Y
C Y
B Y
C Y
C Y
A Z
A Z
C X
A Y
C Z
B Y
B Y
B Y
C Y
B X
C Y
B Y
A Z
A Y
B Y
B Y
B Y
C X
B Y
C Z
A Y
B X
A Z
A Z
C X
B Y
B Y
A Z
A Y
A Y
C Z
A Z
A Y
B Y
C X
A X
A Y
B Y
A X
B Y
B X
C Y
C Z
C X
B Y
C Y
A Z
B X
A Z
B Y
B Y
B Y
C Y
B Z
C Z
C Y
B Y
C Y
B X
A X
B Y
B Y
A X
C Y
C Y
C Z
B X
A Z
C X
A Z
A Z
C Z
C Y
B Y
C Y
C X
A Z
C Z
B Y
A Z
A Z
C Z
A X
B Y
B Y
C Y
A Z
B X
B X
B X
B Y
B Y
B Y
B Y
A X
B Y
B Y
B X
C X
A Z
A Z
A Z
A Z
B Y
A Z
A Z
B X
A Z
C Y
B Y
B Y
B Y
B X
C Z
A Z
B Y
C X
A X
C Z
B Y
C Y
C Z
A Y
C Z
C X
C Y
B Z
B Y
B Y
B Y
A Z
C Z
A Z
A Z
C Z
B X
C Z
C Y
B X
B Y
C Y
B Y
B X
A Y
B Y
A Z
A Z
B Y
B Y
B X
B X
B X
B Y
A Y
C X
C Y
B Y
C X
B X
A Z
B Y
C X
B Y
B Y
B Y
B Y
A Z
B Y
C Z
B Y
C Z
A X
A Z
C Y
B Y
C Z
B Y
A Y
C X
C X
C Y
A Z
B Y
C X
B Y
B Y
A X
C X
A Z
C X
A Z
B Y
C Y
B Y
B Y
C Y
A Z
A X
C X
B X
B Y
B Y
A Y
B Y
B Y
C X
A Z
B Y
A Y
B Y
B Y
B Y
C Y
B Y
C X
B X
B X
C X
A Z
C X
C X
C Z
B Y
B Y
B Y
B Y
C Z
B X
B Y
B Y
A Z
A X
A Y
A Z
C Y
B Y
B Y
C X
B Y
B Y
B X
A Y
C Y
B Y
B Y
B Y
A Z
A Z
B X
C Y
B Y
A X
B Y
B Y
B X
B Y
A Y
C X
B Y
C Y
C Z
A Z
A Z
C Z
C Y
A Z
B Y
B X
B Y
B Y
C Z
B Y
A Z
C X
B Y
A Z
B Y
B Y
B Y
C X
A Z
A X
C Z
B Y
A Z
C Y
A Y
B Y
A Y
B Y
C Y
C Z
B Y
A Z
A Z
B Y
A X
C X
C Z
C X
B X
C Z
B Z
B Y
B X
C Z
B Y
C Y
C Y
A Z
B Y
B Y
B Y
B Y
C Y
A Z
B Y
A Z
C Z
A X
A Z
B Z
A Z
C Y
B Y
C Z
B Y
C Z
A Z
C Z
B Y
B Y
B Y
A Z
B Y
B X
B X
B X
A Z
C Z
C Y
B X
C Z
A X
B Y
C Y
B Y
B X
B Y
A Z
A X
A X
B Y
C Y
C Y
B Y
B Y
A Z
C Y
A X
A Z
C Y
A Z
C Z
C Y
A Z
C Y
C X
A Z
B X
B Y
A X
C Z
C Z
B X
C X
B Y
A Z
C Z
C Y
C Z
C X
C Z
A X
C Z
B X
C Y
C Z
B Y
C X
A Z
A Y
B Y
A Z
B Y
B Y
B X
C Z
B Y
B Y
B X
B Y
C Y
C Z
B X
B Y
C Z
B Y
B Y
B Y
B Y
A Z
C Z
C Y
B X
B X
B Y
B X
C Y
C Y
A Z
A Z
B X
B Y
B Y
C Z
C Z
B Y
A Z
C X
C Y
C X
B Y
B Y
C Z
C X
B Y
C Y
C Z
C Y
C X
C Y
B X
B X
B Y
B Y
B Y
C Z
B X
B Y
C X
C Y
C Y
C X
A Z
B Y
C Y
C Z
B Y
C Y
B Y
A Y
A Z
C Z
C Z
C Y
A X
C X
C Z
C Y
C Z
B X
C Z
B Y
C X
C Y
C Y
A Z
B Y
A Z
B Y
A X
C Z
A Z
C Z
B Y
B Y
B Y
A Z
A X
B Y
B Z
B Y
B Y
A Z
B Y
B Y
C Z
B Z
A Z
C X
B Y
A Y
B Y
C Y
C Y
C X
B Y
B Z
C Y
B Y
A Y
C X
A Z
A Z
B X
C Y
B Y
B Z
A Z
A Z
B Y
A Z
A Z
A Z
C Y
A Z
A Y
A Z
C Z
C Y
B Y
A Z
B X
B Y
A Z
A Y
B X
B Y
C Y
C Z
C Y
B X
C Y
B Y
B Y
A Z
A Z
B Y
C X
A X
A Z
A X
A X
C Y
B Y
C Z
A Z
B Z
B Y
B Y
B Y
C X
B Y
C Z
B Y
B Y
C Z
C Z
A Z
A Z
A Z
A Z
C Y
A Z
A Z
B Y
B Y
A Z
A Z
C X
C Y
A Z
B Z
B Y
C X
C X
B Y
C X
B Y
C Y
C X
B Y
C Z
A X
B Y
B X
B Y
C Y
B Y
A X
C X
B Y
B Y
B X
B Y
A Z
A Z
A Z
A Z
B Z
B Y
B Y
C X
A Z
C Y
B Z
A X
B Y
B X
B Y
A X
C X
B Y
B Y
A Z
B Y
C Z
A Y
B X
C X
B Y
B Y
A Z
C X
C Y
B Y
C Y
C Z
A Y
A Z
B Y
B Y
A Z
C Y
B Y
C Y
C X
C X
C Y
C Z
A Z
C X
B Y
A Z
B Y
C X
B Y
B Y
A Z
A Z
C X
B Y
A Z
B Y
A Y
B X
B Y
B X
A Y
B Y
B X
B Y
A Z
B Y
C Z
B Y
B Y
B Y
A Y
B Y
C Z
B X
B Y
A X
A Z
B Y
A Z
B X
C Y
B Y
B Z
C Y
B Y
C Y
C X
C X
C Z
B Y
B Y
B Y
A Z
B X
A Z
C Z
B Y
A Y
B Y
C Y
A Z
B Y
A Y
B X
B Y
C Y
C Y
A Z
A Z
B Y
C Y
C Z
A Z
A X
B Y
B Y
B Y
B Y
A Z
C Y
A Z
B Y
B Y
C Z
A Z
A X
C Y
B Y
B Y
A Z
B X
C Z
C Y
C Z
C Y
B Y
A Z
A Z
B Y
A Z
A Z
B Z
C X
C X
B Y
C Z
A Z
B X
A X
A Y
C Y
C Y
A Z
C Y
B Y
A Z
A Z
C Y
B Y
A Y
B X
C Z
B Y
B Y
A Z
B Z
C Z
B Y
B Y
B Y
A Y
C Y
A Z
A X
B Y
B Y
B Y
C Z
A X
B Y
B Y
C Y
B X
B Y
A Z
B Y
A Z
A Y
C Y
B Y
B Y
A Z
B X
A Z
A Z
A Z
B Y
A Y
C Z
B Y
B X
B Y
B Y
B Y
B Y
B Y
A X
C Z
B Y
B Y
B Y
C Z
B X
A Y
B X
C Z
B Y
C X
C X
A Z
B Y
B Y
A Z
C X
C X
A Z
B X
B Y
C X
C Z
A X
B X
B Y";
      
        //Run Part1
        public void run()
        {
            string[] allGamesString = input.Split("\r\n");
            List<Game> allGames = new List<Game>();

            foreach (string s in allGamesString)
            {
                string[] gameString = s.Split(' ');
                shape player1 = null;
                shape player2 = null;

                switch (gameString[0])
                {
                    case "A": player1 = new shape(possibleShapes.Rock); break;
                    case "B": player1 = new shape(possibleShapes.Paper); break;
                    case "C": player1 = new shape(possibleShapes.Sissors); break;
                }
                switch (gameString[1])
                {
                    case "X": player2 = new shape(possibleShapes.Rock); break;
                    case "Y": player2 = new shape(possibleShapes.Paper); break;
                    case "Z": player2 = new shape(possibleShapes.Sissors); break;
                }
                Game g = new Game(player1, player2);
                allGames.Add(g);

            }
            int result = 0;

            foreach (Game g in allGames)
            {
                result += g.resultPlayer2;
            }

            Console.WriteLine("Result of Day 2 Part 1: " + result);
        }

        //run Part2
        public void runPart2()
        {
            string[] allGamesString = input.Split("\r\n");
            List<Game> allGames = new List<Game>();

            foreach (string s in allGamesString)
            {
                string[] gameString = s.Split(' ');
                shape player1 = null;
                shape player2 = null;

                switch (gameString[0])
                {
                    case "A":
                        player1 = new shape(possibleShapes.Rock);
                        switch (gameString[1])
                        {
                            case "X": player2 = new shape(possibleShapes.Sissors); break;
                            case "Y": player2 = new shape(possibleShapes.Rock); break;
                            case "Z": player2 = new shape(possibleShapes.Paper); break;
                        }
                        break;
                    case "B":
                        player1 = new shape(possibleShapes.Paper);
                        switch (gameString[1])
                        {
                            case "X": player2 = new shape(possibleShapes.Rock); break;
                            case "Y": player2 = new shape(possibleShapes.Paper); break;
                            case "Z": player2 = new shape(possibleShapes.Sissors); break;
                        }
                        break;
                    case "C":
                        player1 = new shape(possibleShapes.Sissors);
                        switch (gameString[1])
                        {
                            case "X": player2 = new shape(possibleShapes.Paper); break;
                            case "Y": player2 = new shape(possibleShapes.Sissors); break;
                            case "Z": player2 = new shape(possibleShapes.Rock); break;
                        }
                        break;
                }
              
                Game g = new Game(player1, player2);
                allGames.Add(g);

            }
            int result = 0;

            foreach (Game g in allGames)
            {
                result += g.resultPlayer2;
            }

            Console.WriteLine("Result of Day 2 Part 2: " + result);
        }



    }


    public class Game
    {
        public shape Player1;
        public shape Player2;

        public int resultPlayer1;
        public int resultPlayer2;

        public Game(shape player1, shape player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            calculateResult();
        }

        public void calculateResult()
        {
            if (Player1.currentShape == possibleShapes.Rock && Player2.currentShape == possibleShapes.Sissors)
            {
                resultPlayer1 = Player1.points + 6;
                resultPlayer2 = Player2.points + 0;
            }
            else if (Player1.currentShape == possibleShapes.Rock && Player2.currentShape == possibleShapes.Paper)
            {
                resultPlayer1 = Player1.points + 0;
                resultPlayer2 = Player2.points + 6;
            }
            else if (Player1.currentShape == possibleShapes.Paper && Player2.currentShape == possibleShapes.Sissors)
            {
                resultPlayer1 = Player1.points + 0;
                resultPlayer2 = Player2.points + 6;
            }
            else if (Player1.currentShape == possibleShapes.Paper && Player2.currentShape == possibleShapes.Rock)
            {
                resultPlayer1 = Player1.points + 6;
                resultPlayer2 = Player2.points + 0;
            }
            else if (Player1.currentShape == possibleShapes.Sissors && Player2.currentShape == possibleShapes.Paper)
            {
                resultPlayer1 = Player1.points + 6;
                resultPlayer2 = Player2.points + 0;
            }
            else if (Player1.currentShape == possibleShapes.Sissors && Player2.currentShape == possibleShapes.Rock)
            {
                resultPlayer1 = Player1.points + 0;
                resultPlayer2 = Player2.points + 6;
            }
            else
            {
                resultPlayer1 = Player1.points + 3;
                resultPlayer2 = Player2.points + 3;

            }
        }

    }

    public class shape
    {
        public possibleShapes currentShape;
        public int points;
        public shape(possibleShapes s)
        {
            this.currentShape = s;
            switch (s)
            {
                case possibleShapes.Rock: points = 1; break;
                case possibleShapes.Paper: points = 2; break;
                case possibleShapes.Sissors: points = 3; break;
            }
        }

    }

    public enum possibleShapes
    {
        Rock,
        Paper,
        Sissors
    }
}
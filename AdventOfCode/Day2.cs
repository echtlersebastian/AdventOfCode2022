using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day2
    {

      
        //Run Part1
        public void run()
        {
            string[] allGamesString = Inputs.Day2.Split("\r\n");
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
            string[] allGamesString = Inputs.Day2.Split("\r\n");
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

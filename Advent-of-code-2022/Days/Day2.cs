using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day2 : BaseDay
    {
        private string[] input;
        public Day2(string inputPath) : base(inputPath)
        {
            input = File.ReadAllLines(inputPath);
        }

        public void SolvePart1()
        {

            int score = 0;

            foreach (var part in input)
            {
                string[] buff = part.Split(' ');
                switch (buff[0])
                {
                    case RPCFigure.EnemyRock:
                        switch (buff[1])
                        {
                            case RPCFigure.MyRock:
                                score += RPCFigure.PointsRock + RPCFigure.PointsDraw;
                                break;
                            case RPCFigure.MyPaper:
                                score += RPCFigure.PointsPaper + RPCFigure.PointsWin;
                                break;
                            case RPCFigure.MyScissors:
                                score += RPCFigure.PointsScissors;
                                break;
                            default:
                                break;
                        }
                        break;
                    case RPCFigure.EnemyPaper:
                        switch (buff[1])
                        {
                            case RPCFigure.MyRock:
                                score += RPCFigure.PointsRock;
                                break;
                            case RPCFigure.MyPaper:
                                score += RPCFigure.PointsPaper + RPCFigure.PointsDraw;
                                break;
                            case RPCFigure.MyScissors:
                                score += RPCFigure.PointsScissors + RPCFigure.PointsWin;
                                break;
                            default:
                                break;
                        }
                        break;
                    case RPCFigure.EnemyScissors:
                        switch (buff[1])
                        {
                            case RPCFigure.MyRock:
                                score += RPCFigure.PointsRock + RPCFigure.PointsWin;
                                break;
                            case RPCFigure.MyPaper:
                                score += RPCFigure.PointsPaper;
                                break;
                            case RPCFigure.MyScissors:
                                score += RPCFigure.PointsScissors + RPCFigure.PointsDraw;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(score);

        }

        public void SolvePart2()
        {
            int score = 0;

            foreach (var part in input)
            {
                string[] buff = part.Split(' ');
                switch (buff[0])
                {
                    case RPCFigure.EnemyRock:
                        switch (buff[1])
                        {
                            case RPCFigure.Win:
                                score += RPCFigure.PointsPaper + RPCFigure.PointsWin;
                                break;
                            case RPCFigure.Lose:
                                score += RPCFigure.PointsScissors;
                                break;
                            case RPCFigure.Draw:
                                score += RPCFigure.PointsRock + RPCFigure.PointsDraw;
                                break;
                            default:
                                break;
                        }
                        break;
                    case RPCFigure.EnemyPaper:
                        switch (buff[1])
                        {
                            case RPCFigure.Win:
                                score += RPCFigure.PointsScissors + RPCFigure.PointsWin;
                                break;
                            case RPCFigure.Lose:
                                score += RPCFigure.PointsRock;
                                break;
                            case RPCFigure.Draw:
                                score += RPCFigure.PointsPaper + RPCFigure.PointsDraw;
                                break;
                            default:
                                break;
                        }
                        break;
                    case RPCFigure.EnemyScissors:
                        switch (buff[1])
                        {
                            case RPCFigure.Win:
                                score += RPCFigure.PointsRock + RPCFigure.PointsWin;
                                break;
                            case RPCFigure.Lose:
                                score += RPCFigure.PointsPaper;
                                break;
                            case RPCFigure.Draw:
                                score += RPCFigure.PointsScissors + RPCFigure.PointsDraw;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(score);
        }
    }

    public static class RPCFigure
    {
        public const string EnemyRock = "A";
        public const string EnemyPaper = "B";
        public const string EnemyScissors = "C";

        public const string MyRock = "X";
        public const string MyPaper = "Y";
        public const string MyScissors = "Z";

        public const string Win = "Z";
        public const string Lose = "X";
        public const string Draw = "Y";

        public const int PointsRock = 1;
        public const int PointsPaper = 2;
        public const int PointsScissors = 3;

        public const int PointsWin = 6;
        public const int PointsDraw = 3;
    }
}

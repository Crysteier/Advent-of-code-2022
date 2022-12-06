using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day6 : BaseDay, IDay
    {
        public Day6(string inputPath) : base(inputPath) { }

        public static bool OnlyOnceCheck(string input)
        {
            return input.GroupBy(x => x).Any(g => g.Count() > 1);
        }

        public void SolvePuzzlePart1()
        {
            var chars = new List<char>(input[0].ToCharArray().AsQueryable().Take(4));
            for (int i = 0; i < input[0].Length - 3; i++)
            {
                if (!OnlyOnceCheck(new string(chars.ToArray())))
                {
                    Console.WriteLine("part 1 solution: " + (i));
                    break;
                }
                else
                {
                    chars.RemoveAt(0);
                    chars.Add(input[0][i]);
                }
            }
        }

        public void SolvePuzzlePart2()
        {
            var chars = new List<char>(input[0].ToCharArray().AsQueryable().Take(14));
            for (int i = 14; i < input[0].Length - 14; i++)
            {
                
                if (!OnlyOnceCheck(new string(chars.ToArray())))
                {
                    Console.WriteLine("part 2 solution: " + (i));
                    break;
                }
                else
                {
                    chars.RemoveAt(0);
                    chars.Add(input[0][i]);
                }
            }
        }

        public void SolvePuzzles()
        {
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}

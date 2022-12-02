using Advent_of_code_2022.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Day1
{
    public class Day1 : BaseDay, IDay
    {
        private List<int> elfAllCalories = new List<int>();
        public Day1(string inputPath) : base(inputPath) { }
        public void SolvePuzzlePart1()
        {
            int calories;
            int sumCalories = 0;
            foreach (var item in input)
            {
                if (int.TryParse(item, out calories))
                {
                    sumCalories += calories;
                }
                else
                {
                    elfAllCalories.Add(sumCalories);
                    sumCalories = 0;
                }
            }
            Console.WriteLine("Problem 1 solution: " + elfAllCalories.Max());
        }

        public void SolvePuzzlePart2()
        {
            int topThreeSum = 0;
            topThreeSum += elfAllCalories.Select(x => x).OrderDescending().First();
            topThreeSum += elfAllCalories.Select(x => x).OrderDescending().Skip(1).First();
            topThreeSum += elfAllCalories.Select(x => x).OrderDescending().Skip(2).First();
            Console.WriteLine("Problem 2 solution: " + topThreeSum);
        }

        public void SolvePuzzles()
        {
            Console.WriteLine("Day1");
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day7 : BaseDay, IDay
    {
        public Day7(string inputPath) : base(inputPath) { }

        public void SolvePuzzlePart1()
        {
            Console.WriteLine("Part 1 solution: " + GetDirectorySizes().Where(size => size < 100_000).Sum());
        }

        public void SolvePuzzlePart2()
        {
            var directorySizes = GetDirectorySizes();
            var freeSpace = 70_000_000 - directorySizes.Max();
            Console.WriteLine("Part 2 solution: " + directorySizes.Where(size => size + freeSpace >= 30_000_000).Min());
        }

        public void SolvePuzzles()
        {
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }

        private List<int> GetDirectorySizes()
        {
            var path = new Stack<string>();
            var sizes = new Dictionary<string, int>();
            foreach (var line in input)
            {
                if (line == "$ cd ..")
                {
                    path.Pop();
                }
                else if (line.StartsWith("$ cd"))
                {
                    path.Push(string.Join("", path) + line.Split(" ")[2]);
                }
                else if (Regex.Match(line, @"\d+").Success)
                {
                    var size = int.Parse(line.Split(" ")[0]);
                    foreach (var dir in path)
                    {
                        sizes[dir] = sizes.GetValueOrDefault(dir) + size;
                    }
                }
            }
            return sizes.Values.ToList();
        }
    }
}

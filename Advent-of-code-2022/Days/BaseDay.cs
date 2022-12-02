using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public abstract class BaseDay
    {
        private string _inputPath;
        public string[] input;

        public BaseDay(string inputPath)
        {
            _inputPath = inputPath;
            input = File.ReadAllLines(inputPath);
        }
    }

    public interface IDay
    {
        public void SolvePuzzles();
        public void SolvePuzzlePart1();
        public void SolvePuzzlePart2();
    }
}

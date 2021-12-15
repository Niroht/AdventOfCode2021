using AdventOfCode2021.DaySolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.ViewModel.DayViewModel
{
    public class DayOneViewModel : DayViewModelBase
    {
        private string? _solution = "Not Run";
        public string? Solution
        {
            get
            {
                return _solution;
            }
            set
            {
                Set(nameof(Solution), ref _solution, value);
            }
        }

        private DayOneSolution _solver = new DayOneSolution();

        public override void OnRunPartOne()
        {
            Solution = _solver.GetNumberOfIncreases(ParseInput(Input), 1).ToString();
        }

        public override void OnRunPartTwo()
        {
            Solution = _solver.GetNumberOfIncreases(ParseInput(Input), 3).ToString();
        }

        private static IEnumerable<int> ParseInput(string input)
        {
            return Array.ConvertAll((input ?? "").Split(" "), StringToIntOrDefault);
        }

        private static int StringToIntOrDefault(string input)
        {
            int parsed;
            int.TryParse(input, out parsed);
            return parsed;
        }
    }
}

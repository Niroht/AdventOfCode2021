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
            var parsedInput = Array.ConvertAll((Input ?? "").Split(" "), StringToInt);
            Solution = _solver.GetNumberOfIncreases(parsedInput).ToString();
        }

        private int StringToInt(string input)
        {
            int parsed;
            int.TryParse(input, out parsed);
            return parsed;
        }

        public override void OnRunPartTwo()
        {
            throw new NotImplementedException();
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdventOfCode2021.ViewModel.DayViewModel
{
    public abstract class DayViewModelBase : ViewModelBase
    {
        public string? Input { get; set; }

        public ICommand RunPartOne => new RelayCommand(OnRunPartOne);
        public ICommand RunPartTwo => new RelayCommand(OnRunPartTwo);

        public abstract void OnRunPartOne();

        public abstract void OnRunPartTwo();
    }
}

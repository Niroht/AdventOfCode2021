using AdventOfCode2021.ViewModel.DayViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdventOfCode2021.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public DayViewModelBase CurrentlyViewedDay { get; }

        public MainViewModel()
        {
            CurrentlyViewedDay = new DayOneViewModel();
        }
    }
}

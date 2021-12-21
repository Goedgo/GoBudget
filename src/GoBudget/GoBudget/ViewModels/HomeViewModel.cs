using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GoBudget.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            Title = "goedgo.com";
        }
        int count = 0;

        public ICommand IncreaseCount { get; }

        private string _countDisplay = "Clicked  times!";

        public string CountDisplay
        {
            get => _countDisplay;
            set => SetProperty(ref _countDisplay, value);
        }


        void OnIncrease()
        {
            count++;
            CountDisplay = $"you have liked {count} times. ";

        }

    }
}

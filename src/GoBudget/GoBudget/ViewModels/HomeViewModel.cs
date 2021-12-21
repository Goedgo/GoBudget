using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoBudget.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableRangeCollection<string> Coffee { get; }
        public HomeViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            Coffee = new ObservableRangeCollection<string>();
            callServerCommand = new AsyncCommand(Callserver);

            Title = "goedgo.com";

        }
        public ICommand callServerCommand { get; }
        async Task Callserver()
        {
            var items = new List<string> { "yes plz", "tonx", "blue bottle" };
            Coffee.AddRange(items);
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

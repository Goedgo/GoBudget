using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoBudget.ViewModels
{
    public class HomeViewModel : BindableObject
    {
        public HomeViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }
        int count = 0;

        public ICommand IncreaseCount { get; }

        private string _countDisplay = "Clicked  times!";

        public string CountDisplay
        {
            get { return _countDisplay; }
            set
            {
                if (value == _countDisplay)
                    return;
                _countDisplay = value;
                // OnPropertyChanged("CountDisplay");
                // OnPropertyChanged(nameof(CountDisplay));
                OnPropertyChanged();

            }
        }


        void OnIncrease()
        {
            count++;
            CountDisplay = $"you have liked {count} times. ";

        }

    }
}

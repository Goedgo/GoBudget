using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoBudget.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            IncreaseCount = new Command(onIncrease);
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


        private void onIncrease()
        {
            count++;
            CountDisplay = $"you have liked {count} times. ";

        }
    }
}
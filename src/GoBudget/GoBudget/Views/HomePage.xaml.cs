using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        int count = 0;

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


        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;
            CountDisplay = $"you have liked {count} times. ";

        }
    }
}
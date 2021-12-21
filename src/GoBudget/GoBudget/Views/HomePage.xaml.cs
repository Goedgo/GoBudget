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
            buttonClick.Text = "liked";
            buttonClick.Clicked += ButtonClick_Clicked;

        }

        int count = 0;
        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = $"you have liked {count} times. ";

        }
    }
}
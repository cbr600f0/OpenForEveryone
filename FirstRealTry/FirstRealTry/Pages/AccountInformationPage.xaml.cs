using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstRealTry.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountInformationPage : ContentPage
    {
        public AccountInformationPage()
        {
            InitializeComponent();
        }

        private async void PreviousButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
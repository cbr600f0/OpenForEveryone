using FirstRealTry.Pages;
using System.ComponentModel;
using Xamarin.Forms;

namespace FirstRealTry
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string Mark { get; set; }
        public string GenericText { get; set; }
        public MainPage()
        {
            BindingContext = this;
            Mark = "This is where the variable gets placed that defines the text in this label";
            GenericText = "GENERIC TEXT!";
            InitializeComponent();
        }

        private async void RegisterPageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AccountInformationPage());
        }

        private async void PreviousPageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

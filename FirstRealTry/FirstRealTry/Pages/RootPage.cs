using System.Collections.Generic;
using Xamarin.Forms;

namespace FirstRealTry
{
    public class RootPage : NavigationPage
    {
        public RootPage(Page page) : base(page)
        {
            BackgroundImageSource = FileImageSource.FromFile("dance.jpg");
            ToolbarItems.Add(new ToolbarItem
            {
                Name = "Sidney",
                Command = new Command(() => { DisplayAlert("Kanker", "Neger", "Yes"); })
            });
        }
    }
}
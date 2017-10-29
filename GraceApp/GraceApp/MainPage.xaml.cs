using FacebookLogin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GraceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          //  InitializeComponent();
            Title = "Facebook Login";
            BackgroundColor = Color.White;

            var loginButton = new Button
            {
                Text = "Login with Facebook",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#01579B"),
                Font = Font.BoldSystemFontOfSize(26),
                FontSize = 26
            };

            loginButton.Clicked += LoginWithFacebook_Clicked;

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 20, 0, 50),
                Children =
                {
                   new Label
                    {
                        Text = "Grace App",
                        FontSize = 66,
                        TextColor = Color.Black,                        
                    },
                 
                    new Label
                    {
                        Text = "An App To Connect!",
                        FontSize = 26,
                        TextColor = Color.Black
                    },
                    loginButton
                }
            };
        }

        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfileCsPage());
        }
    }
}

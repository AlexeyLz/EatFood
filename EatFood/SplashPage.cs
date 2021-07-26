using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EatFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    class SplashPage : ContentPage
    {

        Image splashImage;

       

        public SplashPage()
        {


          //  InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           // DependencyService.Get<IStatusBar>().HideStatusBar();
            var sub = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "iccon.ico",
                WidthRequest = 200,
                HeightRequest = 200
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 100);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = (new MainPage());
           

        }

       
       


    }
}

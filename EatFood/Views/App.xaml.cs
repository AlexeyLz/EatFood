using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EatFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class App : Application
    {
        



         
        
        public const string DATABASE_NAME = "foodPlaces.db";
        public static FoodRepository database;
        public static FoodRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FoodRepository(DATABASE_NAME);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            //if (Device.OS != TargetPlatform.WinPhone)
            //{
            
            //    Resource.Culture = DependencyService.Get<ILocalize>()
            //    .GetCurrentCultureInfo();
            //}
            if (Device.OS != TargetPlatform.WinPhone)
            {
                Resource.Culture = DependencyService.Get<ILocalize>()
                                    .GetCurrentCultureInfo();
                  
            }
            MainPage = new SplashPage();
   


        }
       
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

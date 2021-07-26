//using EatFood.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EatFood
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

 



    public partial class MainPage : MasterDetailPage
    {

        async void testc()
        {
            await pictureRotation.RotateTo(360, 2000);
            pictureRotation.Rotation = 0;
            testc();
        }
        public MainPage()
        {
            InitializeComponent();
            IsPresented = false;

            testc();
        }

        private void AddClick(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new AddPage())
            {
                BarBackgroundColor = Color.Gray
            };
            
            IsPresented = false;
            
        }

        private void QuitClick(object sender, EventArgs e)
        {

            Environment.Exit(0);


        }

        private void RecommendClick(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProgramInfo())
            {
                BarBackgroundColor = Color.Gray
            };
            IsPresented = false;
        }

        

        private void statisticsClick(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new StatisticsPage())
            {
                BarBackgroundColor = Color.Gray
            };


            IsPresented = false;
        }

        private void ShowClick(object sender, EventArgs e)
        {
            
            Detail = new NavigationPage(new ShowPage())
            {
                BarBackgroundColor = Color.Gray
            };

            
            IsPresented = false;
        }

        
    }

    internal class async
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using Entry = Microcharts.Entry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;

namespace EatFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsPage : ContentPage
    {
        float[] count = new float[5];
        public float cafeesCounter()
        {
            var foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            int counter = 0;
            float midPrice = 0;
            for (int i = 0; i < foodPlaces.Count; i++)
            {
                if (foodPlaces[i].type == "Кафе" || foodPlaces[i].type == "Cafe")
                {
                    counter++;
                    midPrice = midPrice + Convert.ToInt32(foodPlaces[i].midPrice);
                }
            }
            count[0] = counter;
            midPrice = midPrice / counter;
            return midPrice;
        }

        public float restorauntCounter()
        {
            var foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            int counter = 0;
            float midPrice = 0;
            for (int i = 0; i < foodPlaces.Count; i++)
            {
                if (foodPlaces[i].type == "Ресторан" || foodPlaces[i].type == "Restoraunt")
                {
                    counter++;
                    midPrice = midPrice + Convert.ToInt32(foodPlaces[i].midPrice);
                }
            }
            count[1] = counter;
            midPrice = midPrice / counter;
            return midPrice;
        }

        public float fastfoodCounter()
        {
            var foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            int counter = 0;
            float midPrice = 0;
            for (int i = 0; i < foodPlaces.Count; i++)
            {
                if (foodPlaces[i].type == "Фастфуд" || foodPlaces[i].type == "Fastfood")
                {
                    counter++;
                    midPrice = midPrice + Convert.ToInt32(foodPlaces[i].midPrice);
                }
            }
            count[2] = counter;
            midPrice = midPrice / counter;
            return midPrice;
        }

        public float barCounter()
        {
            var foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            int counter = 0;
            float midPrice = 0;
            for (int i = 0; i < foodPlaces.Count; i++)
            {
                if (foodPlaces[i].type == "Бар" || foodPlaces[i].type == "Bar")
                {
                    counter++;
                    midPrice = midPrice + Convert.ToInt32(foodPlaces[i].midPrice);
                }
            }
            count[3] = counter;
            midPrice = midPrice / counter;
            return midPrice;
        }

        public float otherCounter()
        {
            var foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            int counter = 0;
            float midPrice = 0;
            for (int i = 0; i < foodPlaces.Count; i++)
            {
                if (foodPlaces[i].type == "Другое"  || foodPlaces[i].type == "Other")
                {
                    counter++;
                    midPrice = midPrice + Convert.ToInt32(foodPlaces[i].midPrice);
                }
            }
            count[4] = counter;
            midPrice = midPrice / counter;
            return midPrice;
        }

        public void drawing(float cafeesCount, float restorauntCount, float fastfoodCount, float barCount, float otherCount)
        {
            var entries = new[]
            {
                new Entry(cafeesCount)
                {
                    Label = Resource.Cafe,
                    ValueLabel = (cafeesCount).ToString(),
                    Color = SKColor.Parse("#2c3e50")
                },

                new Entry(restorauntCount)
                {
                    Label = Resource.Restoraunt,
                    ValueLabel = restorauntCount.ToString(),
                    Color = SKColor.Parse("#77d065")
                },

                new Entry(fastfoodCount)
                {
                    Label = Resource.Fastfood,
                    ValueLabel = fastfoodCount.ToString(),
                    Color = SKColor.Parse("#b455b6")
                },

                new Entry(barCount)
                {
                    Label = Resource.Bar,
                    ValueLabel = barCount.ToString(),
                    Color = SKColor.Parse("#3498db")
                },

                new Entry(otherCount)
                {
                    Label = Resource.Other,
                    ValueLabel = (otherCount).ToString(),
                    Color = SKColor.Parse("#68B9C0")
                }
            };


            chartView.Chart = new LineChart { Entries = entries };


        }


        public void drawing2(float cafeesCount, float restorauntCount, float fastfoodCount, float barCount, float otherCount)
        {
            var entries = new[]
            {
                new Entry(cafeesCount)
                {
                    Label = Resource.Cafe,
                    ValueLabel = (cafeesCount).ToString(),
                    Color = SKColor.Parse("#2c3e50")
                },

                new Entry(restorauntCount)
                {
                    Label = Resource.Restoraunt,
                    ValueLabel = restorauntCount.ToString(),
                    Color = SKColor.Parse("#77d065")
                },

                new Entry(fastfoodCount)
                {
                    Label = Resource.Fastfood,
                    ValueLabel = fastfoodCount.ToString(),
                    Color = SKColor.Parse("#b455b6")
                },

                new Entry(barCount)
                {
                    Label = Resource.Bar,
                    ValueLabel = barCount.ToString(),
                    Color = SKColor.Parse("#3498db")
                },

                new Entry(otherCount)
                {
                    Label = Resource.Other,
                    ValueLabel = (otherCount).ToString(),
                    Color = SKColor.Parse("#68B9C0")
                }
            };


            chartView_second.Chart = new DonutChart { Entries = entries };
            

        }



        public StatisticsPage()
        {
            InitializeComponent();

            float cafeesCount = cafeesCounter();
            float restorauntCount = restorauntCounter();
            float fastfoodCount = fastfoodCounter();
            float barCount = barCounter();
            float otherCount = otherCounter();

            drawing(cafeesCount, restorauntCount, fastfoodCount, barCount, otherCount);
            drawing2(count[0], count[1], count[2], count[3], count[4]);
            

        }


    }
}
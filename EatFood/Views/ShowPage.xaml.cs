//using EatFood.ViewModels;
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
    public partial class ShowPage : ContentPage
    {

       static List<FoodPlace> foodPlaces = new List<FoodPlace>();

        SearchBar searchBar = new SearchBar() { WidthRequest = 200 };

        ListView listView = new ListView();
        int delID = -1;

        Button delButton = new Button() { CornerRadius = 20};
       


        public ShowPage()
        {
            InitializeComponent();
            delButton.Text = Resource.Delete;
            listView.HasUnevenRows = true;
            delButton.Clicked += DelButton_Clicked;

            //foodPlaces.Add(new FoodPlace { name = "temp", midPrice = "temp", rating = "temp", type = "temp", typicalFood = "temp" });
            //App.Database.SaveItem(foodPlaces[foodPlaces.Count-1]);
            //foodPlaces.RemoveAt(foodPlaces.Count-1);
         //   App.Database.DeleteItem(0); // re - номер 9

            foodPlaces = (List<FoodPlace>)App.Database.GetItems();
            
          
   
            


            
            string lang="a";
            if(this.Title == "Places List")
            {

                for(int i =0; i<foodPlaces.Count; i++)
                {
                    if(foodPlaces[i].type == "Кафе")
                    {
                        foodPlaces[i].type = "Cafe";
                    }else if(foodPlaces[i].type == "Ресторан")
                    {
                        foodPlaces[i].type = "Restoraunt";
                    }
                    else if(foodPlaces[i].type == "Бар")
                    {
                        foodPlaces[i].type = "Bar";
                    }
                    else if(foodPlaces[i].type == "Фастфуд")
                    {
                        foodPlaces[i].type = "Fastfood";
                    }
                    else if(foodPlaces[i].type == "Другое")
                    {
                        foodPlaces[i].type = "Other";
                    }
                }
                
            }else
            {
                for (int i = 0; i < foodPlaces.Count; i++)
                {
                    if (foodPlaces[i].type == "Cafe")
                    {
                        foodPlaces[i].type = "Кафе";
                    }
                    else if (foodPlaces[i].type == "Restoraunt")
                    {
                        foodPlaces[i].type = "Ресторан";
                    }
                    else if (foodPlaces[i].type == "Bar")
                    {
                        foodPlaces[i].type = "Бар";
                    }
                    else if (foodPlaces[i].type == "Fastfood")
                    {
                        foodPlaces[i].type = "Фастфуд";
                    }
                    else if (foodPlaces[i].type == "Other")
                    {
                        foodPlaces[i].type = "Другое";
                    }
                }
            }
            listView.ItemsSource = foodPlaces;

            // friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();

            listView.ItemTemplate = new DataTemplate(() =>
            {


                Label nameLabel = new Label { FontSize = 18 };
                nameLabel.SetBinding(Label.TextProperty, "name");
                nameLabel.Margin = new Thickness(30, 0, 0, 0);
                nameLabel.TextColor = Color.Orange;
                nameLabel.FontAttributes = FontAttributes.Bold;
                //----------------------------------------------------------------

                StackLayout typestack = new StackLayout() { Orientation = StackOrientation.Horizontal };

                Label typeAd = new Label();
                typeAd.Text = Resource.Type2;
                typeAd.Margin = new Thickness(10, 0, 0, 0);
                typeAd.FontAttributes = FontAttributes.Bold;

                Label typeLabel = new Label();
                typeLabel.SetBinding(Label.TextProperty, "type");
                typeLabel.Margin = new Thickness(10, 0, 0, 0);
                typeLabel.FontAttributes = FontAttributes.Bold;

                typestack.Children.Add(typeAd);
                typestack.Children.Add(typeLabel);
                //---------------------------------------------------

                StackLayout typicalstack = new StackLayout() { Orientation = StackOrientation.Horizontal };

                Label typicalAd = new Label();
                typicalAd.Text = Resource.TypicalFood2;
                typicalAd.Margin = new Thickness(10, 0, 0, 0);
                typicalAd.FontAttributes = FontAttributes.Bold;

                Label typicalfoodLabel = new Label();
                typicalfoodLabel.SetBinding(Label.TextProperty, "typicalFood");
                typicalfoodLabel.Margin = new Thickness(10, 0, 0, 0);
                typicalfoodLabel.FontAttributes = FontAttributes.Bold;

                typicalstack.Children.Add(typicalAd);
                typicalstack.Children.Add(typicalfoodLabel);
                //---------------------------------------------------------------

                StackLayout ratingstack = new StackLayout() { Orientation = StackOrientation.Horizontal };

                Label ratingAd = new Label();
                ratingAd.Text = Resource.Rating2;
                ratingAd.Margin = new Thickness(10, 0, 0, 0);
                ratingAd.FontAttributes = FontAttributes.Bold;


                Label ratingLabel = new Label();
                ratingLabel.SetBinding(Label.TextProperty, "rating");
                ratingLabel.Margin = new Thickness(10, 0, 0, 0);
                ratingLabel.FontAttributes = FontAttributes.Bold;

                ratingstack.Children.Add(ratingAd);
                ratingstack.Children.Add(ratingLabel);
                //--------------------------------------------------------------------

                StackLayout midPricestack = new StackLayout() { Orientation = StackOrientation.Horizontal };

                Label midAd = new Label();
                midAd.Text = Resource.PriceText2;
                midAd.Margin = new Thickness(10, 0, 0, 0);
                midAd.FontAttributes = FontAttributes.Bold;


                Label midPriceLabel = new Label();
                midPriceLabel.SetBinding(Label.TextProperty, "midPrice");
                midPriceLabel.Margin = new Thickness(10, 0, 0, 0);
                midPriceLabel.FontAttributes = FontAttributes.Bold;

                midPricestack.Children.Add(midAd);
                midPricestack.Children.Add(midPriceLabel);
                //-----------------------------------------------------------------------


                StackLayout adressstack = new StackLayout() { Orientation = StackOrientation.Horizontal };

                Label adressAd = new Label() ;
                adressAd.Text = Resource.Adress2;
                adressAd.Margin = new Thickness(10, 0, 0, 0);
                adressAd.FontAttributes = FontAttributes.Bold;
                

                Label adressLabel = new Label();
                adressLabel.SetBinding(Label.TextProperty, "adress");
                adressLabel.Margin = new Thickness(10, 0, 0, 0);
                adressLabel.FontAttributes = FontAttributes.Bold;

                adressstack.Children.Add(adressAd);
                adressstack.Children.Add(adressLabel);
                //------------------------------------------------------



                return new ViewCell
                {

                    View = new StackLayout
                    {

                        Padding = new Thickness(0, 5),
                        Orientation = StackOrientation.Vertical,
                        Children = { nameLabel, typestack, typicalstack, ratingstack, midPricestack, adressstack}
                    }
                };

             
            });

            
            
            StackLayout bar = new StackLayout() { Orientation = StackOrientation.Horizontal};
      
            bar.Children.Add(searchBar);
            bar.Children.Add(delButton);


           
            searchBar.TextChanged += SearchBar_TextChanged;
            listView.ItemSelected += ListView_ItemSelected;
           

            //  searchBar.SearchButtonPressed += SearchBar_SearchButtonPressed;
            

            

            //  sortingPrice.SelectedIndexChanged += this.sorting;
            this.Content = new StackLayout { Children = {  bar,  listView} };
            
        }

        private void DelButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                delButton.IsVisible = false;
                //// int deletingID = foodPlaces[delID].Id;
                //test1.Text = "Id в списке " + delID;
                //int deletingID = foodPlaces[delID].Id;
                //test2.Text = "Id в поле " + deletingID;
                //App.Database.Equals(deletingID);
                //foodPlaces.RemoveAt(delID);
                string name = foodPlaces[delID].name;
                App.Database.DeleteItem(foodPlaces[delID].Id);
                foodPlaces = (List<FoodPlace>)App.Database.GetItems();
                listView.ItemsSource = foodPlaces;
                DisplayAlert("Информирование", "Заведение \"" + name + "\" успешно удалено", "Ок");
            }
            catch
            {
                DisplayAlert("Сообщение об ошибке", "Не выбран объект удаления", "Ок");
            }
      

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            delID = e.SelectedItemIndex;
            delButton.IsVisible = true;
            
        }

     

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = searchBar.Text;
            listView.ItemsSource = foodPlaces.Where(c => c.name.ToLower().Contains(keyword.ToLower()));
        }

        //private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        //{
        //    var keyword = searchBar.Text;
        //    listView.ItemsSource = foodPlaces.Where(c => c.name.ToLower().Contains(keyword.ToLower()));
        //}

        public static void adding(string name, string midPrice, string type, string typicalFood, string adress, string rating)
        {

            foodPlaces.Add(new FoodPlace { name = name, midPrice = midPrice, rating = rating, type = type, typicalFood = typicalFood, adress = adress });
            App.Database.SaveItem(foodPlaces[foodPlaces.Count-1]);
            //  first.Text = foodPlaces[0].name;

        }

        public void output()
        {



        }

    }
}
 
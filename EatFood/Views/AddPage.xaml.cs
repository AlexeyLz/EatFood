//using EatFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EatFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        /// public FoodViewModel ViewModel { get; private set; }
        public AddPage()
        {
            InitializeComponent();
            // ViewModel = Vm;
            // this.BindingContext = ViewModel;
            //  BindingContext = new FoodListViewModel() { Navigation = this.Navigation };
            Price2.BindingContext = step;
            Price2.SetBinding(Label.TextProperty, "Value");

            pickerType.Items.Add(Resource.Restoraunt);
            pickerType.Items.Add(Resource.Cafe);
            pickerType.Items.Add(Resource.Fastfood);
            pickerType.Items.Add(Resource.Bar);
            pickerType.Items.Add(Resource.Other);

            // this.Title = Resource.


        }

        
        private void adding_click(object sender, EventArgs e)
        {
            if (name.Text == null || checkingInput(name.Text) == false)
            {
                if (this.Title == "Adding new food place")
                {
                    DisplayAlert("Error", "Incorrect input of name", "Ok");
                    return;
                }
                else
                {
                    DisplayAlert("Сообщение об ошибке", "Некорректно введено название заведения", "Ок");
                    return;
                }
            }
            else if (pickerType.SelectedItem == null)
            {
                if (this.Title == "Adding new food place")
                {
                    DisplayAlert("Error", "Incorrect input of type", "Ok");
                    return;
                }
                else
                {
                    DisplayAlert("Сообщение об ошибке", "Не выбран тип заведения", "Ок");
                    return;
                }
            }
            else if (typicalFood.Text == null || checkingInput(typicalFood.Text) == false)
            {
                if (this.Title == "Adding new food place")
                {
                    DisplayAlert("Error", "Incorrect input of food type", "Ok");
                    return;
                }
                else
                {
                    DisplayAlert("Сообщение об ошибке", "Некорректно введено название блюда", "Ок");
                    return;
                }
            }
            else if (pickerRating.SelectedItem == null)
            {
                if (this.Title == "Adding new food place")
                {
                    DisplayAlert("Error", "Incorrect input of rating", "Ok");
                    return;
                }
                else
                {
                    DisplayAlert("Сообщение об ошибке", "Не выбран рейтинг заведения", "Ок");
                    return;
                }
            }
            else if (adress.Text == null || checkingInput(adress.Text) == false)
            {
                if (this.Title == "Adding new food place")
                {
                    DisplayAlert("Error", "Incorrect input of adress", "Ok");
                    return;
                }
                else
                {
                    DisplayAlert("Сообщение об ошибке", "Некорректно введен адрес заведения", "Ок");
                    return;
                }
            }

            var temp = pickerType.SelectedItem;
            string type = temp.ToString();
            //  var temp2 = pickerRating.SelectedItem;

            ShowPage.adding(name.Text, Price2.Text, type, typicalFood.Text, adress.Text, pickerRating.SelectedItem.ToString());
            DisplayAlert("Информирование", "Заведение \"" + name.Text + "\" успешно добавлено", "Ок");
        }

        private bool checkingInput(string line)
        {

            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] != ' ')
                {
                    return true;
                }

            }
            return false;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void picker_SelectedRating(object sender, EventArgs e)
        {
            string temp = pickerRating.Title;
            pickerRating.Title = Convert.ToString(temp.Length);
            
        }

        private void addButton(object sender, EventArgs e)
        {
            
            var temp = pickerType.SelectedItem;
            string type = temp.ToString();
            
          //  var temp2 = pickerRating.SelectedItem;
            
            ShowPage.adding(name.Text, Price2.Text, type, typicalFood.Text, adress.Text, pickerRating.SelectedItem.ToString());
        }
        
            
        // FoodCollection temp = new FoodCollection();
        // temp.addFunc("test", "tet", "t", "t", "t");
        

    }
    
        //private void sliderPrice_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if(e.NewValue >= 0)
        //    {
        //        Price.Text = "Средняя цена посещения заведения " + Convert.ToString(e.NewValue) + " BYN";
        //        stepperPrice.Value = e.NewValue;
        //    }

        //}

        //private void stepperPrice_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (e.NewValue >= 0)
        //    {
        //        Price.Text = "Средняя цена посещения заведения " + Convert.ToString(e.NewValue) + " BYN";
        //        sliderPrice.Value = e.NewValue;
        //    }

        //}


    
}
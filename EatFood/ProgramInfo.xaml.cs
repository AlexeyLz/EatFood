//using Plugin.Media;
//using Plugin.Media.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EatFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramInfo : ContentPage
    {
        public ProgramInfo()
        {
           InitializeComponent();
            ////InitializeComponent();
            
            //Button takePhotoBtn = new Button { Text = "Сделать фото" };
            //Button getPhotoBtn = new Button { Text = "Выбрать фото" };
            //Image img = new Image();
            
            //// выбор фото
            //getPhotoBtn.Clicked += async (o, e) =>
            //{
               
            //    if (CrossMedia.Current.IsPickPhotoSupported)
            //    {
            //        MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
            //        img.Source = ImageSource.FromFile(photo.Path);
            //    }
            //};

            //// съемка фото
            //takePhotoBtn.Clicked += async (o, e) =>
            //{
            //    if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
            //    {
            //        MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            //        {
            //            SaveToAlbum = true,
            //            Directory = "Sample",
            //            Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
            //        });

            //        if (file == null)
            //            return;

            //        img.Source = ImageSource.FromFile(file.Path);
            //    }
            //};
            //Content = new StackLayout
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    Children = {
            //        new StackLayout
            //        {
            //             Children = {takePhotoBtn, getPhotoBtn},
            //             Orientation =StackOrientation.Horizontal,
            //             HorizontalOptions = LayoutOptions.CenterAndExpand
            //        },
            //        img
            //    }
            //};
        }
    }
}


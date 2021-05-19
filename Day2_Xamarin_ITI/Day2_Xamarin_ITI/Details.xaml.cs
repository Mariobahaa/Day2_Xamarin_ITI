using Day2_Xamarin_ITI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2_Xamarin_ITI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        //public Meal Meal { get; set; }
        //public string _Name { get; set; }
        //public string _Image { get; set; }
        //public decimal _Price { get; set; }
        
        public Details() {  InitializeComponent(); 
            if(BindingContext!=null)
            DisplayAlert((BindingContext as Meal).Name, (BindingContext as Meal).Name, (BindingContext as Meal).Name);  
        }

        //public Details(String _name, string _image, decimal _price)
        //{
        //    _Name = _name; _Image = _image; _Price = _price;
        //    Meal = new Meal() { Name = _name, Image = _image, Price = _price };
        //    //BindingContext = Meal;
        //    InitializeComponent();
        //}
        public Details(Meal _meal = null)
        {
            //Meal = _meal;
            InitializeComponent();
            BindingContext = _meal;
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Buy", "You will buy one meal of this item", "OK");
        }

        async public void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); 
        }
    }

    //public class Conv<T> : IValueConverter
    //{
    //    public T TrueObject { set; get; }

    //    public T FalseObject { set; get; }

    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return (Meal)value??( new Meal());
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}


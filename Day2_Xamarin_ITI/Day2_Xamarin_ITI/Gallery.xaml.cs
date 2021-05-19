using Day2_Xamarin_ITI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2_Xamarin_ITI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gallery : CarouselPage
    {
        public ObservableCollection<Meal> Meals;

        public Gallery()
        {
            InitializeComponent();

            BindingContext = this;
            Meals = new ObservableCollection<Meal>()
        {
            new Meal(){Name= "Pizza", Image= "Pizza.jpg", Price= 80M },
            new Meal(){Name= "Chicken", Image= "Chicken.jpg", Price= 65M },
            new Meal(){Name= "Kabab", Image= "Kabab.jpg", Price= 140M },
            new Meal(){Name= "Koshary", Image= "Koshary.jpg", Price= 25M }

        };

            
            crs.ItemsSource = Meals;
            //BindingContext = Meals;
        }
    }
}
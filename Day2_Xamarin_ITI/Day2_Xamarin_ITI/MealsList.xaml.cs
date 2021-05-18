using Day2_Xamarin_ITI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2_Xamarin_ITI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealsList : ContentPage
    {
        public List<Meal> Meals;
        public MealsList()
        {
            InitializeComponent();

            Meals = new List<Meal>()
        {
            new Meal(){Name= "Pizza", Image= "Pizza.jpg", Price= 80M },
            new Meal(){Name= "Chicken", Image= "Chicken.jpg", Price= 65M },
            new Meal(){Name= "Kabab", Image= "Kabab.jpg", Price= 140M },
            new Meal(){Name= "Koshary", Image= "Koshary.jpg", Price= 25M }

        };

            lst.ItemsSource = Meals;
        }

        async private void lst_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((sender as ListView).SelectedItem == null) return;
            var meal = ((sender as ListView).SelectedItem as Meal);
            await Navigation.PushAsync(new Details(meal));
            lst.SelectedItem = null;
        }
    }
}
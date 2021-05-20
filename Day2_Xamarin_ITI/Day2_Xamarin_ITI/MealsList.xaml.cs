using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.Models;
using SQLite;
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
    public partial class MealsList : ContentPage
    {
        public ObservableCollection<Meal> Meals;
        private SQLiteAsyncConnection Con;

        async private void LoadfromDB()
        {

            await Con.CreateTableAsync<Meal>();

            
            var mealDB = await Con.Table<Meal>().ToListAsync();
            Meals = new ObservableCollection<Meal>(mealDB);



            // await Con.InsertAsync(new Meal() { Name = "Pizza", Image = "Pizza.jpg", Price = 80M });
            lst.ItemsSource = Meals;
        }
        async protected override void OnAppearing()
        {

            //Create table if not exist and retreive its data in Meals
            LoadfromDB();

            base.OnAppearing();
        }
        public MealsList()
        {
            InitializeComponent();
            Con = DependencyService.Get<ISQLiteDb>().GetConnection();


            Meals = new ObservableCollection<Meal>();
        //{
        //    new Meal(){Name= "Pizza", Image= "Pizza.jpg", Price= 80M },
        //    new Meal(){Name= "Chicken", Image= "Chicken.jpg", Price= 65M },
        //    new Meal(){Name= "Kabab", Image= "Kabab.jpg", Price= 140M },
        //    new Meal(){Name= "Koshary", Image= "Koshary.jpg", Price= 25M }

        //};

            lst.ItemsSource = Meals;
        }

        async private void lst_ItemTapped(object sender, ItemTappedEventArgs e)//prob?
        {
            if ((sender as ListView).SelectedItem == null) return;
            var meal = ((sender as ListView).SelectedItem as Meal);
            await Navigation.PushAsync(new Details(meal));
            lst.SelectedItem = null;
        }

        async private void Update_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdatePage() { BindingContext = ((sender as Button).Parent.BindingContext as Meal) });
            LoadfromDB();


        }

        async private void Delete_Clicked(object sender, EventArgs e)
        {
           // DisplayAlert( (sender as Meal).Name, (sender as Meal).Name, "ok");
            await Navigation.PushAsync(new DeletePage() { BindingContext=((sender as Button).Parent.BindingContext as Meal)});
            LoadfromDB();

        }
        async private void  Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
            LoadfromDB();
        }
    }
}
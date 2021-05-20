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
    public partial class Gallery : CarouselPage
    {
        public ObservableCollection<Meal> Meals;
        private SQLiteAsyncConnection Con;

        async protected override void OnAppearing()
        {



            //Create table if not exist and retreive its data in Meals
            await Con.CreateTableAsync<Meal>();
            var mealDB = await Con.Table<Meal>().ToListAsync();
            Meals = new ObservableCollection<Meal>(mealDB);

            // await Con.InsertAsync(new Meal() { Name = "Pizza", Image = "Pizza.jpg", Price = 80M });
            crs.ItemsSource = Meals;

            base.OnAppearing();
        }

        public Gallery()
        {
            InitializeComponent();

            Con = DependencyService.Get<ISQLiteDb>().GetConnection();


            BindingContext = this;
            Meals = new ObservableCollection<Meal>();
        

            
            crs.ItemsSource = Meals;
            //BindingContext = Meals;
        }
    }
}
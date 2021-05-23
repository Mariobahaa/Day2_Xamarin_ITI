using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.Models;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2_Xamarin_ITI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gallery : CarouselPage
    {
        public ObservableCollection<Player> Meals;
        //private SQLiteAsyncConnection Con;
        private HttpClient Client = new HttpClient();
        private String url = "https://localhost:4321/api/Players/";

        async protected override void OnAppearing()
        {



            //Create table if not exist and retreive its data in Meals
            var players = await Client.GetStringAsync(url);
            var conv = JsonConvert.DeserializeObject<List<Player>>(players);

            Meals = new ObservableCollection<Player>(conv);

            // await Con.InsertAsync(new Meal() { Name = "Pizza", Image = "Pizza.jpg", Price = 80M });
            crs.ItemsSource = Meals;

            base.OnAppearing();
        }

        public Gallery()
        {
            InitializeComponent();

            //Con = DependencyService.Get<ISQLiteDb>().GetConnection();
            Client = new HttpClient();

            BindingContext = this;
            Meals = new ObservableCollection<Player>();
        

            
            crs.ItemsSource = Meals;
            //BindingContext = Meals;
        }
    }
}
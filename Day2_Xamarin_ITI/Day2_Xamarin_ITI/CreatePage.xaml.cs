using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.Models;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2_Xamarin_ITI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        //private SQLiteAsyncConnection Con;

        private HttpClient Client = new HttpClient();
        private String url = "http://localhost:4321/api/Players/";
        public CreatePage()
        {
            InitializeComponent();
            //Con = DependencyService.Get<ISQLiteDb>().GetConnection();
            Client = new HttpClient();
            BindingContext = this;
        }

        async protected override void OnAppearing()
        {
            //await Con.CreateTableAsync<Player>();


            base.OnAppearing();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            Player p = new Player { Name = nm.Text, ShirtNumber = int.Parse(im.Text), ClubId = int.Parse(pr.Text) };
            var pl = JsonConvert.SerializeObject(p);
            var res = await Client.PostAsync(url, new StringContent(pl));
            //await Con.InsertAsync(new Player() { Name = nm.Text, Image = im.Text, Price = Convert.ToDecimal(pr.Text) });
            await Navigation.PopAsync();
        }
    }
}
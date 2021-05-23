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
    public partial class DeletePage : ContentPage
    {
        private HttpClient Client = new HttpClient();
        private String url = "http://localhost:4321/api/Players/";
        //private SQLiteAsyncConnection Con;
        public DeletePage()
        {
            InitializeComponent();
            Client = new HttpClient();
            //Con = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        async protected override void OnAppearing()
        {
            //await Con.CreateTableAsync<Player>();


            base.OnAppearing();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //await Con.DeleteAsync(BindingContext as Player);
            var res = await Client.DeleteAsync(url+(BindingContext as Player).Id);
            await Navigation.PopAsync();

        }
    }
}
using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.Models;
using SQLite;
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
    public partial class Login : ContentPage
    {
        private SQLiteAsyncConnection Con;

        public Login()
        {
            InitializeComponent();
            Con = DependencyService.Get<ISQLiteDb>().GetConnection();
            BindingContext = this;
        }

        async protected override void OnAppearing()
        {
            await Con.CreateTableAsync<User>();


            base.OnAppearing();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var user = await Con.Table<User>().Where(U => U.Username == nm.Text && U.Password == ps.Text).FirstOrDefaultAsync();
            if (user != null)
                await Navigation.PushAsync(new Menu());
            else 
            await DisplayAlert("Error", "Please try again using a different username or password", "OK");

        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
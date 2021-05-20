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
    public partial class Register : ContentPage
    {
        private SQLiteAsyncConnection Con;

        public Register()
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
            try
            {
                await Con.InsertAsync(new User() { Username = nm.Text, Password = ps.Text });
                await DisplayAlert("Success", "User Created Successfully", "OK");

                await Navigation.PushAsync(new Login());
            }
            catch
            {
                await DisplayAlert("Error", "Please try again using a different username or password", "OK");
            }

        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
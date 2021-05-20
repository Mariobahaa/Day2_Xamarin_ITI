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
    public partial class CreatePage : ContentPage
    {
        private SQLiteAsyncConnection Con;
        public CreatePage()
        {
            InitializeComponent();
            Con = DependencyService.Get<ISQLiteDb>().GetConnection();
            BindingContext = this;
        }

        async protected override void OnAppearing()
        {
            await Con.CreateTableAsync<Meal>();


            base.OnAppearing();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {

            await Con.InsertAsync(new Meal() { Name = nm.Text, Image = im.Text, Price = Convert.ToDecimal(pr.Text) });
            await Navigation.PopAsync();
        }
    }
}
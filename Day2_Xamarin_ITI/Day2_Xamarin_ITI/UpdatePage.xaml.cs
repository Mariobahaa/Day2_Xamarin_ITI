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
    public partial class UpdatePage : ContentPage
    {
        private SQLiteAsyncConnection Con;
        public UpdatePage()
        {
            InitializeComponent();
            Con = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        async protected override void OnAppearing()
        {
            await Con.CreateTableAsync<Meal>();


            base.OnAppearing();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Con.UpdateAsync(BindingContext as Meal);
            await Navigation.PopAsync();

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Day2_Xamarin_ITI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new NavigationPage(new Menu()));
            await Navigation.PushAsync(new NavigationPage(new Login()));

        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Register()));

        }
    }
}

﻿using FlagData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlagFacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFlagsPage : ContentPage
    {
        public AllFlagsPage()
        {
            BindingContext = DependencyService.Get<FlagDetailsViewModel>();
            
            InitializeComponent();
          
        }

        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await this.Navigation.PushAsync(new FlagDetailsPage());
        }
    }
}
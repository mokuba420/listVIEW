﻿using FlagData;
using Xamarin.Forms;

namespace FlagFacts
{
    public partial class AllFlagsPage : ContentPage
    {
        public AllFlagsPage()
        {
            BindingContext = DependencyService.Get<FlagDetailsViewModel>();
            InitializeComponent();
            BindingContext = DependencyService.Get<FlagDetailsViewModel>();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await this.Navigation.PushAsync(new FlagDetailsPage());
        }
   
        
    
    
    
    }
}
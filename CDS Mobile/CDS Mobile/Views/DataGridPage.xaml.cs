﻿using CDS_Mobile.ViewModels;

namespace CDS_Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataGridPage : ContentPage
    {
        public DataGridPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new DataGridViewModel();
            ViewModel.OnAppearing();
        }

        DataGridViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }
    }
}
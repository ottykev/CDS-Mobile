﻿using CDS_Mobile.ViewModels;
using CDS_Mobile.Views;
using System.Globalization;
using System.Reflection;
using System.Web;

namespace CDS_Mobile.Services
{
    public class NavigationService : INavigationService
    {

        public async Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel
        {
            await InternalNavigateToAsync(typeof(TViewModel), null, false);
        }

        public async Task NavigateToAsync<TViewModel>(bool isAbsoluteRoute) where TViewModel : BaseViewModel
        {
            await InternalNavigateToAsync(typeof(TViewModel), null, isAbsoluteRoute);
        }

        public async Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel
        {
            await InternalNavigateToAsync(typeof(TViewModel), parameter, false);
        }

        public async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

        async Task InternalNavigateToAsync(Type viewModelType, object parameter, bool isAbsoluteRoute = false)
        {
            var viewName = viewModelType.FullName.Replace("ViewModels", "Views").Replace("ViewModel", "Page");
            string absolutePrefix = isAbsoluteRoute ? "///" : String.Empty;
            if (parameter != null)
            {
                await Shell.Current.GoToAsync(
                    $"{absolutePrefix}{viewName}?id={HttpUtility.UrlEncode(parameter.ToString())}");
            }
            else
            {
                await Shell.Current.GoToAsync($"{absolutePrefix}{viewName}");
            }
        }
    }
}
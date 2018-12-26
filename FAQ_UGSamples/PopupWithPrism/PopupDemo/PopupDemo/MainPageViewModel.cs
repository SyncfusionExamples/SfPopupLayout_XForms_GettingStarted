using Prism.Navigation;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PopupDemo
{
    public class MainPageViewModel : INavigationAware
    {
        public INavigationService navigation_service;
        public ICommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            navigation_service = navigationService;
            NavigateCommand = new Command(Navigate);
        }

        private void Navigate()
        {
            navigation_service.NavigateAsync("SecondPage");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (App.Current.MainPage != null)
            {
                SfPopupLayout popup = new SfPopupLayout();
                popup.Show();
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}

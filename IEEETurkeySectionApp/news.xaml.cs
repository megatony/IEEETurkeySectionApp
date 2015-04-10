using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.WindowsAzure.MobileServices;
using IEEETurkeySectionApp.Classes;

namespace IEEETurkeySectionApp
{
    public partial class news : PhoneApplicationPage
    {
        protected IMobileServiceTable<News> table = App.MobileService.GetTable<News>();

        public news()
        {
            InitializeComponent();
            Get();
        }

        public async void Get()
        {
            list.ItemsSource = await table.ToListAsync();
        }


        private void list_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            App.currentNews = ((News)(sender as LongListSelector).SelectedItem);
            NavigationService.Navigate(new Uri("/newsDetails.xaml", UriKind.Relative));
        }

        private void committeeLogo_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void committeeLogo_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/news.xaml?refresh=true", UriKind.Relative));
        }
    }
}
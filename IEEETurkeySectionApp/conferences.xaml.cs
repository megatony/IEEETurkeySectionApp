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
    public partial class conferences : PhoneApplicationPage
    {
        protected IMobileServiceTable<Conferences> table = App.MobileService.GetTable<Conferences>();

        public conferences()
        {
            InitializeComponent();
            Get();
        }
        public async void Get()
        {
            list.ItemsSource = await table.ToListAsync();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.currentConference = ((Conferences)(sender as LongListSelector).SelectedItem);
            NavigationService.Navigate(new Uri("/conferenceDetails.xaml", UriKind.Relative));
        }

        private void committeeLogo_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void committeeLogo_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/conferences.xaml?refresh=true", UriKind.Relative));
        }
    }
}
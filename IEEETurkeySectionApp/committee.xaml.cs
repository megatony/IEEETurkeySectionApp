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
    public partial class committee : PhoneApplicationPage
    {
        protected IMobileServiceTable<Committee> table = App.MobileService.GetTable<Committee>();

        public committee()
        {
            InitializeComponent();
            Get();
        }
        public async void Get()
        {
            list.ItemsSource = await table.ToListAsync();
        }

        private void committeeLogo_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void committeeLogo_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("It's a list of student activities committee of Turkey section.");
        }
    }
}
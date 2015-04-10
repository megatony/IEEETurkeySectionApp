using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IEEETurkeySectionApp.Classes;
using Microsoft.WindowsAzure.MobileServices;

namespace IEEETurkeySectionApp
{
    public partial class stbranches : PhoneApplicationPage
    {
        protected IMobileServiceTable<StudentBranch> table = App.MobileService.GetTable<StudentBranch>();
        public stbranches()
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
            MessageBox.Show("This is a list that contains name, contact and president name information of all student chapters on Turkey section.");
        }
    }
}
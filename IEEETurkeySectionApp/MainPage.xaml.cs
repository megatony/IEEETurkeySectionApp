using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IEEETurkeySectionApp.Resources;
using System.Windows.Media;

namespace IEEETurkeySectionApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
        }

        private void studentBranchesLogo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stbranches.xaml", UriKind.Relative));
        }

        private void conferencesLogo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/conferences.xaml", UriKind.Relative));
        }

        private void newsLogo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/news.xaml", UriKind.Relative));
        }

        private void committeeLogo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/committee.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
       
    }
}
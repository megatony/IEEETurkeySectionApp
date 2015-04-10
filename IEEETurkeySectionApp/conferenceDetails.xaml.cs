using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace IEEETurkeySectionApp
{
    public partial class conferenceDetails : PhoneApplicationPage
    {
        public conferenceDetails()
        {
            InitializeComponent();
            name.Text = App.currentConference.name;
            organizer.Text = App.currentConference.organizer;
            date.Text = App.currentConference.date.ToString();
            content.Text = App.currentConference.content;
        }

        private void committeeLogo_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/conferences.xaml", UriKind.Relative));
        }

        private void committeeLogo_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/conferenceDetails.xaml?Refresh=true", UriKind.Relative));

        }
    }
}
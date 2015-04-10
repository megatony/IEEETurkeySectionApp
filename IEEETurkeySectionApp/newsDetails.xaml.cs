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
    public partial class newsDetails : PhoneApplicationPage
    {
        public newsDetails()
        {
            InitializeComponent();
            name.Text = App.currentNews.header;
            organizer.Text = App.currentNews.writer;
            date.Text = App.currentConference.date.ToString();
            content.Text = App.currentNews.content;
        }

        private void committeeLogo_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/news.xaml", UriKind.Relative));
        }

        private void committeeLogo_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/newsDetails.xaml?refresh=true", UriKind.Relative));
        }
    }
}
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
    public partial class Page1 : PhoneApplicationPage
    {
        protected IMobileServiceTable<News> table = App.MobileService.GetTable<News>();

        public Page1()
        {
            InitializeComponent();
        }

        private async void register_Click(object sender, RoutedEventArgs e)
        {
            register.IsEnabled = false;
            //Committee ayhan = new Committee
            //{
            //    name = "Ayhan Epik",
            //    title = "Turkey Section Student Representative",
            //    contact = "ayhan.epik@ieee.metu.edu.tr",
            //    picture = "http://eemuh.ogu.edu.tr/photo/bay.jpg"
            //};
            //await table.InsertAsync(ayhan);
            //Conferences gsa = new Conferences
            //{
            //    content = "Geçtiğimiz yıl altıncısı düzenlenen ve geleneksel hale getirdiğimiz etkinlik çerçevesinde, Türkiye'nin çeşitli üniversitelerinden gelen mühendislik öğrencileri ile sektörde söz sahibi firmaların temsilcileri ve kişisel gelişim uzmanları buluşturulmaktadır. Katılım gösteren dinleyicilerin kişisel gelişimine katkıda bulunmak ve geleceğini şekillendirmesine yardımcı olacak konular hakkında sunumlar yapılması planlanmaktadır. Şirketlerin kendilerini tanıtmaları amacıyla açılacak stantlarla; öğrenciler katılan şirketleri daha yakından tanıma fırsatı bulacaklardır. Amacımız öğrencilerin uzman kişilerin anlatımıyla istedikleri firmaları ve sektörleri rahatlıkla tanıyabilmesidir.",
            //    date = DateTime.UtcNow,
            //    name = "2 Günde Şirket-i Alem",
            //    organizer = "ESOGU IEEE"            
            //};
            News news = new News
            {
                content = "We are happy to announce that IEEE Turkey Section application that designed for IEEE madC contest is ready to download.",
                date = DateTime.Now,
                header = "Section App is ready!",
                writer = "Bahadır Akın Akgül"
            };
            await table.InsertAsync(news);
            register.IsEnabled = true;
        }

        
    }
}
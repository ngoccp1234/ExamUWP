using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ExamUWP.Model;
using ExamUWP.Entity;
using Contact = ExamUWP.Entity.Contact;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExamUWP
{
    public sealed partial class MainPage : Page
    {
   
        private ContactModel contactModel;

        public MainPage()
        {
            this.InitializeComponent();
            this.contactModel = new ContactModel();
        }


        private void Btn_AddContact(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = name.Text,
                NumberPhone = phone.Text
           
            };
            contactModel.Insert(contact);
            this.Frame.Navigate(this.GetType());
        }

        private void SearchContact(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

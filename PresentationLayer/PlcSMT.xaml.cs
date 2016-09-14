using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PresentationLayer.Models;
using PresentationLayer;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PresentationLayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlcSMT : Page
    {
        private List<Book> Books;
        public PlcSMT()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
            
            title.Text = "Police Salary More Than ";
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            bookTextBox1.Text = "You selected " + book.Title;
        }

        //public void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        //{
        //    string name = e.NavigationParameter as string;
        //    if (!string.IsNullOrWhiteSpace(name))
        //    {
        //        title.Text = "Police Salary More than " + name;
        //    }
        //}

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string value = e.Parameter as string;
            title.Text = "Police Salary More Than " + value;

        }



        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(queryPage));
        }

    }
}

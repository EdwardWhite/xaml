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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PresentationLayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class queryPage : Page
    {
        public List<Book> Books;
        public queryPage()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            bookTextBox.Text = "You selected " + book.Title;
        }

        private void comboBoxCreate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string getchxvalue = (comboBoxCreate.SelectedItem as ComboBoxItem).Content.ToString();
            if(getchxvalue == "Finance")
            {
                this.Frame.Navigate(typeof(CreatePage));
            }
        }

        private void searchButton1_Click(object sender, RoutedEventArgs e)
        {
            string getString = searchBox1.Text;
            //function for Police With Salary More Than
            //get the return result
            //e.g. List<Police> policeLst = return result
            if((getString != "") && (Books != null))
            {
               // string valueXX = searchBox1.Text;
                this.Frame.Navigate(typeof(PlcSMT), searchBox1.Text);
            }else
            {
                if(getString == "")
                {
                    var messageDialog = new MessageDialog("Books are not found!");
                    messageDialog.ShowAsync();
                }
            }
        }
    }
}

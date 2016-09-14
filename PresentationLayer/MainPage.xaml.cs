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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PresentationLayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;
        public MainPage()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
            //IEnumerable<Book> Books = tempBooks; 
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string uName = userNameBox.Text;
            string pWord = userPwordBox.TextReadingOrder.ToString();

            //Pass the variable to login function

            if ((uName == "A"))
            {
                this.Frame.Navigate(typeof(queryPage));
            }
            else
            {
                ResultTextBlock.Text = "Invalid Username or Password";
            }
        }

    }
}

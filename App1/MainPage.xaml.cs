using System.Collections.Generic;
using System.Linq;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger_SplitView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                PageTitle.Text = "Financial";
                MyFrame.Navigate(typeof(Financial));
            }
            else if (Favorites.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                PageTitle.Text = "Food";
                MyFrame.Navigate(typeof(Food));
            };
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                BackButton.Visibility = Visibility.Collapsed;
                PageTitle.Text = "Financial";
                Home.IsSelected = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Collapsed;
            PageTitle.Text = "Financial";
            MyFrame.Navigate(typeof(Financial));
            Home.IsSelected = true;
        }
    }
}

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _roast;
        private string _sweetener;
        private string _cream;

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void RoastMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            _roast = ((MenuFlyoutItem)sender).Text;
            _display();

        }

        private void SweetenerMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            _sweetener = ((MenuFlyoutItem)sender).Text;
            _display();

        }

        private void CreamMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            _cream = ((MenuFlyoutItem)sender).Text;
            _display();

        }

        private void _display()
        {
            if (_roast == "None" || string.IsNullOrEmpty(_roast))
            {
                CoffeeChoices.Text = "None";
                _sweetener = "";
                _cream = "";
                return;
            }

            CoffeeChoices.Text = _roast;

            if (_sweetener != "None" && !string.IsNullOrEmpty(_sweetener))
            {
                CoffeeChoices.Text += " + " + _sweetener;
            }

            if (_cream != "None" && !string.IsNullOrEmpty(_cream))
            {
                CoffeeChoices.Text += " + " + _cream;
            }
        }
    }
}

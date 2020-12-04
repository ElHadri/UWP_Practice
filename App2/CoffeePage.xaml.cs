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
        private bool _isRoast;

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void RoastMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            switch (((MenuFlyoutItem)sender).Name)
            {
                case "None_RoastMenuFlyoutItem":
                    //CoffeeChoices.Text = "None";
                    _isRoast = false;
                    break;
                case "Dark_RoastMenuFlyoutItem":
                    CoffeeChoices.Text = "Dark";
                    _isRoast = true;
                    break;
                case "Medium_RoastMenuFlyoutItem":
                    CoffeeChoices.Text = "Medium";
                    _isRoast = true;
                    break;
            }
        }

        private void SweetenerMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (_isRoast)
            {
                switch (((MenuFlyoutItem)sender).Name)
                {
                    case "None_SweetenerMenuFlyoutItem":
                        //CoffeeChoices.Text += ", None";
                        break;
                    case "Sugar_SweetenerMenuFlyoutItem":
                        CoffeeChoices.Text += ", Sugar";
                        break;
                }
            }
        }

        private void CreamMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (_isRoast)
            {
                switch (((MenuFlyoutItem)sender).Name)
                {
                    case "None_CreamMenuFlyoutItem":
                        //CoffeeChoices.Text += ", None";
                        break;
                    case "TwoPerCentMilk_CreamMenuFlyoutItem":
                        CoffeeChoices.Text += ", 2% Milk";
                        break;
                    case "WholeMilk_CreamMenuFlyoutItem":
                        CoffeeChoices.Text += ", Whole Milk";
                        break;
                }
            }
        }
    }
}

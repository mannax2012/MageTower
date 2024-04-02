using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MageTower
{
    /// <summary>
    /// Interaction logic for titlePage.xaml
    /// </summary>
    public partial class titlePage : Page
    {
        public titlePage()
        {
            InitializeComponent();
        }

        private void exitGameButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void startGameButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pages.newCharacterPage());
        }

        private void loadGameButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

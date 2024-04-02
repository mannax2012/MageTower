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
    /// Interaction logic for mainMenu.xaml
    /// </summary>
    public partial class mainMenu : Page
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        public void mainMenuTOCharacterSheet()
        {
            var secondPage = new pages.characterSheetPage
            {
                DataContext = this.DataContext
            };

            ContentFrame.Navigate(secondPage);
        }

        private void characterSheetButton_Click(object sender, RoutedEventArgs e)
        {
            mainMenuTOCharacterSheet();
        }
        private void ExitGameButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

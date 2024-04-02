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
using MageTower.models;
using MageTower.functions;

namespace MageTower.pages
{
    /// <summary>
    /// Interaction logic for newCharacterPage.xaml
    /// </summary>
    public partial class newCharacterPage : Page
    {
        public newCharacterPage()
        {
            InitializeComponent();
            DataContext = new newCharacterModel();
        }
        public void createCharacterTOMainMenu()
        {
            var secondPage = new mainMenu
            {
                DataContext = this.DataContext
            };

            NavigationService.Navigate(secondPage);
        }

        private void createCharButton_Click(object sender, RoutedEventArgs e)
        {
            createCharacterTOMainMenu();
        }
    }
}

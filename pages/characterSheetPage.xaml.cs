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

namespace MageTower.pages
{
    /// <summary>
    /// Interaction logic for characterSheetPage.xaml
    /// </summary>
    public partial class characterSheetPage : Page
    {
        public characterSheetPage()
        {
            InitializeComponent();
            addSkillPointOFF();
        }
        public void addSkillPointON()
        {
            addStrengthButton.IsEnabled = true;
            addStrengthButton.Visibility = Visibility.Visible;
            addDexterityButton.IsEnabled = true;
            addDexterityButton.Visibility = Visibility.Visible;
            addStaminaButton.IsEnabled = true;
            addStaminaButton.Visibility = Visibility.Visible;
            addFocusButton.IsEnabled = true;
            addFocusButton.Visibility = Visibility.Visible;
            addIntellectButton.IsEnabled = true;
            addIntellectButton.Visibility = Visibility.Visible;
            addWisdomButton.IsEnabled = true;
            addWisdomButton.Visibility = Visibility.Visible;
            TotalSPLabel.Visibility = Visibility.Visible;
            characterTotalSP.Visibility = Visibility.Visible;
        }
        public void addSkillPointOFF()
        {
            addStrengthButton.IsEnabled = false;
            addStrengthButton.Visibility = Visibility.Collapsed;
            addDexterityButton.IsEnabled = false;
            addDexterityButton.Visibility = Visibility.Collapsed;
            addStaminaButton.IsEnabled = false;
            addStaminaButton.Visibility = Visibility.Collapsed;
            addFocusButton.IsEnabled = false;
            addFocusButton.Visibility = Visibility.Collapsed;
            addIntellectButton.IsEnabled = false;
            addIntellectButton.Visibility = Visibility.Collapsed;
            addWisdomButton.IsEnabled = false;
            addWisdomButton.Visibility = Visibility.Collapsed;
            TotalSPLabel.Visibility = Visibility.Collapsed;
            characterTotalSP.Visibility = Visibility.Collapsed;
        }
    }
}

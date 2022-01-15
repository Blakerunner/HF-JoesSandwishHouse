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

namespace HF_JoesSandwishHouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[6];
            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[] { "bagel", "day-old bread", "pumpernickel" };
                }
                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].Description;
            item2.Text = menuItems[1].Description;
            item3.Text = menuItems[2].Description;
            item4.Text = menuItems[3].Description;
            item5.Text = menuItems[4].Description;
            item6.Text = menuItems[5].Description;

            price1.Text = menuItems[0].Price;
            price2.Text = menuItems[1].Price;
            price3.Text = menuItems[2].Price;
            price4.Text = menuItems[3].Price;
            price5.Text = menuItems[4].Price;
            price6.Text = menuItems[5].Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamole.Text = $"Add guacamole for {guacamoleMenuItem.Price}";
        }

        private void newMenu_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button newMenu)
            {
                MakeTheMenu();
            }
        }
    }
}

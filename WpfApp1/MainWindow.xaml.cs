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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boss boss;

        public MainWindow()
        {
            InitializeComponent();
            /*ListView1.Items.Add("Item 1");
            ListView1.Items.Add("Item 2");
            ListView1.Items.Add("Item 3");*/

            boss = (Boss)Application.Current.FindResource("employees_controller");
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(messageBoxText: ListView1.SelectedItem + " is selected.");
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            if(boss.GetViewableList().Count > 0)
            {
                boss.GetViewableList().RemoveAt(0);
            }
        }
    }
}

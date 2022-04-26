using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assig1
{
    /// <summary>
    /// Interaction logic for AddClass.xaml
    /// </summary>
    public partial class AddClass : Window
    {
        List<Group> groups;

        public AddClass()
        {
            InitializeComponent();
            groups = new List<Group>();

            //groups = Operations.LoadGroups();//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            groups.Add(new Group(5, "w5hst"));
            groups.Add(new Group(5, "stroih"));
            groups.Add(new Group(5, "aeriohj"));
            groups.Add(new Group(5, "rthn"));

            GroupNameComboBox.ItemsSource = groups;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ConfirmAddBtn_Click(object sender, RoutedEventArgs e)
        {
            //easy insert
            if(GroupNameComboBox.SelectedIndex == -1 || DayEntry.Text == "" || RoomEntry.Text == "" || StartEntry.Text == "" || EndEntry.Text == "")
            {
                MessageBox.Show("Please enter appropriate values.");
                return;
            }

            Random class_id; class_id = new Random();
            //Operations.AddClass(new class_instance(class_id.Next(), Int32.Parse(GroupNameComboBox.Text), DayEntry.Text, StartEntry.Text, EndEntry.Text, RoomEntry.Text));
            GroupNameComboBox.SelectedIndex = -1;
            DayEntry.Text = "";
            RoomEntry.Text = "";
            StartEntry.Text = "";
            EndEntry.Text = "";
        }
    }
}

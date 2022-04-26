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
    /// Interaction logic for Meetings.xaml
    /// </summary>
    public partial class Meetings : Window
    {
        List<Group> groups;

        public Meetings()
        {
            InitializeComponent();

            groups = new List<Group>();

            //groups = Operations.LoadGroups();//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            groups.Add(new Group(5,"w5hst"));
            groups.Add(new Group(5,"stroih"));
            groups.Add(new Group(5,"aeriohj"));
            groups.Add(new Group(5,"rthn"));

            MeetingsListView.ItemsSource = groups;
        }

        private void MeetingsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MeetingsListView.SelectedIndex == -1) return;
            EditMeeting new_window = new EditMeeting();
            new_window.Show();
            new_window.meeting_id = groups[MeetingsListView.SelectedIndex].group_id;
            this.Close();
        }
    }
}

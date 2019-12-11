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
using System.Collections.ObjectModel;

namespace FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Activities> AllActivities;
        ObservableCollection<Activities> CertainActivities = new ObservableCollection<Activities>();
        ObservableCollection<Activities> FilteredActivities = new ObservableCollection<Activities>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnadd_Click(object sender, RoutedEventArgs e)
        {
            listbox1.ItemsSource = ;

            bool interfere = false;
            Activities ChosenActivity = listbox1.SelectedItem as Activities;
            foreach (Activities activities in CertainActivities)
            {
                if (activities.Date == ChosenActivity.Date)
                {
                    interfere = true;
                    MessageBox.Show("You already have a full schedule for that day");
                }
            }
            if (interfere == false)
            {
                CertainActivities.Add(ChosenActivity);
                AllActivities.Remove(ChosenActivity);
            }

            if (Radio_All.IsChecked == true)
            {
                listbox1.ItemsSource = AllActivities;
            }
            else if (Radio_Land.IsChecked == true)
            {
                FilteredActivities.Clear();

                foreach (Activities act in AllActivities)
                {
                    if (act._ActivityType == Activities.ActivityType.Land)
                        FilteredActivities.Add(act);
                }

                listbox1.ItemsSource = FilteredActivities;
            }

            else if (Radio_Water.IsChecked == true)
            {
                FilteredActivities.Clear();

                foreach (Activities act in AllActivities)
                {
                    if (act._ActivityType == Activities.ActivityType.Water)
                        FilteredActivities.Add(act);
                }

                listbox1.ItemsSource = FilteredActivities;

            }

            else if (Radio_Air.IsChecked == true)
            {
                FilteredActivities.Clear();

                foreach (Activities act in AllActivities)
                {
                    if (act._ActivityType == Activities.ActivityType.Air)
                        FilteredActivities.Add(act);
                }

                listbox1.ItemsSource = FilteredActivities;
            }

            // Adds the total cost when items are added to listbox2

            total = total + ChosenActivity.Cost;
            cost.Text = total.ToString();
        }
    }
}

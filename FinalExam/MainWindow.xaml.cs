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
        ObservableCollection<Player> AllPlayers;
        ObservableCollection<Player> SelectedPlayers = new ObservableCollection<Player>();
        ObservableCollection<Player> Positions = new ObservableCollection<Player>();
        public MainWindow()
        {
            InitializeComponent();

            Player a = new Player("Adam", "Brennan", Player.Position.Goalkeeper, new DateTime(1979, 11, 30));
            Player b = new Player("Amelia", "Byrne", Player.Position.Defender, new DateTime(1978, 11, 25));
            Player c = new Player("Ava", "Daly", Player.Position.Midfielder, new DateTime(1977, 12, 04));
            Player d = new Player("Chloe", "Doyle", Player.Position.Midfielder, new DateTime(1975, 12, 07));
            Player z = new Player("Conor", "Dunne", Player.Position.Defender, new DateTime(1979, 12, 12));
            Player f = new Player("Daniel", "Fitzgerald", Player.Position.Midfielder, new DateTime(1979, 12, 18));
            Player g = new Player("Emily", "Kavanagh", Player.Position.Defender, new DateTime(1980, 12, 22));
            Player h = new Player("Emma", "Kelly", Player.Position.Forward, new DateTime(1981, 12, 23));
            Player i = new Player("Grace", "Lynch", Player.Position.Defender, new DateTime(1979, 01, 02));
            Player j = new Player("Hannah", "McCarthy", Player.Position.Defender, new DateTime(1978, 01, 02));
            Player k = new Player("Harry", "McDonagh", Player.Position.Forward, new DateTime(1979, 01, 02));
            Player l = new Player("Jack", "Murphy", Player.Position.Forward, new DateTime(1980, 01, 02));
            Player m = new Player("James", "Nolan", Player.Position.Defender, new DateTime(1981, 01, 02));
            Player n = new Player("Lucy", "O'Brien", Player.Position.Midfielder, new DateTime(1977, 01, 02));
            Player o = new Player("Luke", "O'Connor", Player.Position.Midfielder, new DateTime(1977, 01, 02));
            Player p = new Player("Mia", "O'Neill", Player.Position.Forward, new DateTime(1978, 01, 02));
            Player q = new Player("Michael", "O'Reilly", Player.Position.Forward, new DateTime(1979, 01, 02));
            Player r = new Player("Noah", "O'Sullivan", Player.Position.Forward, new DateTime(1977, 01, 02));
            Player s = new Player("Sean", "Ryan", Player.Position.Midfielder, new DateTime(1978, 01, 02));
            Player t = new Player("Sophie", "Walsh", Player.Position.Forward, new DateTime(1978, 01, 02));
            AllPlayers = new ObservableCollection<Player>();

            // Adding activities to listbox1 and removing them from listbox2

            AllPlayers.Add(a);
            AllPlayers.Add(b);
            AllPlayers.Add(c);
            AllPlayers.Add(d);
            AllPlayers.Add(z);
            AllPlayers.Add(f);
            AllPlayers.Add(g);
            AllPlayers.Add(h);
            AllPlayers.Add(i);
            AllPlayers.Add(j);
            AllPlayers.Add(k);
            AllPlayers.Add(l);
            AllPlayers.Add(m);
            AllPlayers.Add(n);
            AllPlayers.Add(o);
            AllPlayers.Add(p);
            AllPlayers.Add(q);
            AllPlayers.Add(r);
            AllPlayers.Add(s);
            AllPlayers.Add(t);

            listbox1.ItemsSource = AllPlayers;
            listbox2.ItemsSource = SelectedPlayers;

            listbox1.ItemsSource = AllPlayers.OrderBy(act => act.DateOfBirth);
        }

        private void Btnadd_Click(object sender, RoutedEventArgs e)
        {
            listbox1.ItemsSource = AllPlayers;

            bool interfere = false;
            Player ChosenPosition = listbox1.SelectedItem as Player;
            foreach (Player players in SelectedPlayers)
            {
                if (players._Position == ChosenPosition._Position)
                {
                    interfere = true;
                    MessageBox.Show($"Cannot add this player. Too many {Positions}");
                }
            }
            if (interfere == false)
            {
                SelectedPlayers.Add(ChosenPosition);
                AllPlayers.Remove(ChosenPosition);
            }

        }

        private void Listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player ChosenPosition = listbox2.SelectedItem as Player;

            if (ChosenPosition != null)
            {
                SelectedPlayers.Remove(ChosenPosition);
                AllPlayers.Add(ChosenPosition);
            }
        }
    }
}

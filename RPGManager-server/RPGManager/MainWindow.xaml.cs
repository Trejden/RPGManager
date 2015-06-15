using System;
using System.Data.SqlClient;
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

namespace RPGManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int players_amount;
        private int players_online;
        public bool database;
        public MainWindow()
        {
            this.players_amount = 0;
            this.players_online = 0;
            this.database = false;
            InitializeComponent();
            MessageBox.Show(" Przed rozpoczęciem pracy pamiętaj by \n załadować do programu Bazę Danych \n możesz załadowac gotową baze danych \n lub stworzyć nową przy użyciu przycisku \"Baza Danych\"");
        }

        private void Start_Button(object sender, RoutedEventArgs e)
        {
            if(players_online>0)
            {
                if(players_online==players_amount)
                {
                    textSession();
                }
                else
                {
                    //komunikat potwierdzajacy.
                }
            }
            else
            {
                MessageBox.Show(" Brak Zalogowanych graczy, \n Sesja nie może się rozpocząć");
                //komunikat że brak graczy
            }
            
        }

        private void ListaGraczy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void dataBaseButton(object sender, RoutedEventArgs e)
        {
            if(!database)
            {
                DataBaseOptions okno = new DataBaseOptions();
                okno.Show();
                this.database = true;
            }else
            {
                MessageBox.Show("Program ma już załadowaną baze danych, w przypadku problemów \nuruchom ponownie program i załaduj bazę danych jeszcze raz");
            }
            
        }

        private void textSession()
        {
            //sesja chatu
        }

        private void editCharacterbutton(object sender, RoutedEventArgs e)
        {

        }

        private void group_chat(object sender, RoutedEventArgs e)
        {

        }

        private void private_chat(object sender, RoutedEventArgs e)
        {

        }
    }
}

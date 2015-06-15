using System;
using System.IO;
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
using System.Windows.Shapes;

namespace RPGManager
{
    /// <summary>
    /// Interaction logic for DataBaseOptions.xaml
    /// </summary>
    public partial class DataBaseOptions : Window
    {
        public DataBaseOptions()
        {
            InitializeComponent();
        }

        private void create_Database(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader scriptfile = new System.IO.StreamReader("script.txt");
            string str=scriptfile.ReadToEnd();
            scriptfile.Close();
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            SqlCommand createscript = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                createscript.ExecuteNonQuery();
	            MessageBox.Show("Tworzenie Bazy Danych zakończono sukcesem.");
            }
            catch (System.Exception ex)
            {
	            MessageBox.Show("Nie udało się utworzyć Bazy danych - upewnij się że usługa Microsoft SQLServer jest uruchomiona, lub skontaktuj się z autorem oprogramowania", "Błąd");
            }
            finally
            {
	            if (myConn.State == System.Data.ConnectionState.Open)
	            {
	                myConn.Close();
	            }
            }
        }

        private void load_Database(object sender, RoutedEventArgs e)
        {

        }

        private void create_Database2(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectToDatabase(object sender, RoutedEventArgs e)
        {

        }
    }
}

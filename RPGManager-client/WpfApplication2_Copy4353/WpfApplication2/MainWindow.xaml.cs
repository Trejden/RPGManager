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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_FocusableChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_Click_3(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MenuItem_Click_4(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void PanelPisanie_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
        	 if (e.Key == Key.Return || e.Key == Key.Enter)
            {
                
                PanelPisanie.Clear();
            }
        }

        private void PanelPisanie_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	

   				PanelPisanie.Text = PanelPisanie.Text == "Napisz coś..." ? string.Empty : PanelPisanie.Text;
				
		}

        private void PanelPisanie_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelPisanie.Text = PanelPisanie.Text == string.Empty ? "Napisz coś..." : PanelPisanie.Text;
        }

        private void PanelRysowanie_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
        	 if (e.Key == Key.Return || e.Key == Key.Enter)
            {
                
              PanelRysowanie.Strokes.Clear();
            }
			
			if (e.Key == Key.Back)
			{
				//PanelRysowanie.Strokes.Remove(PanelRysowanie.Era);	
			}
        }

       
    }
}

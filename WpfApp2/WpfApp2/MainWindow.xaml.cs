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

namespace WpfApp2
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string rezultat =
            String.Format("Nakup {0} kart za {1} kupca: {2} za dogodek {3}",
            štKart.Value, status.Text, štKupca.Text, listaDogodkov.Text);
            MessageBox.Show(rezultat);
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

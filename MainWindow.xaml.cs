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

namespace EdPracticeDPM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Authorization()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void labelGuestEnter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _ = MessageBox.Show("LabelTouched");
        }
    }
}

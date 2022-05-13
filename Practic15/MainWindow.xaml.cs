using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Practic15
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

        static void InfoReceived()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Info Received");
        }

        static async void Connection()
        {
            MessageBox.Show("Connection");

            await Task.Factory.StartNew(InfoReceived);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(Connection);
            task.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Connection closed");
        }
    }
}

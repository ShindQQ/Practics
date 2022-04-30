using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace Practic3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStorage);

            StreamReader sr = new StreamReader(userStream);

            label.Content = sr.ReadLine();
            label.Background = (Brush)new BrushConverter().ConvertFrom(sr.ReadLine());

            sr.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Truncate, userStorage);

            label.Content = colorPicker.SelectedColorText;
            label.Background = (Brush)new BrushConverter().ConvertFrom(colorPicker.SelectedColorText);

            StreamWriter writer = new StreamWriter(userStream);
            writer.WriteLine(colorPicker.SelectedColorText);
            writer.WriteLine(colorPicker.SelectedColorText);
            writer.Close();
        }

        private void ColorPicker_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

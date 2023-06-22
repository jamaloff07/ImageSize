using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Image image = (Image)button.Content;
            statusBarImage.Source = image.Source;
        }
    }
}

using System;
using System.Net;
using System.Windows;

namespace hw
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                IPHostEntry hostAddress = Dns.GetHostByName(textBox.Text);
                foreach (var item in hostAddress.AddressList)
                {
                  ipAddressTextBox.Text += item.ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}

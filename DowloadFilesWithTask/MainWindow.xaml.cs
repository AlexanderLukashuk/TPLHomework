using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
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

namespace DowloadFilesWithTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WebClient client;
        public MainWindow()
        {
            InitializeComponent();

            client = new WebClient();
        }

        private void DownloadBook(object sender, RoutedEventArgs e)
        {
            LoadingWindow newWindow = new LoadingWindow(client);
            newWindow.Show();
            var task = Task.Run(() =>
            {
                client.DownloadFileAsync(new Uri("https://codernet.ru/media/%D0%AF%D0%B7%D1%8B%D0%BA%20%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F%20C%23%207/yazyk_programmirovaniya_c_7_i_platformy_net_i_net_core.pdf"), nameTextBox.Text);
                //client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(ClientDownloadDataCompleted);

                //client.DownloadFile("https://codernet.ru/media/%D0%AF%D0%B7%D1%8B%D0%BA%20%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F%20C%23%207/yazyk_programmirovaniya_c_7_i_platformy_net_i_net_core.pdf", nameTextBox.Text);
                //client.DownloadDataAsync()
            });
        }

        public WebClient GetClient()
        {
            return client;
        }

        static void ClientDownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            var calledBy = e.UserState; //This will be "YourIdentifier"
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            client.Dispose();
        }
    }
}

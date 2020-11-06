using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Timers;
using System.Net;

namespace DowloadFilesWithTask
{
    /// <summary>
    /// Логика взаимодействия для LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        public LoadingWindow(WebClient client)
        {
            InitializeComponent();

            while (client.IsBusy)
            {
                progressBar.Value += 10;
            }
            progressBar.Value = 100;

            //progressBar.Sta
        }

        private void CancelDowload(object sender, RoutedEventArgs e)
        {

        }
    }
}

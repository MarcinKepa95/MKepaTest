using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using System;

namespace Chapter_11_Application_1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            Timer.Tick += timer_Tick;
            Timer.Interval = TimeSpan.FromSeconds(.1);
        }
        int i = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            Progress.Text = (i++).ToString();
        }
        private async void CountButton_Click(object sender, RoutedEventArgs e)
        {
            countButton.IsEnabled = false;
            Timer.Start();
            if (useAwaitSync.IsChecked == true)
                await LongTaskAysnc();
            else
                LongTask();
            countButton.IsEnabled = true;
        }

        private void LongTask()
        {
            Thread.Sleep(5000);
            Timer.Stop();
        }

        private async Task LongTaskAysnc()
        {
            await Task.Delay(5000);
            Timer.Stop();
        }
    }
}

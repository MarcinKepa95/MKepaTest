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

namespace IfElseFun
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox.IsChecked == true)
            {
                if (label.Text == "Right")
                {
                    label.Text = "Left";
                    label.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    label.Text = "Right";
                    label.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
            else
            {
                label.Text = "Press the button to set my text";
                label.HorizontalAlignment = HorizontalAlignment.Center;
            }

        }
    }
}

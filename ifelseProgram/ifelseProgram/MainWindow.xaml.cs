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

namespace ifelseProgram
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if((bool)Checkbox1.IsChecked)
            {
                if (textBlock.Text == "Right")
                {
                    textBlock.Text = "Left";
                    textBlock.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    textBlock.Text = "Right";
                    textBlock.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
            else
            {
                textBlock.Text = "Text cannot be changed";
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}

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

namespace RealWorkApp
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
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "Nazwa to " + name + "\nx jest równe " + x + "\nd jest równe " + d;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x==10)
            {
                myLabel.Text = "X musi być równe 10!";
            }
            else
            {
                myLabel.Text = "X nie jest równe 10!";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Krzysiek";
            if((someValue==3) && (name.Equals("Janek")))
            {
                myLabel.Text = "someValue jest równe 3 i name jest równe Janek";
            }
            myLabel.Text = "ten wiersz jest wykonywany bez względu na warunki!";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while(count<10)
            {
                count++;
            }
            for(int i=0; i<5; i++)
            {
                count--;
            }

            myLabel.Text = "Odpowiedź brzmi " + count;
        }
    }
}

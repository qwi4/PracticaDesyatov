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

namespace PracticaDesyatov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1(object sender, RoutedEventArgs e)
        {
            FrameTask1 frameTask1 = new FrameTask1();
            frameTask1.Show();
        }

        private void Task2(object sender, RoutedEventArgs e)
        {
            FrameTask2 frameTask2 = new FrameTask2();
            frameTask2.Show();
        }

        private void Task3(object sender, RoutedEventArgs e)
        {
            FrameTask3 frameTask3 = new FrameTask3();
            frameTask3.Show();
        }

        private void Task4(object sender, RoutedEventArgs e)
        {
            FrameTask4 frameTask4 = new FrameTask4();
            frameTask4.Show();
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

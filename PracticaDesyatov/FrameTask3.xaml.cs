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
using System.Windows.Shapes;
using ClassLibrary1;

namespace PracticaDesyatov
{
    /// <summary>
    /// Логика взаимодействия для FrameTask3.xaml
    /// </summary>
    public partial class FrameTask3 : Window
    {
        public FrameTask3()
        {
            InitializeComponent();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        int[,] matrix;
        private void initMassiveClick(object sender, RoutedEventArgs e)
        {
            try
            {

                matrix = new int[1, Int32.Parse(massiveLengthText.Text)];
                Random random = new();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(-10, 10);

                    }
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("что-то не так возможно вы не создали массив");
            }
        }

        private void SolutionTask3(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(" " + ClassTask3.FindNumberCloseToAverage(matrix));

            }
            catch (Exception)
            {

                MessageBox.Show("что-то не так, возможно вы не создали массив");
            }
        }

    }
}



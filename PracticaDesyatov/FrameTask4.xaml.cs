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
    public partial class FrameTask4 : Window
    {
        public FrameTask4()
        {
            InitializeComponent();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int[,] matrix;
        private void initINTMassiveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                matrix = new int[Int32.Parse(massiveColumnsText.Text), Int32.Parse(massiveRowsText.Text)];
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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SolutionTask4(object sender, RoutedEventArgs e)
        {
            int[] massive;
            try
            {
                string x = " ";
                massive = ClassTask4.SwitchSmallestAndLargestNumber(matrix);
                for (int i = 0; i < massive.Length; i++)
                {
                    x += massive[i] + " ";
                }
                MessageBox.Show(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("что-то пошло не так, возможно вы не создали матрицу");
            }
        }
    }
}

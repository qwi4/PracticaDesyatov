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
    
    public partial class FrameTask2 : Window
    {
        public FrameTask2()
        {
            InitializeComponent();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SolutionTask2(object sender, RoutedEventArgs e)
        {
            ClassTask2 task2 = new ClassTask2();
            int[] mas = new int[3];

            try
            {
                mas[0] = Int32.Parse(firstNumber.Text);
                mas[1] = Int32.Parse(secondNumber.Text);
                mas[2] = Int32.Parse(thirdNumber.Text);
                MessageBox.Show(" " + task2.SolutionTask2(mas));

            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка, возможно вы ввели не правильные данные");
            }
        }
    }
}

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
    /// Логика взаимодействия для FrameTask1.xaml
    /// </summary>
    public partial class FrameTask1 : Window
    {
        public FrameTask1()
        {
            InitializeComponent();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void SolutionTask1(object sender, RoutedEventArgs e)
        {
            ClassTask1 task1 = new ClassTask1();
            try
            {
                int i = 0;
                int numForCount = Int32.Parse(number.Text);
                int num = Int32.Parse(number.Text);
                while (numForCount > 0)
                {
                    i++;
                    numForCount /= 10;
                }
                if (i == 3)
                {
                    i = 0;
                    if (task1.SolutionTask1(num))
                    {
                        MessageBox.Show("Сумма цифр числа является двузначным числом");
                    }
                    else MessageBox.Show("Сумма цифр числа не является двузначным числом");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибочка, исправить бы что-то");
            }
        }
    }
}

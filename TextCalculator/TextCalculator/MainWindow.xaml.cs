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

namespace TextCalculator
{
    public partial class MainWindow : Window
    {
        private void ConcatenatedString(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = textBox1.Text + textBox2.Text;
        }
    }
}

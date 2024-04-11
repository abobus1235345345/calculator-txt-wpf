using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TextCalculator
{
    public partial class MainWindow : Window
    {
        private string resultFilePath;

        public MainWindow()
        {
            InitializeComponent();
            resultFilePath = "Results\\result.txt";
        }

        private void ConcatenateStrings(object sender, RoutedEventArgs e)
        {
            string concatenatedString = textBox1.Text + textBox2.Text;
           resultTextBox.Text = concatenatedString;

            try
            {
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string resultDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Results");
                if (!Directory.Exists(resultDirectory))
                {
                    Directory.CreateDirectory(resultDirectory);
                }
                string resultFileName = $"result_{currentTime}.txt";
                string resultFilePath = Path.Combine(resultDirectory, resultFileName);

                File.WriteAllText(resultFilePath, concatenatedString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
    }
}

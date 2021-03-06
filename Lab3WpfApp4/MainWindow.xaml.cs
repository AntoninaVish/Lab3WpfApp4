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

namespace Lab3WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox!=null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
           
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textBox!=null)
            {
                double fontSize=Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox.FontSize = fontSize;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)//если жирность текста соответсвует нормальной
            {

                textBox.FontWeight = FontWeights.Bold; // то присваиваем жирность текста
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;// если не соответствует тогда устанавливаем "нормальный" 
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal) //если наклон текста соответсвует нормальному
            {

                textBox.FontStyle = FontStyles.Italic; // то присваиваем наклон текста
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;// если не соответствует тогда устанавливаем "нормальный" 
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // это первый вариант с подчеркиванием
            
            if (textBox.TextDecorations.Count == 0)
            {
                textBox.TextDecorations.Add(TextDecorations.Underline); //текст с подчеркиванием
            }
            else
            {
                textBox.TextDecorations.RemoveAt(0); // удаляем подчеркивание
            }

            // это второй вариант с подчеркиванием

            //if (textBox.TextDecorations == null)
            //{
            //    textBox.TextDecorations = TextDecorations.Underline;//вместо null присваиваем коллецкию состоящую из одного подчеркивания
            //}
            //else
            //{
            //    textBox.TextDecorations = null;
            //}
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {


        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }

        }
    }
    
}

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
using static AppAnt1.Window1;

namespace AppAnt1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void OrderDone_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string place = TextBoxPlace.Text;
            string number = TextBoxNumber.Text;
            string date = TextBoxDate.Text;

            // Сравниваем с правильными значениями
            if (place == "White House" && number == "89520284014" && date =="28.12.2024")
            {
                MessageBox.Show("Заказ оформлен!");
            }
            if (place != "White House")
            {
                MessageBox.Show("Доставка на этот адрес не осуществляется."); // Сообщение об ошибке
            }
            if (number != "89520284014")
            {
                MessageBox.Show("Такого номера телефона не существует."); // Сообщение об ошибке
            }
            if (date != "28.12.2024")
            {
                MessageBox.Show("Доставка на этот день недоступна."); // Сообщение об ошибке
            }
        }
    }
}

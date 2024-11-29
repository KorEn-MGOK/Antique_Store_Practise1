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
using System.Windows.Threading;

namespace AppAnt1
{
    /// <summary> 
    /// Логика взаимодействия для Window1.xaml 
    /// </summary> 
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
            public static class GlobalVariables
            {
                public static int A { get; set; }
                public static int B { get; set; }
                public static int C { get; set; }
                public static int D { get; set; }
                public static int E { get; set; }
                public static int F { get; set; }
                public static int G { get; set; }
                public static int H { get; set; }
            }

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string password = TextBoxPassword.Text;
            string email = TextBoxEmail.Text;

            // Сравниваем с правильными значениями
            if (password == "Z12345678z" && email == "Admin@gmail.com")
            {
                // Устанавливаем значение глобальной переменной A
                GlobalVariables.A = 1; // Пример значения, которое вы хотите установить
                this.Close(); // Закрываем текущее окно (если нужно)
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль."); // Сообщение об ошибке
            }
        }
    }
}
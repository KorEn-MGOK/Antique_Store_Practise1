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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Money = 0; // Пример инициализации
        }

        public int Money { get; set; } // Объявляем свойство Money
        public event Action<int> MoneyUpdated; // Событие для обновления Money
        private int Cost0 = 200000;
        private int Cost1 = 300000;
        private int Cost2 = 1000000;
        private int Cost3 = 3500000;
        private int Cost4 = 5000000;
        private int Cost5 = 25500000;
        private int Cost6 = 30000000;
        
        private void Buy0_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.B = 1;
            Money += Cost0; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.B == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
        private void Buy1_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.C = 1;
            Money += Cost1; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.C == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
        private void Buy2_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.D = 1;
            Money += Cost2; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.D == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
            private void Buy3_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.E = 1;
            Money += Cost3; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.E == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
        private void Buy4_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.F = 1;
            Money += Cost4; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.F == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
        private void Buy5_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.G = 1;
            Money += Cost5; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.G == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
            
        }
        private void Buy6_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для обработки нажатия кнопки
            GlobalVariables.H = 1;
            Money += Cost6; // Обновляем значение Money
            MoneyUpdated?.Invoke(Money); // Вызываем событие
            MessageBox.Show("Товар добавлен в корзину!");
            if (GlobalVariables.H == 1)
            {
                MessageBox.Show("Товар закончился.");
            }
        }
    }
}

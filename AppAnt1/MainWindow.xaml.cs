using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using static AppAnt1.Window1;
using static AppAnt1.Window2;

namespace AppAnt1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int Money;

        private void localModeBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show(); // Открываем новое окно
        }

        private void Catalogue_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVariables.A == 1)
            {
                Window2 window2 = new Window2();
                window2.MoneyUpdated += OnMoneyUpdated; // Подписываемся на событие
                window2.Show(); // Открываем новое окно
            }
            else
            {
                MessageBox.Show("Пройдите регистрацию."); // Сообщение об ошибке
            }
        }

        private void OnMoneyUpdated(int money)
        {
            Sum.Text = $"Заказ на сумму: {money}"; // Обновляем TextBox Sum
        }

        private void Busket_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVariables.B != 1
               && GlobalVariables.C != 1
               && GlobalVariables.D != 1
               && GlobalVariables.E != 1
               && GlobalVariables.F != 1
               && GlobalVariables.G != 1
               && GlobalVariables.H != 1)
            {
                MessageBox.Show("У вас нету товаров в корзине."); // Сообщение об ошибке 
            }
            else
            {
                Sum.Text = $"Заказ на сумму: {Money}";
            }
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVariables.A == 1)
            {
                Window3 window3 = new Window3();
                window3.Show(); // Открываем новое окн
            }
            else
            {
                MessageBox.Show("Пройдите регистрацию."); // Сообщение об ошибке
            }            
        }
    }
}

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

namespace BackpackProblem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int maxWeight;                                                               // Максимальный вес
        Backpack back = new Backpack();                                                     // Объект класса с реализацией логики задачи
        List<Item> items = new List<Item>();                                                // Список предметов

        public MainWindow()
        {
            InitializeComponent();                                                          // Инициализация компонентов

            items.Add(new Item() { Name = "Маска", Price = 50, Weigth = 170 });             // Добавление предмета
            items.Add(new Item() { Name = "Наушники", Price = 150, Weigth = 200 });         // Добавление предмета
            items.Add(new Item() { Name = "Паспорт", Price = 100, Weigth = 400 });          // Добавление предмета
            items.Add(new Item() { Name = "Зарядка", Price = 350, Weigth = 300 });          // Добавление предмета
            items.Add(new Item() { Name = "Повербанк", Price = 120, Weigth = 100 });        // Добавление предмета
            items.Add(new Item() { Name = "Кошелёк", Price = 100, Weigth = 2000 });         // Добавление предмета
            items.Add(new Item() { Name = "Телефон", Price = 400, Weigth = 3500 });         // Добавление предмета

            itemsGrid.ItemsSource = items;                                                  // Вывод предметов в таблицу
        }

        /// <summary>
        /// Логика для кнопки, сохранящей вес рюкзака
        /// </summary>
        private void ButtonforMW_Click(object sender, RoutedEventArgs e)
        {
            maxWeight = int.Parse(EnterMW.Text);
            EnterMaxWeight.Content = $"Вес рюкзака = {maxWeight}";                          // Оповещение о введении веса рюкзака
        }

        /// <summary>
        /// Логика для кнопки, вычисляющей вес предметов
        /// </summary>
        private void EnterNext_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = back.Calculate(maxWeight, items).ToString();                      // Вывод подсчитанного веса лучшего набора предметов
        }
    }
}

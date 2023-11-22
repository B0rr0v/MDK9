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

namespace MDK9
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

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Даниил ИСП-31 Практическая работа №9:Заполнить таблицу со списком сотрудников на 7 человек с полями: ФИО, пол,\r\nдолжность, стаж работы, оклад. Вывести результат на экран. Вывести средний оклад.");
        }

        private void start(object sender, RoutedEventArgs e)
        {           
            Employees employees1 = new Employees("Петров Александр Васильевич", "М", "Программист", 2, 15700);
            Employees employees2 = new Employees("Дрынкин Антон Витальевич", "М", "Преподаватель", 3, 10800);
            Employees employees3 = new Employees("Байрамов Тимур Равшанович", "М", "Менеджер", 8, 20000);
            Employees employees4 = new Employees("Байрамов Руслан Равшанович", "М", "Секретарь", 1, 9600);
            Employees employees5 = new Employees("Рубан Георгий Михайлович", "М", "Дворник", 2, 5450);
            Employees employees6 = new Employees("Викторов Дмитрий Олегович", "М", "Охраник", 4, 17630);
            Employees employees7 = new Employees("Якунина Татьяна Георгиевна", "Ж", "Заместитель директора", 1, 15200);
            gd.Items.Add(employees1);
            gd.Items.Add(employees2);
            gd.Items.Add(employees3);
            gd.Items.Add(employees4);
            gd.Items.Add(employees5);
            gd.Items.Add(employees6);
            gd.Items.Add(employees7);
            
            double avgOklad = 0;
            int employeeCount = gd.Items.Count;// кол-во сотрудников
            foreach (Employees employees in gd.Items)
            {
                avgOklad += employees.Oklad; 
            }
            avgOklad /= employeeCount;
            double avgOklad2 = Math.Round(avgOklad);//округление
            tb1.Text = avgOklad2.ToString();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            gd.Items.Clear();
        }
    }
}

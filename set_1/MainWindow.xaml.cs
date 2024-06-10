using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Configuration;


namespace set_1
{
    public partial class MainWindow : Window
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlDataAdapter adapter;
        DataTable AeroportTable;
        SqlConnection connection = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BDD_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CRUD(1);
            window.Show();

        }
        private void Tabl_Click(object sender, RoutedEventArgs e)
        {
            string choiceText = TablName.Text;

            // Пробуем преобразовать текст в число
            if (int.TryParse(choiceText, out int choice))
            {
                // Проверяем, находится ли число в диапазоне от 1 до 3
                if (choice >= 1 && choice <= 3)
                {
                    switch (choice)
                    {
                        case 1:
                            Window1 window1 = new Window1();
                            window1.Show();
                            this.Hide();
                            break;
                        case 2:
                            Window2 window2 = new Window2();                          
                            window2.Show();                          
                            this.Hide();
                            break;
                        case 3:
                            Window3 window3 = new Window3();                         
                            window3.Show();                           
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверное число. Введите число от 1 до 3.");
                }
            }
            else
            {
                MessageBox.Show("Неверный формат. Введите число.");
            }
        }
    }
}
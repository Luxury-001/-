using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace set_1
{
    /// <summary>
    /// Логика взаимодействия для Chan.xaml
    /// </summary>
    public partial class Chan : Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlDataAdapter adapter;
        DataTable AeroportTable;
        SqlConnection connection = null;
        public Chan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получение данных из текстовых полей
            string serverName = ServerName.Text;
            string databaseName = DatabaseName.Text;
            string userName = UserName.Text;
            string password = Password.Text;

            // Проверка на пустые значения
            if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(databaseName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            // Создание строки подключения
            string connectionString = $"Server={serverName};Database={databaseName};User ID={userName};Password={password};";
            // Тестовое подключение к базе данных
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Подключение успешно установлено!");

                    // Сохранение строки подключения (например, в файл конфигурации)
                    // ...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }
    }
}

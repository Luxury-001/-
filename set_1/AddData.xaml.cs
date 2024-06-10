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
using System.Net;

namespace set_1
{
    /// <summary>
    /// Логика взаимодействия для AddData.xaml
    /// </summary>
    public partial class AddData : Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlDataAdapter adapter1, adapter2, adapter3;
        DataTable AeroportTable, AirlineTable, FlightTable;
        SqlConnection connection = null;
        public AddData()
        {
            InitializeComponent();
        }
        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.ShowDialog();
            string choiceText = MainWindow.TablName.Text;
            if (int.TryParse(choiceText, out int choice))
            {
                // Проверяем, находится ли число в диапазоне от 1 до 3
                if (choice >= 1 && choice <= 3)
                {
                    switch (choice)
                    {
                        case 1:
                            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(city_box.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"Insert into values(";
                            try
                            {
                                connection = new SqlConnection(connectionString);
                                connection.Open();
                                SqlCommand command1 = new SqlCommand(sql1, connection);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Данные обновлены");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                if (connection != null)
                                    connection.Close();
                            }
                            break;
                        case 2:
                            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(city_box.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"Insert into values(";
                            try
                            {
                                connection = new SqlConnection(connectionString);
                                connection.Open();
                                SqlCommand command1 = new SqlCommand(sql1, connection);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Данные обновлены");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                if (connection != null)
                                    connection.Close();
                            }
                            break;

                        case 3:
                            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(city_box.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"Insert into values(,)";
                            try
                            {
                                connection = new SqlConnection(connectionString);
                                connection.Open();
                                SqlCommand command1 = new SqlCommand(sql1, connection);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Данные обновлены");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                if (connection != null)
                                    connection.Close();
                            }

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

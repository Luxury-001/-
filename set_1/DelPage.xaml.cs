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
    /// Логика взаимодействия для DelPage.xaml
    /// </summary>
    public partial class DelPage : Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlDataAdapter adapter;
        DataTable AeroportTable;
        SqlConnection connection = null;
        public DelPage()
        {
            InitializeComponent();
        }
        //$"delete from Airplanes where ({iddel.Text}) = airplane_id"
        private void del_btn_Click(object sender, RoutedEventArgs e)
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
                            if (string.IsNullOrEmpty(iddel.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"delete from Airplanes where ({iddel.Text}) = airplane_id";
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
                            if (string.IsNullOrEmpty(iddel.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"..";
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
                            if (string.IsNullOrEmpty(iddel.Text))
                            {
                                MessageBox.Show("Не все поля заполнены");
                                return;
                            }
                            string sql1 = $"..";
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

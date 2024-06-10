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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SqlDataAdapter adapter;
        DataTable PlayTable;
        SqlConnection connection = null;
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Window2()
        {
            InitializeComponent();
        }

        private void con_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Play";
            PlayTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertPhone", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Play_id", SqlDbType.Int, 0, "Play_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@play_name", SqlDbType.NVarChar, 100, "play_name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Date, 0, "price"));
            
                connection.Open();
                adapter.Fill(PlayTable);
                MainDG.ItemsSource = PlayTable.DefaultView;
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
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CRUD2(1);
            window.Show();

        }

        private void del_btn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CRUD2(2);
            window.Show();
        }

        private void upd_btn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CRUD2(3);
            window.Show();
        }
        private void acc_btn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CRUD2(4);
            window.Show();
        }
    }
}

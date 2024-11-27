using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Technoservice
{
    public partial class AdminMenu : Form
    {
        public static AdminMenu Instance { get; } = new AdminMenu();
        private string connectionString = @"Data Source=DESKTOP-DFJ77GS;Initial Catalog=Remont;Integrated Security=True;MultipleActiveResultSets=True";
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string sql = "SELECT TOP (1000) [order_id], [order_techtype], [order_techmodel], [order_startdate], [start_problemdesc], [order_status], [order_compdate], [client_id], [empl_id] FROM [Remont].[dbo].[orders]"; // SQL-запрос для загрузки данных о заказах

        public AdminMenu()
        {
            InitializeComponent();
        }

        // Загружаем данные синхронно
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            LoadData(); // Загрузка данных при запуске формы
        }

        // Метод для загрузки данных из базы в DataGridView
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string techTypeInput = textBoxTechType.Text;
            string techModelInput = textBoxTechModel.Text;
            string startDateInput = textBoxStartDate.Text;
            string problemDesc = textBoxProblemDesc.Text;
            string orderStatus = textBoxOrderStatus.Text;

            // Проверяем введенные данные
            if (string.IsNullOrEmpty(techTypeInput))
            {
                MessageBox.Show("Введите тип техники.");
                return;
            }

            if (string.IsNullOrEmpty(techModelInput))
            {
                MessageBox.Show("Введите модель техники.");
                return;
            }

            if (string.IsNullOrEmpty(startDateInput) || !DateTime.TryParse(startDateInput, out DateTime startDate))
            {
                MessageBox.Show("Некорректная дата начала.");
                return;
            }

            if (string.IsNullOrEmpty(problemDesc))
            {
                MessageBox.Show("Введите описание проблемы.");
                return;
            }

            if (string.IsNullOrEmpty(orderStatus))
            {
                MessageBox.Show("Введите статус заказа.");
                return;
            }

            // Добавляем заказ
            AddOrder(techTypeInput, techModelInput, startDate, problemDesc, orderStatus);

            // Обновляем данные после добавления
            LoadData();
        }
        // Метод для добавления нового заказа (без указания order_id)
        private void AddOrder(string techType, string techModel, DateTime startDate, string problemDesc, string orderStatus)
        {
            string insertSql = @"
        INSERT INTO orders (order_techtype, order_techmodel, order_startdate, start_problemdesc, order_status) 
        VALUES (@techType, @techModel, @startDate, @problemDesc, @orderStatus)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                {
                    // Добавляем параметры запроса
                    insertCommand.Parameters.AddWithValue("@techType", techType);
                    insertCommand.Parameters.AddWithValue("@techModel", techModel);
                    insertCommand.Parameters.AddWithValue("@startDate", startDate);
                    insertCommand.Parameters.AddWithValue("@problemDesc", problemDesc);
                    insertCommand.Parameters.AddWithValue("@orderStatus", orderStatus);

                    // Выполняем вставку данных в таблицу
                    int numberOfInsertedRows = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"Добавлено объектов: {numberOfInsertedRows}");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

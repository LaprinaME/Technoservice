using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technoservice
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-DFJ77GS;Initial Catalog=Remont;Integrated Security=True;TrustServerCertificate=True;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Проверка логина и пароля
            string roleCode = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(roleCode))
            {
                MessageBox.Show("Авторизация успешна.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Перенаправление в зависимости от роли
                Form nextForm = GetNextFormByRole(roleCode);
                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide(); // Скрыть текущую форму
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            string query = "SELECT empl_role FROM employees WHERE empl_login = @login AND empl_pass = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", username);
                    command.Parameters.AddWithValue("@password", password);

                    // Получение кода роли пользователя
                    object result = command.ExecuteScalar();

                    // Если результат не пустой, возвращаем роль пользователя
                    return result?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private Form GetNextFormByRole(string roleCode)
        {
            switch (roleCode)
            {
                case "1": // Администратор
                    return new AdminMenu();
                case "2": // Работник
                    return new WorkerMenu();
                default:
                    MessageBox.Show("Неизвестный код роли", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }
    }
}

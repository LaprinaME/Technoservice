using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Technoservice
{
    public partial class RegisterForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-DFJ77GS;Initial Catalog=Remont;Integrated Security=True;TrustServerCertificate=True;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string emplSnp = emplSnpTextBox.Text;
            string emplPhone = emplPhoneTextBox.Text;
            string emplLogin = emplLoginTextBox.Text;
            string emplPass = emplPassTextBox.Text;
            string emplRole = emplRoleTextBox.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(emplSnp) || string.IsNullOrEmpty(emplPhone) || string.IsNullOrEmpty(emplLogin) || string.IsNullOrEmpty(emplPass) || string.IsNullOrEmpty(emplRole))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Попытка регистрации пользователя
            if (RegisterUser(emplSnp, emplPhone, emplLogin, emplPass, emplRole))
            {
                MessageBox.Show("Регистрация прошла успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // После регистрации получаем форму в зависимости от роли
                Form nextForm = GetNextFormByRole(emplRole);
                if (nextForm != null)
                {
                    nextForm.Show();  // Открытие соответствующей формы
                    this.Hide();      // Скрыть текущую форму
                }
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для регистрации пользователя в базе данных
        private bool RegisterUser(string emplSnp, string emplPhone, string emplLogin, string emplPass, string emplRole)
        {
            string query = "INSERT INTO employees (empl_snp, empl_phone, empl_login, empl_pass, empl_role) VALUES (@emplSnp, @emplPhone, @emplLogin, @emplPass, @emplRole)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@emplSnp", emplSnp);
                    command.Parameters.AddWithValue("@emplPhone", emplPhone);
                    command.Parameters.AddWithValue("@emplLogin", emplLogin);
                    command.Parameters.AddWithValue("@emplPass", emplPass);
                    command.Parameters.AddWithValue("@emplRole", emplRole);  // Роль пользователя

                    int rowsAffected = command.ExecuteNonQuery();

                    // Если строки были добавлены, то регистрация прошла успешно
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Метод для получения формы в зависимости от роли
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

        private void emplSnpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplRoleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

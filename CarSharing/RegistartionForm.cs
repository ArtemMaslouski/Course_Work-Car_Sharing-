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
using CarSharing.control;

namespace CarSharing
{
    public partial class RegistartionForm : Form
    {
        DB db = new DB();
        private void addDataToDB(string login,string password)
        {
            db.openConnection();

            string query = $"INSERT INTO LoginAndPassword (Login,Password) VALUES (N'{login}',N'{password}')";
            SqlCommand command = new SqlCommand(query,db.GetConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был успешно создан!");
            }

            //Очистка объектов после успешного создания аккаунта
            LoginRegistartionTextBox.Clear();
            RepeatPasswordRegistartionFormTextBox.Clear();
            PasswordRegistrationFormTextBox.Clear();
            

            db.closeConnection();
        }
        public RegistartionForm()
        {
            InitializeComponent();
        }

        private void ExitButtonRegistrationForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            //Запись из TextBox в переменную
            string loginUser = LoginRegistartionTextBox.Text;
            string passwordUser =PasswordRegistrationFormTextBox.Text;
            string repeatPasswordUser = RepeatPasswordRegistartionFormTextBox.Text;

            //Проверка на совпадение пароля
            if (passwordUser != repeatPasswordUser)
            {
                MessageBox.Show("Пароли не одинаковы! Попробуйте еще раз!");
                PasswordRegistrationFormTextBox.Clear();
                RepeatPasswordRegistartionFormTextBox.Clear();
            }

            //Функция,которая добавляет данные в Базу Данных
            addDataToDB(loginUser,passwordUser);

        }
    }
}

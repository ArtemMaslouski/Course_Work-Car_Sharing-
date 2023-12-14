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
    public partial class AuthorizationForm : Form
    {
        RegistartionForm registration = new RegistartionForm();
        DB db = new DB();
        public AuthorizationForm()
        {
            InitializeComponent();
            WarningLabelAuthorization.Visible = false;
        }

        private void RegistartionButton_Click(object sender, EventArgs e)
        {
            //Переход на страницу регистрации 
            registration.Show();
            this.Hide();
        }

        private void ExitButtonAuthorizationForm_Click(object sender, EventArgs e)
        {
            //Выход из приложения
            Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            MainWindow main = new MainWindow();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string query = $"SELECT Login,Password From LoginAndPassword WHERE Login = '{login}' AND Password = '{password}'";

            SqlCommand command = new SqlCommand(query,db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                main.Show();
                this.Hide();
            }
            else
            {
                WarningLabelAuthorization.Visible = true;
                LoginTextBox.Clear();
                PasswordTextBox.Clear();
            }
            

        }
    }
}

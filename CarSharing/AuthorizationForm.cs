using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSharing
{
    public partial class AuthorizationForm : Form
    {
        RegistartionForm registration = new RegistartionForm();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void RegistartionButton_Click(object sender, EventArgs e)
        {
            //Запись из TextBox в переменную
            string loginUser = LoginTextBox.Text;
            string passwordUser = PasswordTextBox.Text;


            registration.Show();
            this.Hide();
        }

        private void ExitButtonAuthorizationForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

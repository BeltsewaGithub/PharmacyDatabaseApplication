using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmasyApplication
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                String role;
                sqlCommandAuthorize.Parameters["@login"].Value =
                    textBoxLogin.Text;
                sqlCommandAuthorize.Parameters["@password"].Value =
                    textBoxPass.Text;
                sqlConnection1.Open();
                sqlCommandAuthorize.ExecuteNonQuery();
                role = Convert.ToString(sqlCommandAuthorize.Parameters["@role"].Value);
                sqlConnection1.Close();
                if (role == "director")
                {
                    Director form1 = new Director();
                    form1.Show();
                }
                else if (role == "pharmacist")
                {
                    Pharmacist myForm2 = new Pharmacist();
                    myForm2.Show();
                }
                else if (role == "manager")
                {
                    Provider myForm3 = new Provider();
                    myForm3.Show();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Auto_exam
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password_textBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            DB db = new DB();
            string log = db.ReturnFromDB("SELECT Login FROM Users WHERE [Login] = N'" + login_textBox.Text + "' AND [Password] = N'" + password_textBox.Text + "'");
            /*db.OpenConnection();
            SqlCommand com = new SqlCommand("SELECT Login FROM Users WHERE [Login] = N'" + login_textBox.Text + "' AND [Password] = N'" + password_textBox.Text + "'", db.GetConnection());
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                film_code_label.Text = rd[0].ToString();
                //MessageBox.Show("Код фильма: ", film_code_label.Text);
            }
            rd.Close();
            db.CloseConnection();*/
            if (log == "") 
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                this.Hide();
                Choose_model choose_model = new Choose_model();
                choose_model.Show();
            }

        }
    }
}

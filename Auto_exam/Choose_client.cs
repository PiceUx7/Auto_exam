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
    public partial class Choose_client : Form
    {
        public Choose_client()
        {
            InitializeComponent();
            comboboxload();
        }

        public void comboboxload()
        {
            DB db = new DB();
            db.OpenConnection();
            
            SqlCommand com = new SqlCommand("SELECT DISTINCT NameClient FROM Clients", db.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(table);
            clients_comboBox.DataSource = table;
            clients_comboBox.DisplayMember = "NameClient";
            clients_comboBox.SelectedIndex = -1;
            //clients_comboBox.Text = "1";
            db.CloseConnection();

        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            if (clients_comboBox.Text == "")
            {
                MessageBox.Show("Выберите клиента");
                return;
            }
            Cars_part_shop cars_part_shop = new Cars_part_shop();
            cars_part_shop.car_name_model_label.Text = car_name_label.Text;
            cars_part_shop.client_name_label.Text = clients_comboBox.Text;
            this.Hide();
            cars_part_shop.Show();
        }
    }
}

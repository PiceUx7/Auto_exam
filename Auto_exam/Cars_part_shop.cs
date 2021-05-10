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
    public partial class Cars_part_shop : Form
    {
        public Cars_part_shop()
        {
            InitializeComponent();;
        }

        public void comboboxload()
        {
            DB db = new DB();
            db.OpenConnection();

            SqlCommand com = new SqlCommand("SELECT NamePart FROM " + car_name_model_label.Text + "", db.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(table);
            details_comboBox.DataSource = table;
            details_comboBox.DisplayMember = "NamePart";
            details_comboBox.SelectedIndex = -1;
            //clients_comboBox.Text = "1";
            db.CloseConnection();
        }

        private void details_comboBox_Click(object sender, EventArgs e)
        {
            if (load_cb_label.Text == "0")
            {
                load_cb_label.Text = "1";
                comboboxload();
            }
        }
    }
}

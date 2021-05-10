using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_exam
{
    public partial class Choose_model : Form
    {
        public Choose_model()
        {
            InitializeComponent();
        }

        private void bmw_pictureBox_Click(object sender, EventArgs e)
        {
            Choose_client choose_client = new Choose_client();
            choose_client.car_name_label.Text = "BMW";
            this.Hide();
            choose_client.Show();
        }

        private void mercedes_pictureBox_Click(object sender, EventArgs e)
        {
            Choose_client choose_client = new Choose_client();
            choose_client.car_name_label.Text = "Mercedes";
            this.Hide();
            choose_client.Show();
        }

        private void lada_pictureBox_Click(object sender, EventArgs e)
        {
            Choose_client choose_client = new Choose_client();
            choose_client.car_name_label.Text = "Lada";
            this.Hide();
            choose_client.Show();
        }

        private void audi_pictureBox_Click(object sender, EventArgs e)
        {
            Choose_client choose_client = new Choose_client();
            choose_client.car_name_label.Text = "Audi";
            this.Hide();
            choose_client.Show();
        }
    }
}

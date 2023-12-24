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

namespace laboratorka
{
    public partial class SubscriberForm : Form
    {

        DataBase dataBase = new DataBase();
        private readonly CheckUser user;
        public SubscriberForm(CheckUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
        }

     
        private void SubscriberForm_Load(object sender, EventArgs e)
        {

        }

        private void IsAdmin()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var description = textBox1.Text;
            DateTime dateTime = DateTime.Today;


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Поле с проблемой пустое");
                return;
            }

            string querystring = $"insert into problem(date, status, description) values('{dateTime}', 'New', '{description}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();

            command.ExecuteNonQuery();

            MessageBox.Show("Отправлено!");

            dataBase.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;

namespace lovapp_with_DB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int Id_button = 1;
        static public int count;

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int i;
        void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            String connectionString = "Server=localhost;Port=5432;Database=testdb;User Id=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("select COUNT(id) from employee", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                count = Convert.ToInt32(dbDataRecord["count"]);
                for (i = 1; i <= Convert.ToInt32(dbDataRecord["count"]); i++)
                {
                    comboBox1.Items.Add(i);
                }
            }
        }
        void Switch(int idsh)
        {
            String connectionString = "Server=localhost;Port=5432;Database=testdb;User Id=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT * FROM employee WHERE id = " + idsh, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                //label8.Text = Convert.ToString(dbDataRecord["id"]);
                textBox2.Text = Convert.ToString(dbDataRecord["name"]);
                textBox1.Text = Convert.ToString(dbDataRecord["age"]);
                textBox3.Text = Convert.ToString(dbDataRecord["gender"]);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Index = comboBox1.SelectedItem.ToString();
            int Index_int = Convert.ToInt32(Index);
            Switch(Index_int);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("UPDATE employee set name = @name, age = @age, gender = @gender where id = @id", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@id", x);
            npgSqlCommand.Parameters.AddWithValue("@name", textBox2.Text);
            npgSqlCommand.Parameters.AddWithValue("@age", Convert.ToInt32(textBox1.Text));
            npgSqlCommand.Parameters.AddWithValue("@gender", textBox3.Text);
            npgSqlCommand.ExecuteNonQuery();
        }
    }
}

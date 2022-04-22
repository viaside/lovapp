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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public string regName;
        static public int idihka;


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Click(object sender, EventArgs e)
        {
            fdsfsd newform = new fdsfsd();
            regName = textBox1.Text;
            int zxc;
            if (regName == "admin")
            {
                Form4 adm = new Form4();
                adm.Show();
                this.Hide();
            }
            else
            {
                String connectionString = "Server=localhost;Port=5432;Database=testdb;User Id=postgres;Password=zxc;";
                NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("select ID from employee WHERE name = @name", npgSqlConnection);
                npgSqlCommand.Parameters.AddWithValue("@name", regName);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    zxc = Convert.ToInt32(dbDataRecord["id"]);
                    idihka = zxc;
                }
                this.Hide();
                newform.Show();
                if (idihka == 0)
                {
                    MessageBox.Show("ошибка в имени пользователя");
                    this.Show();
                    newform.Hide();
                }
                idihka = 0;
            }
        }
        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createacc_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
            this.Hide();
        }
    }
}
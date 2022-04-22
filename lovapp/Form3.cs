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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            public string Gender { get; set; }
            public int Likes { get; set; }
        }
        static public int UserId;
        static public string UserName;
        static public int UserAge;
        static public string UserGender;
        static public List<Book> UsersBook = new List<Book>();
        
        public void Form3_Load(object sender, EventArgs e)  
        {
            this.BackColor = Color.Purple;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        public void newName_TextChanged(object sender, EventArgs e)
        { 
        }

        public void create_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
            UserId++;
            UserName = newName.Text;
            UserAge = Convert.ToInt32(newAge.Text);
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("INSERT INTO employee (name, age, gender, likes) VALUES (@name, @age, @gender, @likes)", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@name", UserName);
            npgSqlCommand.Parameters.AddWithValue("@age", UserAge);
            npgSqlCommand.Parameters.AddWithValue("@gender", UserGender);
            npgSqlCommand.Parameters.AddWithValue("@likes", 0);
            npgSqlCommand.ExecuteNonQuery();
        }

        public void click_gender_woman(object sender, EventArgs e)
        {
            UserGender = "Woman";
        }

        public void click_gender_man(object sender, EventArgs e)
        {
            UserGender = "Man";
        }

    }
}

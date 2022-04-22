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
    public partial class fdsfsd : Form
    {
        public fdsfsd()
        {
            InitializeComponent();
        }

        static public int ilike1;
        static public int ilike2;
        static public int ilike3;
        static public int ilike4;
        static public int pos1;
        static public int pos2;
        static public int pos3;
        static public int pos4;

        private void Form2_Load(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;Port=5432;Database=testdb;User Id=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("select ID from employee WHERE name = @name", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@name", Form1.regName);
            this.BackColor = Color.Purple;
            this.StartPosition = FormStartPosition.CenterScreen;
            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT * FROM employee WHERE id = " + Form1.idihka, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                label8.Text = Convert.ToString(dbDataRecord["id"]);
                label4.Text = Convert.ToString(dbDataRecord["name"]);
                label5.Text = Convert.ToString(dbDataRecord["age"]);
                label6.Text = Convert.ToString(dbDataRecord["gender"]);
                label9.Text = Convert.ToString(dbDataRecord["likes"]);
            }
            for (int i = 1; i <= 4; i++)
            {
                String connectionString2 = "Server=localhost;Port=5432;Database=testdb;User Id=postgres;Password=zxc;";
                NpgsqlConnection npgSqlConnection2 = new NpgsqlConnection(connectionString2);
                npgSqlConnection2.Open();
                NpgsqlCommand npgSqlCommand3 = new NpgsqlCommand("SELECT * FROM employee WHERE id = " + i, npgSqlConnection2);
                NpgsqlDataReader npgSqlDataReader2 = npgSqlCommand3.ExecuteReader();
                string Name = null;
                string Age = null;
                string Gender = null;
                string z = null;
                string x = null;
                if (Form1.idihka == 1)
                {
                    if (i == Form1.idihka)
                    {
                        continue;
                    }
                    if (i == Form1.idihka + 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name1.Text = Convert.ToString(dbDataRecord["name"]);
                            age1.Text = Convert.ToString(dbDataRecord["age"]);
                            gender1.Text = Convert.ToString(dbDataRecord["gender"]);
                            id1.Text = Convert.ToString(i);
                            likes1.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos1 = i;
                        }

                    }
                    if (i == Form1.idihka + 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name2.Text = Convert.ToString(dbDataRecord["name"]);
                            age2.Text = Convert.ToString(dbDataRecord["age"]);
                            gender2.Text = Convert.ToString(dbDataRecord["gender"]);
                            id2.Text = Convert.ToString(i);
                            likes2.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos2 = i;
                        }
                    }
                    if (i == Form1.idihka + 3)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name3.Text = Convert.ToString(dbDataRecord["name"]);
                            age3.Text = Convert.ToString(dbDataRecord["age"]);
                            gender3.Text = Convert.ToString(dbDataRecord["gender"]);
                            id3.Text = Convert.ToString(i);
                            likes3.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos3 = i;
                        }
                    }
                    if (i == Form1.idihka + 4)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name4.Text = Convert.ToString(dbDataRecord["name"]);
                            age4.Text = Convert.ToString(dbDataRecord["age"]);
                            gender4.Text = Convert.ToString(dbDataRecord["gender"]);
                            id4.Text = Convert.ToString(i);
                            likes4.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos4 = i;
                        }
                    }
                }
                else if (Form1.idihka == 2)
                {
                    if (i == Form1.idihka)
                    {
                        continue;
                    }
                    if (i == Form1.idihka - 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name1.Text = Convert.ToString(dbDataRecord["name"]);
                            age1.Text = Convert.ToString(dbDataRecord["age"]);
                            gender1.Text = Convert.ToString(dbDataRecord["gender"]);
                            id1.Text = Convert.ToString(i);
                            likes1.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos1 = i;
                        }

                    }
                    if (i == Form1.idihka + 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name2.Text = Convert.ToString(dbDataRecord["name"]);
                            age2.Text = Convert.ToString(dbDataRecord["age"]);
                            gender2.Text = Convert.ToString(dbDataRecord["gender"]);
                            id2.Text = Convert.ToString(i);
                            likes2.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos2 = i;
                        }
                    }
                    if (i == Form1.idihka + 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name3.Text = Convert.ToString(dbDataRecord["name"]);
                            age3.Text = Convert.ToString(dbDataRecord["age"]);
                            gender3.Text = Convert.ToString(dbDataRecord["gender"]);
                            id3.Text = Convert.ToString(i);
                            likes3.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos3 = i;
                        }
                    }
                    if (i == Form1.idihka + 3)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name4.Text = Convert.ToString(dbDataRecord["name"]);
                            age4.Text = Convert.ToString(dbDataRecord["age"]);
                            gender4.Text = Convert.ToString(dbDataRecord["gender"]);
                            id4.Text = Convert.ToString(i);
                            likes4.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos4 = i;
                        }
                    }
                }
                else if (Form1.idihka == 3)
                {
                    if (i == Form1.idihka)
                    {
                        continue;
                    }
                    if (i == Form1.idihka - 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name1.Text = Convert.ToString(dbDataRecord["name"]);
                            age1.Text = Convert.ToString(dbDataRecord["age"]);
                            gender1.Text = Convert.ToString(dbDataRecord["gender"]);
                            id1.Text = Convert.ToString(i);
                            likes1.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos1 = i;
                        }

                    }
                    if (i == Form1.idihka - 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name2.Text = Convert.ToString(dbDataRecord["name"]);
                            age2.Text = Convert.ToString(dbDataRecord["age"]);
                            gender2.Text = Convert.ToString(dbDataRecord["gender"]);
                            id2.Text = Convert.ToString(i);
                            likes2.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos2 = i;
                        }
                    }
                    if (i == Form1.idihka + 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name3.Text = Convert.ToString(dbDataRecord["name"]);
                            age3.Text = Convert.ToString(dbDataRecord["age"]);
                            gender3.Text = Convert.ToString(dbDataRecord["gender"]);
                            id3.Text = Convert.ToString(i);
                            likes3.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos3 = i;
                        }
                    }
                    if (i == Form1.idihka + 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name4.Text = Convert.ToString(dbDataRecord["name"]);
                            age4.Text = Convert.ToString(dbDataRecord["age"]);
                            gender4.Text = Convert.ToString(dbDataRecord["gender"]);
                            id4.Text = Convert.ToString(i);
                            likes4.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos4 = i;
                        }
                    }
                }
                else if (Form1.idihka == 4)
                {
                    if (i == Form1.idihka)
                    {
                        continue;
                    }
                    if (i == Form1.idihka - 3)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name1.Text = Convert.ToString(dbDataRecord["name"]);
                            age1.Text = Convert.ToString(dbDataRecord["age"]);
                            gender1.Text = Convert.ToString(dbDataRecord["gender"]);
                            id1.Text = Convert.ToString(i);
                            likes1.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos1 = i;
                        }

                    }
                    if (i == Form1.idihka - 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name2.Text = Convert.ToString(dbDataRecord["name"]);
                            age2.Text = Convert.ToString(dbDataRecord["age"]);
                            gender2.Text = Convert.ToString(dbDataRecord["gender"]);
                            id2.Text = Convert.ToString(i);
                            likes2.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos2 = i;
                        }
                    }
                    if (i == Form1.idihka - 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name3.Text = Convert.ToString(dbDataRecord["name"]);
                            age3.Text = Convert.ToString(dbDataRecord["age"]);
                            gender3.Text = Convert.ToString(dbDataRecord["gender"]);
                            id3.Text = Convert.ToString(i);
                            likes3.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos3 = i;
                        }
                    }
                    if (i == Form1.idihka + 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name4.Text = Convert.ToString(dbDataRecord["name"]);
                            age4.Text = Convert.ToString(dbDataRecord["age"]);
                            gender4.Text = Convert.ToString(dbDataRecord["gender"]);
                            id4.Text = Convert.ToString(i);
                            likes4.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos4 = i;
                        }
                    }
                }
                else if (Form1.idihka == 5)
                {
                    if (i == Form1.idihka)
                    {
                        continue;
                    }
                    if (i == Form1.idihka - 4)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name1.Text = Convert.ToString(dbDataRecord["name"]);
                            age1.Text = Convert.ToString(dbDataRecord["age"]);
                            gender1.Text = Convert.ToString(dbDataRecord["gender"]);
                            id1.Text = Convert.ToString(i);
                            likes1.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos1 = i;
                        }

                    }
                    if (i == Form1.idihka - 3)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name2.Text = Convert.ToString(dbDataRecord["name"]);
                            age2.Text = Convert.ToString(dbDataRecord["age"]);
                            gender2.Text = Convert.ToString(dbDataRecord["gender"]);
                            id2.Text = Convert.ToString(i);
                            likes2.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos2 = i;
                        }
                    }
                    if (i == Form1.idihka - 2)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name3.Text = Convert.ToString(dbDataRecord["name"]);
                            age3.Text = Convert.ToString(dbDataRecord["age"]);
                            gender3.Text = Convert.ToString(dbDataRecord["gender"]);
                            id3.Text = Convert.ToString(i);
                            likes3.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos3 = i;
                        }
                    }
                    if (i == Form1.idihka - 1)
                    {
                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader2)
                        {
                            name4.Text = Convert.ToString(dbDataRecord["name"]);
                            age4.Text = Convert.ToString(dbDataRecord["age"]);
                            gender4.Text = Convert.ToString(dbDataRecord["gender"]);
                            id4.Text = Convert.ToString(i);
                            likes4.Text = Convert.ToString(dbDataRecord["likes"]);
                            pos4 = i;
                        }
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
            this.Update();
        }

        private void Like1_Click(object sender, EventArgs e)
        {
            ilike1++;
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("UPDATE employee set likes = @likes where id = @id", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@id", pos1);
            npgSqlCommand.Parameters.AddWithValue("@likes", ilike1);
            npgSqlCommand.ExecuteNonQuery();

            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT likes FROM employee WHERE id = " + pos1, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                likes1.Text = Convert.ToString(dbDataRecord["likes"]);
            }
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilike2++;
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("UPDATE employee set likes = @likes where id = @id", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@id", pos2);
            npgSqlCommand.Parameters.AddWithValue("@likes", ilike2);
            npgSqlCommand.ExecuteNonQuery();

            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT likes FROM employee WHERE id = " + pos2, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                likes2.Text = Convert.ToString(dbDataRecord["likes"]);
            }
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilike3++;
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("UPDATE employee set likes = @likes where id = @id", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@id", pos3);
            npgSqlCommand.Parameters.AddWithValue("@likes", ilike3);
            npgSqlCommand.ExecuteNonQuery();

            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT likes FROM employee WHERE id = " + pos3, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                likes3.Text = Convert.ToString(dbDataRecord["likes"]);
            }
            button3.Enabled = false;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            ilike4++;
            String connectionString = "Server=localhost;Port=5432;Database=testdb;UserId=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("UPDATE employee set likes = @likes where id = @id", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@id", pos4);
            npgSqlCommand.Parameters.AddWithValue("@likes", ilike4);
            npgSqlCommand.ExecuteNonQuery();

            NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand("SELECT likes FROM employee WHERE id = " + pos4, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand2.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                likes4.Text = Convert.ToString(dbDataRecord["likes"]);
            }
            button4.Enabled = false;
        }
    }
}

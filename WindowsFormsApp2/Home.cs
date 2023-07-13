using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{

    public partial class Home : UserControl
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        public Home()
        {
            InitializeComponent();
        }

        private void Dashboard_User_Control_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                string query = "select COUNT(*) from book";

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query;
                int NOBOOK = 0;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NOBOOK = reader.GetInt32(0);
                    }
                }

                numberofBook_Level.Text = NOBOOK+"";


                string query_for_member = "select COUNT(*) from member_student";
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandText = query_for_member;
                int NoMember = 0;

                using (MySqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NoMember = reader.GetInt32(0);
                    }
                }

                string query_for_member_teacher = "select COUNT(*) from member_teacher_staff";
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandText = query_for_member_teacher;
                int NoMember_teacher = 0;

                using (MySqlDataReader reader = cmd3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NoMember_teacher = reader.GetInt32(0);
                    }
                }

                NoMember = NoMember + NoMember_teacher;


                Memeber_Count_Label.Text = NoMember + "";

                this.CloseConnection();
            }



        }
        private string GetConnectionString()
        {
            string connStr = null;

            server = "localhost";
            database = "library";
            uid = "root";
            password = "logant";
            connStr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            return connStr;
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

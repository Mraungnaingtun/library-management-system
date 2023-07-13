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
    public partial class All_Memeber_List : UserControl
    {
        string member_type="";
        string query;

        public All_Memeber_List()
        {
            InitializeComponent();
        }

        public All_Memeber_List(string type)
        {
            InitializeComponent();
            member_type = type;
        }

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;


        // ---------------------- Load Control ---------------------
        private void All_Memeber_List_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            all_Memeber_LIst_GridView.RowTemplate.Height = 35;
            //Fill to the combobox -------------------------
            if (member_type == "student")
            {
                query = "select * from member_student";
            }
            else
            {
                query = "select * from member_teacher_staff";
            }
            all_Memeber_LIst_GridView.DataSource = GetView();
            
        }

        private void Back_To_Register_Member_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        /// <summary>
        ///  return Member list VIew
        /// </summary>
        /// <returns></returns>
        public DataTable GetView()
        {
            if (this.OpenConnection() == true)
            {
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);

                //close connection
                this.CloseConnection();

                return dt;
            }
            else return null;
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

        
    }
}

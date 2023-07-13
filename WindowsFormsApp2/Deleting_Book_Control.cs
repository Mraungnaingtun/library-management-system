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
    public partial class Deleting_Book_Control : UserControl
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;

        string Selected_ID;
        public Deleting_Book_Control()
        {
            InitializeComponent();
        }

        private void Deleting_Book_Control_Load(object sender, EventArgs e)
        {
            string connectionStr = GetConnectionString();
            connection = new MySqlConnection(connectionStr);
            if (this.OpenConnection() == true)
            {
                Delete_GridView.RowTemplate.Height = 35;
                Delete_GridView.DataSource = GetView();
                this.CloseConnection();
            }   
        }

        public DataTable GetView()
        {
            
                string query = "select Book_ID,Book_Name,Author from book order by Book_Name asc";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);

                //close connection
                this.CloseConnection();

                return dt;
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

        //exit
        private void Back_Delete_Control_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }



        private void Search_Btn_Click(object sender, EventArgs e)
        {
            string connectionStr = GetConnectionString();
            connection = new MySqlConnection(connectionStr);

            string id = Search_Text.Text;

            if (this.OpenConnection() == true)
            {
                string query = "select Book_ID,Book_Name,Author from book where Book_ID like '%" + id + "%' order by Book_Name asc";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);

                //close connection
                this.CloseConnection();

                Delete_GridView.DataSource = dt;
            }
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionStr = GetConnectionString();
                connection = new MySqlConnection(connectionStr);

                string id = Search_Text.Text;

                if (this.OpenConnection() == true)
                {
                    string query = "select Book_ID,Book_Name,Author from book where Book_ID like '%" + id + "%' order by Book_Name asc";
                    //MessageBox.Show(book_name, "3");
                    mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable("CharacterInfo");
                    mySqlDataAdapter.Fill(dt);

                    //close connection
                    this.CloseConnection();

                    Delete_GridView.DataSource = dt;
                }
            }
        }

        private void Delete_GridView_DoubleClick(object sender, EventArgs e)
        {
            if (Delete_GridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = Delete_GridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Delete_GridView.Rows[selectedrowindex];

                Selected_ID = Convert.ToString(selectedRow.Cells["Book_ID"].Value);
                //MessageBox.Show(Selected_BookID);
            }

            string query_for_sleeeping = "delete from book where Book_ID ='"+ Selected_ID + "'";
            DialogResult dialogResult = MessageBox.Show("Are you Sure to delete", "Deleting Book", MessageBoxButtons.YesNo);
            if (this.OpenConnection())
            {
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand(query_for_sleeeping, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Deleted");
                        Delete_GridView.DataSource = GetView();

                    }
                    else
                    {
                        MessageBox.Show("Query Not Executed");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

                this.CloseConnection();
            }
            
        }
    }
}

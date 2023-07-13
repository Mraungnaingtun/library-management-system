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
    public partial class UpdateBook_Control : UserControl
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;
        string request_book_ID = "";

        public UpdateBook_Control()
        {
            InitializeComponent();
        }

        private void AllBook_Load(object sender, EventArgs e)
        {
            string connectionStr = GetConnectionString();
            connection = new MySqlConnection(connectionStr);
            allBookGridView.RowTemplate.Height = 35;
            allBookGridView.DataSource = GetView();
        }

        private void AddingBook_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public DataTable GetView()
        {
            if (this.OpenConnection() == true)
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


        //Update a Book Operation Button
        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_ID_Text_Btn_Click(object sender, EventArgs e)
        {
            string connectionStr = GetConnectionString();
            connection = new MySqlConnection(connectionStr);

            string id = Book_ID_Text.Text;

            if (this.OpenConnection() == true)
            {
                string query = "select Book_ID,Book_Name,Author from book where Book_ID like '%" + id + "%' order by Book_Name asc";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);

                //close connection
                this.CloseConnection();

                allBookGridView.DataSource = dt;
            }
        }

        private void DoubleON_Grid(object sender, EventArgs e)
        {
            if (allBookGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = allBookGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = allBookGridView.Rows[selectedrowindex];

                request_book_ID = Convert.ToString(selectedRow.Cells["Book_ID"].Value);
                //MessageBox.Show(borrrower_id + "");
            }

            UpdateBook update_book = new UpdateBook(request_book_ID);
            update_book.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(update_book);

            Form1.Instance.PnlContainer.Controls["UpdateBook"].BringToFront();
        }

        private void EnterKeypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionStr = GetConnectionString();
                connection = new MySqlConnection(connectionStr);

                string id = Book_ID_Text.Text;

                if (this.OpenConnection() == true)
                {
                    string query = "select Book_ID,Book_Name,Author from book where Book_ID like '%" + id + "%' order by Book_Name asc";
                    //MessageBox.Show(book_name, "3");
                    mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable("CharacterInfo");
                    mySqlDataAdapter.Fill(dt);

                    //close connection
                    this.CloseConnection();

                    allBookGridView.DataSource = dt;
                }

            }
        }
    }
}

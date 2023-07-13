using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class All_Book_Founded_List : UserControl
    {
        /// <summary>
        /// ------ Variables ------------
        /// </summary>
        string book_name = "";
        string filter_query = "";
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;
        string Selected_BookID = null;

        public All_Book_Founded_List()
        {
            InitializeComponent();
            Book_Founded_GirdView.DataSource = null;
        }

        public All_Book_Founded_List(string data, string query)
        {
            InitializeComponent();
            Book_Founded_GirdView.DataSource = null;
            book_name = data;
            filter_query = query;
        }

        /*string book_name = books_user_control.BookName;*/

        private void All_Book_Founded_List_Load(object sender, EventArgs e)
        {
            No_Book_label.Visible = false;
            Book_Founded_GirdView.RowTemplate.Height = 45;
            connection = new MySqlConnection(getConnectionString());

            if (book_name != "")
            {
                Book_Founded_GirdView.DataSource = GetView_By_Book_Name();

            } else if (filter_query!="")
            {
                Book_Founded_GirdView.DataSource = GetViewBy_Query();
            }
        }

        // -------- Get All Book like user input words -------------------------
        public DataTable GetView_By_Book_Name()
        {
            if (this.OpenConnection() == true)
            {
                string query_for_book = "SELECT book.Book_ID,book.Book_Name,book.Author,category.Category,category.Sub_Category,book.Number_Book FROM library.book " +
                    "LEFT JOIN library.category ON book.Category_ID = category.Category_ID where book.Book_ID like '%" + book_name + "%' or book.Book_Name like '%" + book_name + "%' or book.Author like '%" + book_name + "%' ORDER BY book.Book_Name ASC";
                mySqlDataAdapter = new MySqlDataAdapter(query_for_book, connection);
                DataTable dt1 = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt1);


                string query_for_categroy = "SELECT book.Book_ID,book.Book_Name,book.Author,category.Category,category.Sub_Category,book.Number_Book FROM library.book" +
                    " LEFT JOIN library.category ON book.Category_ID = category.Category_ID where category.Category like '%"+book_name+ "%' or category.Sub_Category like '%" + book_name + "%' ORDER BY book.Book_Name ASC";
                MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(query_for_categroy,connection);
                DataTable dt2 = new DataTable("CharacterInfo");
                mySqlDataAdapter2.Fill(dt2);

                dt1.Merge(dt2);
                //close connection
                this.CloseConnection();
                book_name = "";
                int totalRows = dt1.Rows.Count;
                if (totalRows < 1)
                {
                    No_Book_label.Visible = true;
                    Book_Founded_GirdView.Visible = false;
                    BookFound_Count_Label.Text = "0 Book Found";
                    return null;
                }
                else
                {
                    if (totalRows > 1)
                    {
                        BookFound_Count_Label.Text = totalRows + " Books Found";
                    }
                    else if (totalRows == 1)
                    {
                        BookFound_Count_Label.Text = totalRows + " Book Found";
                    }
                    return dt1;
                }
            }
            else return null;  
        }


        // -------- Get All Book With Filter -------------------------
        public DataTable GetViewBy_Query()
        {
            if (this.OpenConnection() == true)
            {
                //MessageBox.Show(filter_query);
                if (filter_query != "SELECT book.Book_ID,book.Book_Name,book.Author,category.Category,category.Sub_Category,book.Number_Book FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where")
                {
                    string query = filter_query + " order by book.Book_Name asc";
                    //MessageBox.Show(query);
                    //MessageBox.Show(book_name, "3");
                    mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable("CharacterInfo");
                    mySqlDataAdapter.Fill(dt);

                    //close connection
                    this.CloseConnection();
                    book_name = "";

                    int totalRows = dt.Rows.Count;
                    if (totalRows < 1)
                    {
                        No_Book_label.Visible = true;
                        Book_Founded_GirdView.Visible = false;
                        BookFound_Count_Label.Text = "0 Book Found";
                        return null;
                    }
                    else
                    {
                        if (totalRows > 1)
                        {
                            BookFound_Count_Label.Text = totalRows + " Books Found";
                        }
                        else if (totalRows == 1)
                        {
                            BookFound_Count_Label.Text = totalRows + " Book Found";
                        }
                        return dt;
                    }
                    
                }
                else {
                    //MessageBox.Show("Select Correctly!");
                    return null;
                }
                
            }
            else return null;
        }

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

        private string getConnectionString()
        {
            server = "localhost";
            database = "library";
            uid = "root";
            password = "logant";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionString;
        }

        // Exit
        private void Back_to_book_user_control_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        // Go to Borrow User Contorl --------------------------------------- Borrow Control---------------------------
        private void Request_Book_Double_CLick(object sender, EventArgs e)
        {
            if (Book_Founded_GirdView.SelectedCells.Count > 0)
            {
                int selectedrowindex = Book_Founded_GirdView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Book_Founded_GirdView.Rows[selectedrowindex];

                Selected_BookID = Convert.ToString(selectedRow.Cells["Book_ID"].Value);
                //MessageBox.Show(Selected_BookID);
            }

            Borrowing borrrowing = new Borrowing(Selected_BookID);
            borrrowing.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(borrrowing);

            Form1.Instance.PnlContainer.Controls["Borrowing"].BringToFront();
        }
    }
}

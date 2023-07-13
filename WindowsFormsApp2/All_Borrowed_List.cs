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
    public partial class All_Borrowed_List : UserControl
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;

        // class 
        int borrrower_id = 0;
        string member_type = "";
        string query_for_member;

        //from book table
        string book_name, author;

        //from borrowers table
        string book_id, start_date, end_date, member_id;

        //from member table 
        string member_name, roll_no;

        int book_count=0;
        


        public All_Borrowed_List()
        {
            InitializeComponent();
        }

        private void All_Borrowed_List_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(getConnectionString());
            if (this.OpenConnection() == true)
            {
                LoadMain();
                //close connection
                this.CloseConnection();
            }
        }

        // -------------- Load Function -----------------------
        private void LoadMain()
        {
            string query = "SELECT book.Book_ID,book.Book_Name,member_student.Student_Name,member_teacher_staff.TS_Name,borrowers.Start_Date,borrowers.End_Date,borrowers.Borrower_ID " +
                    "FROM library.borrowers left join library.book on borrowers.Book_ID = book.Book_ID  " +
                    "left join library.member_student on borrowers.MStu_ID = member_student.MStu_ID  " +
                    "left join library.member_teacher_staff on borrowers.MTS_ID = member_teacher_staff.MTS_ID " +
                    "where borrowers.Borrow_Type='Book'  ORDER BY borrowers.Borrower_ID DESC;";

            mySqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable("CharacterInfo");
            mySqlDataAdapter.Fill(dt);
            Book_Borrower_GridView.RowTemplate.Height = 45;
            Book_Borrower_GridView.DataSource = dt;
        }

        // ----------------- get back the book ----------------------------------------
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                if (borrrower_id != 0)
                {
                    string member = "";
                    if (member_type == "student")
                    {
                        member = "MStu_ID";
                    }
                    else if (member_type == "teacher")
                    {
                        member = "MTS_ID";
                    }
                    //-------------------------query for delete borrowed list ---------
                    string query_delete_list = "delete from borrowers where " + member + "='" + member_id + "' and Book_ID='" + book_id + "'";

                    MySqlCommand delete_cmd = new MySqlCommand(query_delete_list, connection);
                    if (delete_cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Deleted Borrower!");
                    }
                    else
                    {
                        //MessageBox.Show("Query Not Success Update");
                    }
                    //-------------------------query for update book count --------------------
                    string the_Book = book_ID_label.Text;

                    string query_to_get_book_count = "select Number_Book from book where Book_ID='" + the_Book + "'";
                    MySqlCommand cmd_to_get_book_count = new MySqlCommand();
                    cmd_to_get_book_count.Connection = connection;
                    cmd_to_get_book_count.CommandText = query_to_get_book_count;


                    using (MySqlDataReader reader = cmd_to_get_book_count.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { book_count = Convert.ToInt32(reader[0]); }
                            else
                            {

                            }

                        }
                    }


                    //
                    // update back with new book count **********************************************************************
                    int update_book_count = book_count + 1;
                    string query_for_update_book_count = "update book set Number_Book=" + update_book_count + " where Book_ID='" + book_id + "'";
                    MySqlCommand command_for_update_bookCount = new MySqlCommand(query_for_update_book_count, connection);
                    if (command_for_update_bookCount.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Updated Book Count!");
                    }
                    else
                    {
                        //MessageBox.Show("Query Not Success Update");
                    }
                }
                else MessageBox.Show("", "ပြန်အပ်မည့်စာအုပ်ကို ရွေးပါ");
                this.CloseConnection();
            }
            LoadMain();
        }

  

        //---------------------------- Double Click on GridView ----------------------------------
        private void DoubleClick_OnBorrower(object sender, EventArgs e)
        {
            if (Book_Borrower_GridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = Book_Borrower_GridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Book_Borrower_GridView.Rows[selectedrowindex];

                borrrower_id = Convert.ToInt32(selectedRow.Cells["Borrower_ID"].Value);
                //MessageBox.Show(borrrower_id + "");
            }

            if (this.OpenConnection() == true)
            {
                string query_for_borrowed_book = "select Book_ID,MStu_ID,MTS_ID,Start_Date,End_Date from borrowers where Borrower_ID='" + borrrower_id + "'";

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query_for_borrowed_book;


                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        { book_id = reader.GetString(0); }
                        else
                        {
                            book_id = "Unknown";
                        }

                        // ------------------ Member_ID (MStu or MTS) --------------------------
                        if (!reader.IsDBNull(1))
                        { member_id = reader.GetString(1); }
                        else
                        {
                            member_type = "teacher";
                        }
                        if (!reader.IsDBNull(2))
                        { member_id = reader.GetString(2); }
                        else
                        {
                            member_type = "student";
                        }

                        //start Date
                        if (!reader.IsDBNull(3))
                        {
                            string temp = reader.GetString(3);
                            start_date = temp.Substring(0, temp.IndexOf(" "));
                            //MessageBox.Show(start_date);
                        }
                        else
                        {

                        }
                        //end Date
                        if (!reader.IsDBNull(4))
                        {
                            string temp = reader.GetString(4);
                            end_date = temp.Substring(0, temp.IndexOf(" "));
                        }
                        else
                        {

                        }
                    }
                }
                //------------------end  ---------------
                //get member name and RollNo or depeartmemt name -------------------------
                if (member_type == "student")
                {
                    query_for_member = "select Student_Name,RollNo from member_student where MStu_ID='" + member_id + "'";
                }
                else query_for_member = "select TS_Name,Depeartment_Name from member_teacher_staff where MTS_ID='" + member_id + "'";


                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandText = query_for_member;


                using (MySqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        { member_name = reader.GetString(0); }
                        else
                        {
                            member_name = "Unknown";
                        }

                        // ------------------ Member_ID (MStu or MTS) --------------------------
                        if (!reader.IsDBNull(1))
                        { roll_no = reader.GetString(1); }
                        else
                        {
                            roll_no = "Unknown";
                        }

                    }
                }
                // ------------------------- book name and author ------------------
                string query_for_book_name = "select Book_Name,Author from book where Book_ID='" + book_id + "'";
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandText = query_for_book_name;


                using (MySqlDataReader reader = cmd3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        { book_name = reader.GetString(0); }
                        else
                        {
                            book_name = "Unknown";
                        }

                        // ------------------ Member_ID (MStu or MTS) --------------------------
                        if (!reader.IsDBNull(1))
                        { author = reader.GetString(1); }
                        else
                        {
                            author = "Unknown";
                        }

                    }

                }
                this.CloseConnection();
            }

            //end getting data

            book_name_label.Text = book_name;
            book_ID_label.Text = book_id;
            author_label.Text = author;
            start_date_label.Text = start_date;
            end_date_label.Text = end_date;
            member_name_label.Text = member_name + "( " + roll_no + " )";
            
        }



        //****************** DataBase ******************************
        // open connection
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

        //close connection
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

        // get connection string
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
    }
}

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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Borrowing : UserControl
    {
        /// <summary>
        ///  ----- Variables ------------
        /// </summary>
        /// 

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;

        string query = "", ID_type = "", Selected_MID = "",Memeber_Type = "";
        string Selected_BookID = null;
        String Book_Name = "", Author = "", Category = "", Sub_Category = "", Edition = "", Publisher = "", Description = "", Place = "";
        int count = 0, price = 0 ;
        string publish_year = "";
        int shelf_Name, shelf_Row;
        string borrower_name;



        //get book count
        int book_count = 0;

        //insert
        string insert_query = "";

        //get count borrowed by particular
        string count_borrowed_query;
        int borrowed_count = 0;

        // Default Constructor 
        public Borrowing()
        {
            InitializeComponent();
        }

        // Constructor 
        public Borrowing(string BOok_id)
        {
            InitializeComponent();
            Selected_BookID = BOok_id;
        }

        // ----     Main Control Load   ---------------------------
        private void Borrowing_Load(object sender, EventArgs e)
        {
            Founded_Members_GridView.RowTemplate.Height = 45;
            //MessageBox.Show(Selected_BookID);
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);


            //Fill to the combobox -------------------------
            if (this.OpenConnection() == true)
            {
                string query = "select * from book where Book_ID='" + Selected_BookID + "'";

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query;


                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(1))
                        { Author = reader.GetString(1); }
                        else
                        {
                            Author = "Unknown";
                        }

                        if (!reader.IsDBNull(2))
                        {
                            Book_Name = reader.GetString(2);
                        }
                        else
                        {
                            Book_Name = "Unknown";
                        }

                        if (!reader.IsDBNull(3))
                        { Publisher = reader.GetString(3); }
                        else
                        {
                            Publisher = "Unknown";
                        }

                        if (!reader.IsDBNull(4))
                        { Edition = reader.GetString(4); }
                        else
                        {
                            Edition = "Unknown";
                        }

                        if (!reader.IsDBNull(6))
                        { publish_year = reader.GetString(6); }

                        if (!reader.IsDBNull(7))
                        { price = reader.GetInt32(7); }


                        if (!reader.IsDBNull(8))
                        { count = reader.GetInt32(8); }
                        else count = 0;

                        if (!reader.IsDBNull(9))
                        { Description = reader.GetString(9); }
                        else
                        {
                            Description = "";
                        }

                        /*if (!reader.IsDBNull(11))
                        {
                            img = reader.GetBytes(reader.GetOrdinal("Image"));
                        }
                        else { }*/
                    }
                }

                

                //query to get  Category and SubCategory 0000000000000000000000000000000000000000000000000000000
                string query_for_Category = "select category.Category,category.Sub_Category from library.book left join library.category on book.Category_ID = category.Category_ID where book.Book_ID='" + Selected_BookID + "'";
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandText = query_for_Category;

                using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        if (!reader2.IsDBNull(0))
                        {
                            Category = reader2.GetString(0);
                        }
                        else
                        {
                            Category = "Unknown";
                        }

                        if (!reader2.IsDBNull(1))
                        {
                            Sub_Category = reader2.GetString(1);
                        }
                        else
                        {
                            Sub_Category = "Unknown";
                        }
                    }
                }

                // query to get shelf and row
                string query_for_shelf_and_row = "SELECT shelf.shelf_Name,shelf.shelf_Row FROM library.book left join library.shelf on book.Shelf_ID = shelf.Shelf_ID where book.Book_ID = '"+ Selected_BookID +"';";
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandText = query_for_shelf_and_row;

                using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                {
                    if (reader3.Read())
                    {
                        if (!reader3.IsDBNull(0))
                        {
                            shelf_Name = Convert.ToInt32(reader3.GetString(0));
                        }
                        else
                        {
                            shelf_Name = 0;
                        }

                        if (!reader3.IsDBNull(1))
                        {
                            shelf_Row = Convert.ToInt32(reader3.GetString(1));
                        }
                        else
                        {
                            shelf_Row = 0;
                        }
                    }
                }
                    this.CloseConnection();
            }

            BookName_Label.Text = Book_Name + " ( " + Selected_BookID + " ) ";
            Author_Label.Text = Author;
            Category_Label.Text = Category + " ( " + Sub_Category + " ) ";
            Edition_Label.Text = Edition;
            if (count != 0) { Count_Label.Text = "" + count; } else if (count == 0) { Count_Label.Text = "0"; }
            if (price != 0) { Price_Label.Text = "" + price; } else { Price_Label.Text = "Unknown"; }

            Publisher_Label.Text = Publisher;

            if (publish_year != "") { PublishYear_Label.Text = "" + publish_year; } else { PublishYear_Label.Text = "Unknown"; }
            Place_Label.Text = "Shelf  " + shelf_Name +" : "+ "Row  " +shelf_Row;


        }


        /// <summary>
        /// ---------------------- Searching Member ----------------------------
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {

            string input = Search_member_TextBox.Text;
            if (radioButton1.Checked)
            {
                query = "select MStu_ID,Student_Name,RollNo from member_student where MStu_ID like '%" + input + "%' or Student_Name like '%"
                   + input + "%' or RollNo like '%" + input + "%' order by MStu_ID asc";
            }
            else if (radioButton2.Checked)
            {
                query = "select MTS_ID,TS_Name,Depeartment_Name from member_teacher_staff where MTS_ID like '%" + input + "%' or TS_Name like '%"
                   + input + "%' or Depeartment_Name like '%" + input + "%' order by MTS_ID asc";
            }

            if (query != "")
            {
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                Founded_Members_GridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Select Student or Teacher and Staff");
            }


        }

        // ------------------------------- Teacher and Staff Radio Button Selected -------------------------------------
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select MTS_ID,TS_Name,Depeartment_Name from member_teacher_staff order by MTS_ID asc";
            //MessageBox.Show(book_name, "3");
            mySqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable("CharacterInfo");
            mySqlDataAdapter.Fill(dt);
            Founded_Members_GridView.DataSource = dt;
        }

        // ------------------------------- Student Radio Button Selected -------------------------------------
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select MStu_ID,Student_Name,RollNo from member_student order by MStu_ID asc";
            //MessageBox.Show(book_name, "3");
            mySqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable("CharacterInfo");
            mySqlDataAdapter.Fill(dt);
            Founded_Members_GridView.DataSource = dt;
        }


        //-------     Double on Member - - GridView ---------------------------------
        private void Double_On_GridView(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ID_type = "MStu_ID";
                Memeber_Type = "Student_Name";
            }
            else if (radioButton2.Checked)
            {
                ID_type = "MTS_ID";
                Memeber_Type = "TS_Name";
            }
            if (Founded_Members_GridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = Founded_Members_GridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Founded_Members_GridView.Rows[selectedrowindex];

                Selected_MID = Convert.ToString(selectedRow.Cells[ID_type].Value);
                borrower_name = Convert.ToString(selectedRow.Cells[Memeber_Type].Value);
            }
            
            Borrower_Name_Label.Text = borrower_name +"( "+ Selected_MID +" )";
        }



        //--------------------------- Give the book  to the user -----------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {

            if (this.OpenConnection())
            {

                //decrease book count-------------------------------------------------------------------------------
                string query_to_get_book_count = "select Number_Book from book where Book_ID='" + Selected_BookID + "'";
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
                //-----------------------------------------------------------------------------------------------------

                if (book_count > 0)
                {
                    //insert new member to borrowers table ##############################################################
                    int ID = 0;
                    string last_ID_query = "SELECT max(Borrower_ID) FROM borrowers";
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1.Connection = connection;
                    cmd1.CommandText = last_ID_query;

                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { ID = Convert.ToInt32(reader[0]); }
                            else
                            {
                                ID = 0;
                            }
                        }
                    }
                    ID = ID + 1;

                    // from
                    string Today = DateTime.Now.ToString("yyyy-MM-dd");
                    //initialize a datetime variable with today
                    DateTime today = DateTime.Today;

                    //this line added one week (7 days) with today
                    DateTime after1week = today.AddDays(14);

                    //to 
                    //string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    string book_id, member_id, type, sart_date, end_date;
                    book_id = Selected_BookID;
                    member_id = Selected_MID;
                    type = "Book";
                    sart_date = Today;
                    end_date = after1week.ToString("yyyy-MM-dd");
                    //MessageBox.Show(sart_date);
                    //MessageBox.Show(end_date);


                    if (radioButton1.Checked)
                    {
                        insert_query = "insert into borrowers(Borrower_ID, Book_ID, MStu_ID,Borrow_Type,Start_Date,End_Date)" +
                               " values('" + ID + "','" + book_id + "','" + member_id + "','" + type + "','" + sart_date + "','" + end_date + "'); ";
                        //borrowed count
                        count_borrowed_query = "select count(*) from borrowers where MStu_ID='" + member_id + "'";
                    }
                    else if (radioButton2.Checked)
                    {
                        insert_query = "insert into borrowers(Borrower_ID, Book_ID, MTS_ID,Borrow_Type,Start_Date,End_Date)" +
                               " values('" + ID + "','" + book_id + "','" + member_id + "','" + type + "','" + sart_date + "','" + end_date + "'); ";

                        //borrowed_count
                        count_borrowed_query = "select count(*) from borrowers where MStu_ID='" + member_id + "'";
                    }

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        //get count of member's borrowed book
                        MySqlCommand cmd_count_borrowed = new MySqlCommand();
                        cmd_count_borrowed.Connection = connection;
                        cmd_count_borrowed.CommandText = count_borrowed_query;
                        using (MySqlDataReader reader_borrowed = cmd_count_borrowed.ExecuteReader())
                        {
                            if (reader_borrowed.Read())
                            {
                                if (!reader_borrowed.IsDBNull(0))
                                { borrowed_count = Convert.ToInt32(reader_borrowed[0]); }
                                else
                                {
                                    borrowed_count = 3;
                                }
                            }
                        }

                        if (borrowed_count < 2)
                        {
                            MySqlCommand command = new MySqlCommand(insert_query, connection);
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Query Success!");
                            }
                            else
                            {
                                MessageBox.Show("Query Not Success");
                            }

                            //########################################################################################################


                            // update back with new book count **********************************************************************
                            int update_book_count = book_count - 1;
                            string query_for_update_book_count = "update book set Number_Book=" + update_book_count + " where Book_ID='" + book_id + "'";
                            MySqlCommand command_for_update_bookCount = new MySqlCommand(query_for_update_book_count, connection);
                            if (command_for_update_bookCount.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("Query Success Update!");
                            }
                            else
                            {
                                //MessageBox.Show("Query Not Success Update");
                            }
                        }
                        else MessageBox.Show("Member cann't borrowed more than two books");
                    }
                    else MessageBox.Show("Select Member");
                    //********************************************************************************************************
                }
                else
                {
                    MessageBox.Show("Not enough Items");
                }
                this.CloseConnection();
            }
        }


        //Exit ------------ finished ------------
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }





        //Return Connection String --------- finished -------------
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

        //open connection to database ---------- finished -------------
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

        //Close connection ------- finished ---------------
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

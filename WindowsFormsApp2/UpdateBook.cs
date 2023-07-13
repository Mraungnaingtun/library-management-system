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
    public partial class UpdateBook : UserControl
    {


        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        string B_ID = "", Book_Name = "", Author = "", Category = "",
            Book_Description = "", Place = "", Sub_Category = "", Publisher = "", Edition = "",
            Publish_date = "";
        int Category_ID = 0, price = 0, count = 0;
        string Shelf_ID = "";

        private void Back_to_Book_Main_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        string operation_type = "";
        string query_for_getting_Category_ID = "";
        string query_for_Shelf_ID = "";
        int Shelf_Name = 0, Shelf_Row = 0;

        

        string given_Book_ID;

        public UpdateBook()
        {
            InitializeComponent();
        }
        public UpdateBook(string book_ID)
        {
            InitializeComponent();
            given_Book_ID = book_ID;
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(GetConnectionString());
            loadCategory();
            loadBook_to_Update(given_Book_ID);
        }

        //--------------------------- Load all Category Shelf ---------------------
        private void loadCategory()
        {
            if (this.OpenConnection())
            {
                //----------------- Category -------------------------
                string query1 = "select distinct Category from category";
                MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connection);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "category");
                Category_Combo.DisplayMember = "Category";
                //category_comboBox.ValueMember = "Book_ID";
                Category_Combo.DataSource = ds1.Tables["category"];

                //------------------    Sub_catetory ------------------------
                string query2 = "select distinct Sub_Category from category";
                MySqlDataAdapter da2 = new MySqlDataAdapter(query2, connection);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sub_Category");
                Sub_Category_Combo.DisplayMember = "Sub_Category";
                //category_comboBox.ValueMember = "Book_ID";
                Sub_Category_Combo.DataSource = ds2.Tables["Sub_Category"];


                //----------------- Sub_Category -------------------------
                string query12 = "select distinct shelf_Name from shelf";
                MySqlDataAdapter da12 = new MySqlDataAdapter(query12, connection);
                DataSet ds12 = new DataSet();
                da12.Fill(ds12, "shelf");
                Shelf_Combo.DisplayMember = "shelf_Name";
                //category_comboBox.ValueMember = "Book_ID";
                Shelf_Combo.DataSource = ds12.Tables["shelf"];

                //-----------------   Row --------------------
                string query123 = "select distinct shelf_Row from shelf";
                MySqlDataAdapter da123 = new MySqlDataAdapter(query123, connection);
                DataSet ds123 = new DataSet();
                da123.Fill(ds123, "shelf");
                Shelf_Row_Combox.DisplayMember = "shelf_Row";
                Shelf_Row_Combox.DataSource = ds123.Tables["shelf"];

                this.CloseConnection();
            }
        }

        private void Category_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Category_Combo.Text);
            string query2 = "select distinct Sub_Category from category where Category='" + Category_Combo.Text + "'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query2, connection);
            DataSet ds2 = new DataSet();
            da1.Fill(ds2, "Sub_Category");
            Sub_Category_Combo.DisplayMember = "Sub_Category";
            //category_comboBox.ValueMember = "Book_ID";
            Sub_Category_Combo.DataSource = ds2.Tables["Sub_Category"];
            this.Sub_Category_Combo.SelectedIndex = -1;
        }

        private void Shelf_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query12 = "select distinct shelf_Row from shelf";
            MySqlDataAdapter da12 = new MySqlDataAdapter(query12, connection);
            DataSet ds12 = new DataSet();
            da12.Fill(ds12, "shelf");
            Shelf_Row_Combox.DisplayMember = "shelf_Row";
            Shelf_Row_Combox.DataSource = ds12.Tables["shelf"];
            this.Shelf_Row_Combox.SelectedIndex = -1;
        }

        private void loadBook_to_Update(string book_ID)
        {
            if (this.OpenConnection())
            {
                /*//MessageBox.Show(Selected_BookID);
                string connectionString = GetConnectionString();
                connection = new MySqlConnection(connectionString);*/

                //Fill to the combobox -------------------------
                string query = "select * from book where Book_ID='" + book_ID + "'";
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
                        { Publish_date = reader.GetString(6); }

                        if (!reader.IsDBNull(7))
                        { price = reader.GetInt32(7); }


                        if (!reader.IsDBNull(8))
                        { count = reader.GetInt32(8); }
                        else count = 0;

                        if (!reader.IsDBNull(9))
                        { Book_Description = reader.GetString(9); }
                        else
                        {
                            Book_Description = "";
                        }
                    }
                }

                //query to get  Category and SubCategory 
                string query_for_Category = "select category.Category,category.Sub_Category from library.book left join library.category on book.Category_ID = category.Category_ID where book.Book_ID='" + book_ID + "'";
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

                Category_Combo.SelectedIndex = Category_Combo.FindStringExact(Category);
                Sub_Category_Combo.SelectedIndex = Sub_Category_Combo.FindStringExact(Sub_Category);


                // query to get shelf and row
                string query_for_shelf_and_row = "SELECT shelf.shelf_Name,shelf.shelf_Row FROM library.book left join library.shelf on book.Shelf_ID = shelf.Shelf_ID where book.Book_ID = '" + book_ID + "';";
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandText = query_for_shelf_and_row;

                using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                {
                    if (reader3.Read())
                    {
                        if (!reader3.IsDBNull(0))
                        {
                            Shelf_Name = Convert.ToInt32(reader3.GetString(0));
                        }
                        else
                        {
                            Shelf_Name = 0;
                        }

                        if (!reader3.IsDBNull(1))
                        {
                            Shelf_Row = Convert.ToInt32(reader3.GetString(1));
                        }
                        else
                        {
                            Shelf_Row = 0;
                        }
                    }
                }

                Shelf_Combo.SelectedIndex = Shelf_Combo.FindStringExact(Shelf_Name+"");
                Shelf_Row_Combox.SelectedIndex = Shelf_Row_Combox.FindStringExact(Shelf_Row+"");



                Book_ID_Label.Text = book_ID;
                BookName_Text.Text = Book_Name;
                Author_Text.Text = Author;
                Price_Text.Text = price +"";
                Publisher_Text.Text = Publisher;
                Publish_Date_Text.Text = Publish_date;
                Edition_Text.Text = Edition;
                Number_OF_BOOK_Text.Text = count+"";
                Description_Text.Text = Book_Description;
                this.CloseConnection();
            }
        }

        private void Update_Book_info_Btn_Click(object sender, EventArgs e)
        {
            if (this.OpenConnection())
            {
                //----------------------------- d0---------                 ---------

                int New_Category_ID = 0;

                string New_Sub_Category = "";

                //MessageBox.Show(Category_Combo.Text + "   "+ Sub_Category_Combo.Text);
                if (Sub_Category_Combo.Text == "")
                {
                    New_Sub_Category = null;
                }

                ////------------------- get Category ID ------------------------------
                if (New_Sub_Category == null)
                {
                    query_for_getting_Category_ID = "SELECT * FROM library.category where Category ='" + Category_Combo.Text + "' and Sub_Category is null";
                }
                else query_for_getting_Category_ID = "SELECT Category_ID FROM library.category where Category = '" + Category_Combo.Text + "' and Sub_Category='" + Sub_Category_Combo.Text + "'";
                //   ----------------  Category_ID With ---------------------
                

                MySqlCommand cmd_for_getting_Category_ID = new MySqlCommand();
                cmd_for_getting_Category_ID.Connection = connection;
                cmd_for_getting_Category_ID.CommandText = query_for_getting_Category_ID;

                try
                {
                    using (MySqlDataReader reader = cmd_for_getting_Category_ID.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                New_Category_ID = Convert.ToInt32(reader[0]);
                                //MessageBox.Show(New_Category_ID+"");
                            }
                            else
                            {
                                New_Category_ID = 0;
                            }
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Check Category and Sub Category");
                    //MessageBox.Show(ee.Message);
                }
                
                string New_Shelf_ID = "";
                //get Shelf ID
                query_for_Shelf_ID = "SELECT * FROM library.shelf where shelf_Name = '" + Shelf_Combo.Text + "' and shelf_Row='" + Shelf_Row_Combox.Text + "'";
                MySqlCommand cmd_for_Shelf_ID = new MySqlCommand();
                cmd_for_Shelf_ID.Connection = connection;
                cmd_for_Shelf_ID.CommandText = query_for_Shelf_ID;

                try
                {
                    using (MySqlDataReader reader = cmd_for_Shelf_ID.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                New_Shelf_ID = Convert.ToString(reader[0]);
                            }
                            else
                            {
                                New_Shelf_ID = "";
                            }
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Check Shelf and Sub Shelf Row");
                    //MessageBox.Show(ee.Message);
                }

                int New_Price = 0;
                try
                {
                    New_Price = Convert.ToInt32(Price_Text.Text);
                }
                catch (Exception expection)
                {
                    New_Price = 0;
                }

                int New_Book_Count = 0;
                try
                {
                    New_Book_Count = Convert.ToInt32(Number_OF_BOOK_Text.Text);
                }
                catch (Exception expection)
                {
                    New_Book_Count = 0;
                }


                string query_for_update = "update book set Author='" + Author_Text.Text + "' " +
                    ", Book_Name='" + BookName_Text.Text + "' " +
                    ", Publisher='" + Publisher_Text.Text + "', Edition='" + Edition_Text.Text + "'," +
                    " Category_ID=" + New_Category_ID + ", Year='" + Publisher_Text.Text + "', Price=" + New_Price + "," +
                    " Number_Book=" + New_Book_Count + ", Description='" + Description_Text.Text + "', Shelf_ID='" + New_Shelf_ID + "' where Book_ID='" + Book_ID_Label.Text + "'";

                try
                {
                    MySqlCommand command = new MySqlCommand(query_for_update, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Query Executed");
                    }
                    else
                    {
                        MessageBox.Show("Query Not Executed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
                this.CloseConnection();
            }
        }

        private void Clear_all_textBox_Click(object sender, EventArgs e)
        {
            this.Sub_Category_Combo.DataSource = null;
            BookName_Text.Text = "";
            Author_Text.Text = "";
            this.Category_Combo.DataSource = null;
            Publisher_Text.Text = "";
            Edition_Text.Text = "";
            Number_OF_BOOK_Text.Text = "";
            Price_Text.Text = "";
            Publish_Date_Text.Text = "";
            Description_Text.Text = "";
            this.Shelf_Combo.DataSource = null;
            this.Shelf_Row_Combox.DataSource = null;
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

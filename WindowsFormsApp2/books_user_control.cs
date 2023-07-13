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
    public partial class books_user_control : UserControl
    {

        public books_user_control()
        {
            InitializeComponent();
        }

        //Send for to other user control
        public static string BookName { get; set; }

        /// <summary>
        /// Variables
        /// </summary>
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        string MorE = "";

        // ---------**************------- Control LOAD ----*****************--------
        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.author_name_comboBox.DataSource = null;
            this.category_comboBox.DataSource = null;
            this.Sub_category_ComboBox.DataSource = null;

            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            Myanmar_Radio.Checked = true;

            //Fill to the combobox -------------------------
            if (this.OpenConnection() == true)
            {
                if (Myanmar_Radio.Checked)
                {
                    MorE = "M-";
                }
                else if (English_Radio.Checked)
                {
                    MorE = "E-";
                }

                this.CloseConnection();
            }
            //
            user_type_word.Text = "Enter word...";
        }


        //Search book with Book_Name button click ------- finish --------
        private void Button1_Click(object sender, EventArgs e)
        {
            All_Book_Founded_List founded_book = new All_Book_Founded_List(user_type_word.Text, "");
            founded_book.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(founded_book);
            Form1.Instance.PnlContainer.Controls["All_Book_Founded_List"].BringToFront();
        }


        // ------------------  Language  myanmar radio button check  ---- finish -------------------  
        private void Myanmar_Radio_CheckedChanged(object sender, EventArgs e)
        {
            MorE = "M-";
            // ------------ filling in ------- Author ComboBox -----------------------------
            getAll_Author(MorE);

            // ------------ filling in ------- category_comboBox-------------------
            getAll_Category(MorE);

            // ------------ filling in ------- SubCategory_comboBox-------------------
            //getAll_SubCategory(MorE);
        }


        // ------------------  Language  English radio button check  ---- finish ------------  
        private void English_Radio_CheckedChanged(object sender, EventArgs e)
        {
            MorE = "E-";
            // ------------ filling in ------- Author ComboBox -----------------------------
            getAll_Author(MorE);

            // ------------ filling in ------- category_comboBox-------------------
            getAll_Category(MorE);

            // ------------ filling in ------- SubCategory_comboBox-------------------
            //getAll_SubCategory(MorE);
        }


        // ----------------- Author Name ComboBox Selected ---- finish -----------------
        private void Author_name_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string author = author_name_comboBox.Text;
            string query1 = "SELECT distinct category.Category FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where book.Author='" + author + "' order by category.Category asc";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "book");
            category_comboBox.DisplayMember = "Category";
            //category_comboBox.ValueMember = "Book_ID";
            category_comboBox.DataSource = ds1.Tables["book"];
            this.category_comboBox.SelectedIndex = -1;
        }


        // Category ComboBox Selected Change  ---- finish -----------------
        private void Category_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string category = category_comboBox.Text;
            string author = author_name_comboBox.Text;

            try
            {
                if (author_name_comboBox.Text != "")
                {
                    // ------------ filling in ------- sub_category_comboBox
                    string query2 = "SELECT distinct category.Sub_Category FROM library.book " +
                        "LEFT JOIN library.category ON book.Category_ID = category.Category_ID where book.Author='" + author + "' and category.Category = '" + category + "' order by category.Sub_Category asc";
                    MySqlDataAdapter da2 = new MySqlDataAdapter(query2, connection);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "book");
                    Sub_category_ComboBox.DisplayMember = "Sub_Category";
                    //Sub_category_ComboBox.ValueMember = "Book_ID";
                    Sub_category_ComboBox.DataSource = ds2.Tables["book"];
                    this.Sub_category_ComboBox.SelectedIndex = -1;
                }
                else
                {
                    // ------------ filling in ------- sub_category_comboBox
                    string query2 = "SELECT distinct category.Sub_Category FROM library.book " +
                        "LEFT JOIN library.category ON book.Category_ID = category.Category_ID where category.Category = '" + category + "' order by category.Sub_Category asc";
                    MySqlDataAdapter da2 = new MySqlDataAdapter(query2, connection);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "book");
                    Sub_category_ComboBox.DisplayMember = "Sub_Category";
                    //Sub_category_ComboBox.ValueMember = "Book_ID";
                    Sub_category_ComboBox.DataSource = ds2.Tables["book"];
                    this.Sub_category_ComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception eee)
            {

            }
        }


        //Add book Control ---- finish -----------------
        private void AddBook_from_BookSearch_Control_Click(object sender, EventArgs e)
        {
            AddNewBook addnewbook = new AddNewBook("add");
            addnewbook.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(addnewbook);
            Form1.Instance.PnlContainer.Controls["AddNewBook"].BringToFront();
        }


        // ------------------- Call all book Update Button User Control -- finished ------------------
        private void Button1_Click_1(object sender, EventArgs e)
        {
            UpdateBook_Control allbookcontrol = new UpdateBook_Control();
            allbookcontrol.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(allbookcontrol);
            Form1.Instance.PnlContainer.Controls["UpdateBook_Control"].BringToFront();

        }


        //##################################################################################
        //-------- fill All Author to ComboBox -------- finished --------------
        private void getAll_Author(string more)
        {
            string str = more;
            // ------------ filling in -------author_name_comboBox--------------------------------------------
            string query = "select distinct Author from book where Book_ID like '" + str + "%' order by Author asc";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "book");
            author_name_comboBox.DisplayMember = "Author";
            //author_name_comboBox.ValueMember = "Book_ID";
            author_name_comboBox.DataSource = ds.Tables["book"];
            this.author_name_comboBox.SelectedIndex = -1;
        }


        //-------- fill All Category to ComboBox -------- finished --------------
        private void getAll_Category(string more)
        {
            string str = more;
            string query1 = "SELECT distinct category.Category FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where book.Book_ID like '" + str + "%' order by category.Category asc";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "book");
            category_comboBox.DisplayMember = "Category";
            //category_comboBox.ValueMember = "Book_ID";
            category_comboBox.DataSource = ds1.Tables["book"];
            this.category_comboBox.SelectedIndex = -1;
        }


        //-------- fill All Category to ComboBox -------- finished --------------
        private void getAll_SubCategory(string more)
        {
            string str = more;
            // ------------ filling all in ------- sub_category_comboBox
            string query2 = "SELECT distinct category.Sub_Category FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where book.Book_ID like '" + str + "' order by category.Sub_Category asc;";
            MySqlDataAdapter da2 = new MySqlDataAdapter(query2, connection);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "book");
            Sub_category_ComboBox.DisplayMember = "Sub_Category";
            //Sub_category_ComboBox.ValueMember = "Book_ID";
            Sub_category_ComboBox.DataSource = ds2.Tables["book"];
            this.Sub_category_ComboBox.SelectedIndex = -1;
        }

        //##################################################################################


        //Clear All ComboBox ---- finished ---------------
        private void Clear_ComboBox_Click(object sender, EventArgs e)
        {
            Sub_category_ComboBox.DataSource = null;
            // ------------ refilling in ------- Author ComboBox -----------------------------
            getAll_Author(MorE);

            // ------------ refilling in ------- category_comboBox-------------------
            getAll_Category(MorE);

        }


        // ------------------ return connection String   ---------- finished -------------------------
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


        // ----------------- Just for Text search ------ finished ------------------------
        private void IFEnter_Search_Text(object sender, EventArgs e)
        {
            if (user_type_word.Text == "Enter word...")
            {
                user_type_word.Text = "";
            }
        }


        // ----------------- Just for Text search ------ finished ------------------------
        private void User_type_word_Leave(object sender, EventArgs e)
        {

            if (user_type_word.Text == "")
            {
                user_type_word.Text = "Enter word...";
            }
        }


        // --------------------------- Load Deleting_Book_Control --------- finished -------------- 
        private void Button6_Click(object sender, EventArgs e)
        {
            Deleting_Book_Control cntrol = new Deleting_Book_Control();
            cntrol.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(cntrol);

            Form1.Instance.PnlContainer.Controls["Deleting_Book_Control"].BringToFront();
        }


        // ----------------- Just for Text search ------ finished ------------------------
        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                All_Book_Founded_List founded_book = new All_Book_Founded_List(user_type_word.Text, "");
                founded_book.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(founded_book);

                Form1.Instance.PnlContainer.Controls["All_Book_Founded_List"].BringToFront();
            }
            /*if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }*/
        }

        // --------------- Filter button ---- finished -----------------------
        private void Button1_Click_2(object sender, EventArgs e)
        {

            string query = null;
            query = "SELECT book.Book_ID,book.Book_Name,book.Author,category.Category,category.Sub_Category,book.Number_Book FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where";

            //if select only author name
            if (author_name_comboBox.Text != "")
            {
                query += " book.Author='" + author_name_comboBox.Text + "'";
            }

            //if select author and category
            if (author_name_comboBox.Text != "" && category_comboBox.Text != "")
            {
                //put and
                query += " and category.Category='" + category_comboBox.Text + "'";

            }

            //if select only category
            else if (category_comboBox.Text != "")
            {
                query += " category.Category='" + category_comboBox.Text + "'";
            }

            //if select category and subcategory
            if (category_comboBox.Text != "" && Sub_category_ComboBox.Text != "")
            {
                //put and
                query += " and Sub_Category='" + Sub_category_ComboBox.Text + "'";
            }
            else if (category_comboBox.Text != "")
            {

            }

            // MessageBox.Show(query);
            if (query != "SELECT book.Book_ID,book.Book_Name,book.Author,category.Category,category.Sub_Category,book.Number_Book FROM library.book LEFT JOIN library.category ON book.Category_ID = category.Category_ID where")
            {
                All_Book_Founded_List founded_book = new All_Book_Founded_List("", query);
                founded_book.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(founded_book);

                Form1.Instance.PnlContainer.Controls["All_Book_Founded_List"].BringToFront();
            }
        }

    }
}

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
    public partial class AddNewBook : UserControl
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        string M_last = "", E_Last = "";
        byte[] img;

        string B_ID = "", Book_Name = "", Author = "", Category = "",
            Book_Description = "", Place = "", Sub_Category = "", Publisher = "", Edition = "",
            Publish_date = "";
        int Category_ID = 0;
        string Shelf_ID = "";
        string operation_type = "";
        string query_for_getting_Category_ID;
        string query_for_Shelf_ID;

        public AddNewBook()
        {
            InitializeComponent();
        }

        public AddNewBook(string operation)
        {
            InitializeComponent();
            this.operation_type = operation;
        }

        // ------------------------------- Control Load -------------------------------------------
        private void AddNewBook_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            Myanmar_RadioButton.Checked = true;

            Myanmar_RadioButton.Visible = true;
            Eng_RadioButton.Visible = true;
            Add_New_Book_btn.Visible = true;
            if (this.OpenConnection() == true)
            {
                loadCategory();
                this.Category_Combo.SelectedIndex = -1;
                this.Shelf_Combo.SelectedIndex = -1;
                this.CloseConnection();
            }

        }

        private void loadCategory()
        {
            //----------------- Category -------------------------
            string query1 = "select distinct Category from category";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "category");
            Category_Combo.DisplayMember = "Category";
            //category_comboBox.ValueMember = "Book_ID";
            Category_Combo.DataSource = ds1.Tables["category"];

            //----------------- Sub_Category -------------------------
            string query12 = "select distinct shelf_Name from shelf";
            MySqlDataAdapter da12 = new MySqlDataAdapter(query12, connection);
            DataSet ds12 = new DataSet();
            da12.Fill(ds12, "shelf");
            Shelf_Combo.DisplayMember = "shelf_Name";
            //category_comboBox.ValueMember = "Book_ID";
            Shelf_Combo.DataSource = ds12.Tables["shelf"];
        }

        //% % % % % % % % % % % % % % ------------ Add Book----- % % % % % % % % % % % % % % % % % % % %
        // Adding a book operation
        private void Add_New_Book_btn_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;


            string FileName = Image_Name_Label.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            img = ms.ToArray();

            B_ID = Book_ID_Text.Text;
            Book_Name = BookName_Text.Text;
            Author = Author_Text.Text;
            // ----------------------------------
            Category = Category_Combo.Text;
            Sub_Category = Sub_Category_Combo.Text;
            // --------------------------------------
            Publisher = Publisher_Text.Text;
            Edition = Edition_Text.Text;
            Publish_date = Publish_Date_Text.Text;
            Book_Description = Description_Text.Text;
            //---------------------------------------------------
            Place = Shelf_Combo.Text + "-" + Row_Combo.Text;

            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (B_ID != "" && Book_Name != "" && Author != ""
                && Category != "" && Number_OF_BOOK_Text.Text != "")
            {
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        count = Int32.Parse(Number_OF_BOOK_Text.Text);

                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }

                    try
                    {
                        price = Int32.Parse(Price_Text.Text);
                    }
                    catch (Exception exe)
                    {
                        price = 0;
                    }

                    try
                    {
                        Publish_date = Publisher_Text.Text;

                    }
                    catch (Exception edd)
                    {

                    }

                    if (Sub_Category_Combo.Text == "")
                    {
                        Sub_Category = null;
                    }
                    if (Sub_Category == null)
                    {
                        query_for_getting_Category_ID = "SELECT * FROM library.category where Category ='" + Category + "' and Sub_Category is null";
                    }
                    else query_for_getting_Category_ID = "SELECT Category_ID FROM library.category where Category = '" + Category + "' and Sub_Category='" + Sub_Category + "'";
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
                                    Category_ID = Convert.ToInt32(reader[0]);
                                }
                                else
                                {
                                    Category_ID = 0;
                                }
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Check Category and Sub Category");
                        //MessageBox.Show(ee.Message);
                    }



                    //-------------- Get Shelf ID  --------------------------------
                    query_for_Shelf_ID = "SELECT * FROM library.shelf where shelf_Name = '" + Shelf_Combo.Text + "' and shelf_Row='" + Row_Combo.Text + "'";
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
                                    Shelf_ID = Convert.ToString(reader[0]);
                                }
                                else
                                {
                                    Shelf_ID = "";
                                }
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Check Shelf and Sub Shelf Row");
                        //MessageBox.Show(ee.Message);
                    }

                    if (Shelf_Combo.Text != "" && Row_Combo.Text != "")
                    {
                        // --------------------- insert book -------------------------
                        string query = "insert into book(Book_ID,Author,Book_Name,Publisher,Edition,Year,Price,Category_ID,Number_Book,Description,Shelf_ID,Book_Image)" +
                        " values('" + B_ID + "','" + Author + "','" + Book_Name + "','" + Publisher + "','" + Edition + "','" + Publish_date + "'," + price + ",'" + Category_ID + "'," + count + ",'" + Book_Description + "','" + Shelf_ID + "','"+ ImageData + "'); ";
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, connection);
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

                        Book_ID_Text.Text = "";
                        BookName_Text.Text = "";
                        Author_Text.Text = "";

                        Publisher_Text.Text = "";
                        Edition_Text.Text = "";
                        Number_OF_BOOK_Text.Text = "";
                        Price_Text.Text = "";
                        Publish_Date_Text.Text = "";
                        Description_Text.Text = "";


                        string query1 = "select distinct Category from category";
                        MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connection);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "category");
                        Category_Combo.DisplayMember = "Category";
                        //category_comboBox.ValueMember = "Book_ID";
                        Category_Combo.DataSource = ds1.Tables["category"];
                        this.Category_Combo.SelectedIndex = -1;



                        string query12 = "select distinct shelf_Name from shelf";
                        MySqlDataAdapter da12 = new MySqlDataAdapter(query12, connection);
                        DataSet ds12 = new DataSet();
                        da12.Fill(ds12, "shelf");
                        Shelf_Combo.DisplayMember = "shelf_Name";
                        //category_comboBox.ValueMember = "Book_ID";
                        Shelf_Combo.DataSource = ds12.Tables["shelf"];
                        this.Shelf_Combo.SelectedIndex = -1;

                    }
                    else MessageBox.Show("Select shelf");

                }
            }
            else MessageBox.Show("Insert Essential Data!!");
        }

        //Load Image Btn ------------------------------
        private void LoadImage_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image_Name_Label.Text = opf.FileName;
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }


        // --------------------- Choose Myanmar Book Radio Button ------------------------------
        private void Myanmar_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            string last_ID_query = "SELECT max(Book_ID) FROM book where Book_ID like 'M-%'";
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = last_ID_query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        M_last = (string)reader[0];
                    }
                }

                // MessageBox.Show(last_value);

                this.CloseConnection();
            }

            Book_ID_Text.Text = "M-" + Get_Last_ID(M_last);

        }


        // --------------------- Choose English Book Radio Button ------------------------------
        private void Eng_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            string last_ID_query = "SELECT max(Book_ID) FROM book where Book_ID like 'E-%'";
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = last_ID_query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        E_Last = (string)reader[0];
                    }
                }

                // MessageBox.Show(last_value);

                this.CloseConnection();
            }

            Book_ID_Text.Text = "E-" + Get_Last_ID(E_Last);
        }


        // --------------------------Shelf ComboBox Selected Changed --------------
        private void Shelf_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query12 = "select distinct shelf_Row from shelf";
            MySqlDataAdapter da12 = new MySqlDataAdapter(query12, connection);
            DataSet ds12 = new DataSet();
            da12.Fill(ds12, "shelf");
            Row_Combo.DisplayMember = "shelf_Row";
            Row_Combo.DataSource = ds12.Tables["shelf"];
            this.Row_Combo.SelectedIndex = -1;
        }

        // ------------------------- Category ComboBox Selected Changed --------------
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


        // ------------------------------- Clear all TextBox  -------------------------------
        private void Clear_all_textBox_Click(object sender, EventArgs e)
        {
            Book_ID_Text.Text = "";
            BookName_Text.Text = "";
            Author_Text.Text = "";
            this.Category_Combo.DataSource = null;
            this.Sub_Category_Combo.DataSource = null;
            Publisher_Text.Text = "";
            Edition_Text.Text = "";
            Number_OF_BOOK_Text.Text = "";
            Price_Text.Text = "";
            Publish_Date_Text.Text = "";
            Description_Text.Text = "";
            this.Shelf_Combo.DataSource = null;
            this.Row_Combo.DataSource = null;
        }


        //Exit
        private void Back_to_Book_Main_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        int count = 0, price = 0;

        // return Last Book Id To add A new Book
        private string Get_Last_ID(string request)
        {
            string need = "";
            string str = request;
            int last_book_ID = Int32.Parse(str.Substring(2));
            string temp = "";
            for (int i = 1; i <= 5 - last_book_ID.ToString().Length; i++)
            {
                temp += "0";
            }
            last_book_ID = last_book_ID + 1;
            temp += last_book_ID.ToString();
            need = temp;

            return need;
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

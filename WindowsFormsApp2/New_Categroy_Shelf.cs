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
    public partial class New_Categroy_Shelf : UserControl
    {
        public New_Categroy_Shelf()
        {
            InitializeComponent();
        }


        // for Database
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;

        // for class
        int Category_ID;
        string Category, Sub_Category;


        // ------------------------------ Load -----------------------------------
        private void New_Categroy_Shelf_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            Update_Delete_Panel.Visible = false;
            Double_Click_Update_Delete.Visible = true;
            Title_Update_Delete.Visible = false;
            //Fill to the combobox -------------------------
            All_Category_GridVIew.RowTemplate.Height = 35;
            All_Category_GridVIew.DataSource = GetView();

            int ID = 0;
            string last_ID_query = "SELECT max(Category_ID) FROM category";
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = last_ID_query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }

                ID += 1;
                Last_ID_Text.Text = ID + "";

                this.CloseConnection();
            }
        }

        // -------------------------------- Double Click -------- GridView ------------------------
        private void DoubleOn_GridView(object sender, EventArgs e)
        {
            Update_Delete_Panel.Visible = true;
            Title_Update_Delete.Visible = true;
            Double_Click_Update_Delete.Visible = false;

            if (All_Category_GridVIew.SelectedCells.Count > 0)
            {
                int selectedrowindex = All_Category_GridVIew.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = All_Category_GridVIew.Rows[selectedrowindex];

                Category_ID = Convert.ToInt32(selectedRow.Cells["Category_ID"].Value);
                //MessageBox.Show(Selected_BookID);
            }


            if (this.OpenConnection() == true)
            {
                string query = "select * from category where Category_ID=" + Category_ID;
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(1))
                        { Category = reader.GetString(1); }
                        else
                        {
                            Category = "Unknown";
                        }

                        if (!reader.IsDBNull(2))
                        {
                            Sub_Category = reader.GetString(2);
                        }
                        else
                        {
                            Sub_Category = "Unknown";
                        }
                    }
                }
                Selected_ID_Label.Text = "" + Category_ID;
                Category_Update_Text.Text = Category;
                Sub_Category_Update_Text.Text = Sub_Category;

                this.CloseConnection();
            }
        }

        // ------------------------------ Add New -----------------------------------
        private void Add_Category_Btn_Click(object sender, EventArgs e)
        {
            String Category = "", Sub_Category = "";
            int Last__ID = Convert.ToInt32(Last_ID_Text.Text);
            Category = Category_Add_Text.Text;
            Sub_Category = Sub_Category_Add_Text.Text;

            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                string query = "insert into category(Category_ID,Category,Sub_Category)" +
                       " values('" + Last__ID + "','" + Category + "','" + Sub_Category + "'); ";

                try
                {
                    if (Category_Add_Text.Text != "" && Sub_Category_Add_Text.Text != "")
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Query Executed");

                            // when finished adding 
                            Category_Add_Text.Text = "";
                            Sub_Category_Add_Text.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Query Not Executed");
                        }
                    }
                    else MessageBox.Show("ဆုတောင်း");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }

                // -------------------- refreshing Last ID ------------------------------
                int ID = 0;
                string last_ID_query = "SELECT max(Category_ID) FROM category";
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = last_ID_query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }

                ID += 1;
                Last_ID_Text.Text = ID + "";


                //------------------ Refreshing GridView --------------------- 
                string query_for_combox = "select * from category";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query_for_combox, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                All_Category_GridVIew.DataSource = dt;


                this.CloseConnection();
            }
        }

        // ------------------------------ Update -----------------------------------
        private void Update_Cateogry_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
               
                //MessageBox.Show(Category_Update_Text.Text);
                string update_query = "update category set Category = '" + Category_Update_Text.Text + "', Sub_Category = '" 
                    + Sub_Category_Update_Text.Text + "' where Category_ID = " + Convert.ToInt32(Selected_ID_Label.Text);

                try
                {

                    if (Selected_ID_Label.Text!= "0" && Category_Update_Text.Text != "" && Sub_Category_Update_Text.Text!="")
                    {
                        MySqlCommand command = new MySqlCommand(update_query, connection);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("Query Executed");
                            // when finished adding 
                        }
                        else
                        {
                            MessageBox.Show("Query Not Executed");
                        }
                    } else MessageBox.Show("ဆုတောင်း");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
                Category_Update_Text.Text = "";
                Sub_Category_Update_Text.Text = "";
                Selected_ID_Label.Text = "0";

                //------------------ Refreshing GridView --------------------- 
                string query_for_combox = "select * from category";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query_for_combox, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                All_Category_GridVIew.DataSource = dt;

                this.CloseConnection();
            }
        }

        // ------------------------------ Delete -----------------------------------
        private void Delete_Category_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {

                //MessageBox.Show(Category_Update_Text.Text);
                string update_query = "delete from category where Category_ID=" + Convert.ToInt32(Selected_ID_Label.Text);

                try
                {
                    if (Selected_ID_Label.Text != "0")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you Sure to delete", "Deleting Category", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MySqlCommand command = new MySqlCommand(update_query, connection);
                            if (command.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("Query Executed");
                                // when finished adding 
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
                        
                    }else MessageBox.Show("ဆုတောင်း");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
                Category_Update_Text.Text = "";
                Sub_Category_Update_Text.Text = "";
                Selected_ID_Label.Text = "0";

                //------------------ Refreshing GridView --------------------- 
                string query_for_combox = "select * from category";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query_for_combox, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                All_Category_GridVIew.DataSource = dt;

                this.CloseConnection();
            }
        }

        //------------------------------------- Search Btn -----------------------------------
        private void Search_Category_Btn_Click(object sender, EventArgs e)
        {
            string connectionStr = GetConnectionString();
            connection = new MySqlConnection(connectionStr);

            string User_Input = Search_Category_Text.Text;

            if (this.OpenConnection() == true)
            {
                string query = "select * from category where Category like '%" + User_Input + "%' or Sub_Category like '%" + User_Input + "%'";

                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);

                //close connection
                this.CloseConnection();

                All_Category_GridVIew.DataSource = dt;
            }
        }

        // ---------------------- to book shelf -----------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            Control_Book_Shelf book_shelf = new Control_Book_Shelf();
            book_shelf.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(book_shelf);

            Form1.Instance.PnlContainer.Controls["Control_Book_Shelf"].BringToFront();
        }

        /*
         * Database Methods ------------- 
         * 
         */

        private DataTable GetView()
        {
            if (this.OpenConnection() == true)
            {
                string query = "select * from category";
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

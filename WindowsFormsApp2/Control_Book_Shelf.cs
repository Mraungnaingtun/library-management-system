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
    public partial class Control_Book_Shelf : UserControl
    {

        // for Database
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        MySqlDataAdapter mySqlDataAdapter;

        // for class ---------------
        int shelf_ID;
        string shelf, row;

        public Control_Book_Shelf()
        {
            InitializeComponent();
        }

        // -------------- eixt btn -----------------
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // ------------------ load -------------------------------------
        private void Control_Book_Shelf_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            shelf_GridView.RowTemplate.Height = 35;
            shelf_GridView.DataSource = GetView();
            shelf_Update_text.Text = "";

            Double_Click_Update_Delete.Visible = true;
            Update_Delete_Panel.Visible = false;
            Title_Update_Delete.Visible = false;

            /*//load last id for add new shelf
            //Last_id_label
            *//*int ID = 0;
            string last_ID_query = "SELECT max(shelf_ID) FROM shelf";
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
                Last_id_label.Text = ID + "";*//*

                this.CloseConnection();
            }*/


        }

        // --------------------- double click to gridview ----------------------
        private void Double_Click_GridVIew(object sender, EventArgs e)
        {
            Double_Click_Update_Delete.Visible = false;
            Update_Delete_Panel.Visible = true;
            Title_Update_Delete.Visible = true;

            if (shelf_GridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = shelf_GridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = shelf_GridView.Rows[selectedrowindex];

                shelf_ID = Convert.ToInt32(selectedRow.Cells["shelf_ID"].Value);
                //MessageBox.Show(shelf_ID+"");
            }

            if (this.OpenConnection() == true)
            {
                string query = "select * from shelf where shelf_ID=" + shelf_ID;
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(1))
                        { shelf = reader.GetString(1); }
                        else
                        {
                            shelf = "Unknown";
                        }

                        if (!reader.IsDBNull(2))
                        {
                            row = reader.GetString(2);
                        }
                        else
                        {
                            row = "Unknown";
                        }
                    }
                }
                Selected_shelf_ID.Text = "" + shelf_ID;
                shelf_Update_text.Text = shelf;
                row_update_Text.Text = row;

                this.CloseConnection();
            }
        }

        // ---------------------- Add ----------------------------
        private void Add_Book_Shelf_Btn_Click(object sender, EventArgs e)
        {
            String SHELF = "", ROW = "";
            int Last__ID = Convert.ToInt32(Last_id_label.Text);
            SHELF = shelf_Add_text.Text;
            ROW = row_Add_Text.Text;

            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                string query = "insert into shelf(shelf_ID,shelf_Name,shelf_Row)" +
                       " values('" + Last__ID + "','" + SHELF + "','" + ROW + "'); ";

                try
                {
                    if (shelf_Add_text.Text != "" && row_Add_Text.Text != "")
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Query Executed");

                            // when finished adding 
                            shelf_Add_text.Text = "";
                            row_Add_Text.Text = "";
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
                string last_ID_query = "SELECT max(shelf_ID) FROM shelf";
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
                Last_id_label.Text = ID + "";


                //------------------ Refreshing GridView --------------------- 
                string query123 = "select * from shelf";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query123, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                shelf_GridView.DataSource = dt;


                this.CloseConnection();
            }
        }

        // --------------------- update ------------------------------
        private void Update_shelf_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                try
                {

                    if (Selected_shelf_ID.Text != "0" && shelf_Update_text.Text != "" && row_update_Text.Text != "")
                    {
                        string update_query = "update shelf set shelf_Name = '" + Convert.ToInt32(shelf_Update_text.Text) + "', shelf_Row = '"
                    + Convert.ToInt32(row_update_Text.Text) + "' where shelf_ID = " + Convert.ToInt32(Selected_shelf_ID.Text);  

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
                    else MessageBox.Show("ဆုတောင်း");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
                shelf_Update_text.Text = "";
                row_update_Text.Text = "";
                Selected_shelf_ID.Text = "0";

                //------------------ Refreshing GridView --------------------- 
                string query = "select * from shelf";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                shelf_GridView.DataSource = dt;

                this.CloseConnection();
            }
        }

        // -------------------------- delete -------------------
        private void Delete_shelf_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {

                //MessageBox.Show(Category_Update_Text.Text);
                string update_query = "delete from shelf where shelf_ID=" + Convert.ToInt32(Selected_shelf_ID.Text);

                try
                {
                    if (Selected_shelf_ID.Text != "0")
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

                shelf_Update_text.Text = "";
                row_update_Text.Text = "";
                Selected_shelf_ID.Text = "0";

                //------------------ Refreshing GridView --------------------- 
                string query = "select * from shelf";
                //MessageBox.Show(book_name, "3");
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                mySqlDataAdapter.Fill(dt);
                shelf_GridView.DataSource = dt;

                this.CloseConnection();
            }
        }

        


        // database methods ------
        private DataTable GetView()
        {
            if (this.OpenConnection() == true)
            {
                string query = "select * from shelf";
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

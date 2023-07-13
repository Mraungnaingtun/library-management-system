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
    public partial class AllFound_Project_OQ : UserControl
    {
        string keyword = "";
        string filter_query = "";
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        public AllFound_Project_OQ()
        {
            InitializeComponent();
        }

        public AllFound_Project_OQ(string data, string query)
        {
            InitializeComponent();
            keyword = data;
            filter_query = query;
        }

        private void AllFound_Project_OQ_Load(object sender, EventArgs e)
        {
            Project_OR_OQ_GridView.RowTemplate.Height = 45;
            connection = new MySqlConnection(getConnectionString());
            NoItemFound_Label.Visible = false;
            if (keyword != "")
            {
                //MessageBox.Show(keyword);
                Project_OR_OQ_GridView.DataSource = GetView_By_Book_Name(keyword);
               
            }
            else if (filter_query != "")
            {
                Project_OR_OQ_GridView.DataSource = GetView_By_FilterQuery(filter_query);
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public DataTable GetView_By_Book_Name(string given_keyword)
        {
           
            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                //-----------------
                string query_with_keyword = "SELECT project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old left join library.allsubject " +
                    "on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Subject_Name like '%"+ given_keyword + "%' or allsubject.Paper_No like '%"+ given_keyword + "%' or allsubject.Year like '%"+ given_keyword + "%' or project_old.Semester like '%"+ given_keyword + "%' or project_old.Academic_Year like '%"+ given_keyword + "%';";

                MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(query_with_keyword, connection);
                DataTable dt2 = new DataTable("CharacterInfo");
                mySqlDataAdapter2.Fill(dt2);
                
                this.CloseConnection();
                dt = dt2;

                
                int totalRows = dt.Rows.Count;
                if (totalRows < 1)
                {
                    NoItemFound_Label.Visible = true;
                    Project_OR_OQ_GridView.Visible = false;
                    Result_Count_Label.Text = "0 Item Found";
                    return null;
                }
                else
                {
                    if (totalRows > 1)
                    {
                        Result_Count_Label.Text = totalRows +" Items Found";
                    }
                    else if (totalRows == 1)
                    {
                        Result_Count_Label.Text = totalRows +" Item Found";
                    }
                    return dt;
                }
            }
            else return null;
        }

        public DataTable GetView_By_FilterQuery(string given_filter_query)
        {
            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                //-----------------
                MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(given_filter_query, connection);
                DataTable dt2 = new DataTable("CharacterInfo");
                mySqlDataAdapter2.Fill(dt2);
                dt = dt2;
                int totalRows = dt.Rows.Count;
                this.CloseConnection();
                if (totalRows < 1)
                {
                    NoItemFound_Label.Visible = true;
                    Project_OR_OQ_GridView.Visible = false;
                    Result_Count_Label.Text = "0 Item Found";
                    return null;
                }
                else
                {
                    if (totalRows > 1)
                    {
                        Result_Count_Label.Text = totalRows +" Items Found";
                    }
                    else if (totalRows == 1)
                    {
                        Result_Count_Label.Text = totalRows + " Item Found";
                    }
                    return dt;
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

    }
}

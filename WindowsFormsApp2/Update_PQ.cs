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
    public partial class Update_PQ : UserControl
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        public Update_PQ()
        {
            InitializeComponent();
        }

        private void Update_PQ_Load(object sender, EventArgs e)
        {
            Old_Question_RadioBtn.Checked = true;
            FoundPQ_GridView.RowTemplate.Height = 45;
            connection = new MySqlConnection(getConnectionString());
                Class_ComboBox.DataSource = new[]{
                "First Year",
                "Second Year",
                "Third Year",
                "Fourth Year",
                "Fifth Year"
                };
                Class_ComboBox.SelectedIndex = -1;

                Academic_Year_ComboBox.DataSource = new[]{
                "2016",
                "2017",
                "2018",
                "2019",
                "2020",
                "2021"
                };
                Academic_Year_ComboBox.SelectedIndex = -1;
        }

        //--------- First Year ------------------------
        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query_for_filter = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Year='" + Class_ComboBox.Text + "' and project_old.Type='" + getType() + "' ";
            FoundPQ_GridView.DataSource = GetView_By_FilterQuery(query_for_filter);
            /*getPaper(Class_ComboBox.Text, getType(), "");*/


        }

        //--------------- 2017 -----------------------------
        private void Academic_Year_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Class_ComboBox.Text != "")
            {
                string query_for_filter = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Year='" + Class_ComboBox.Text + "' and project_old.Type='" + getType() + "' and project_old.Academic_Year='" + Academic_Year_ComboBox.Text + "'";
                FoundPQ_GridView.DataSource = GetView_By_FilterQuery(query_for_filter);
                /*getPaper(Class_ComboBox.Text, getType(), Academic_Year_ComboBox.Text);*/
            }
            else
            {
                string query_for_filter = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where project_old.Academic_Year='" + Academic_Year_ComboBox.Text + "' and project_old.Type='" + getType() + "' ";
                FoundPQ_GridView.DataSource = GetView_By_FilterQuery(query_for_filter);
                /*getPaper("", getType(), Academic_Year_ComboBox.Text);*/
            }


        }

        private string getType()
        {
            string type = "";
            if (Old_Question_RadioBtn.Checked) type = "Old Question";
            else if (Project_RadioBtn.Checked) type = "Project";

            return type;

        }

        public DataTable GetView_By_FilterQuery(string given_filter_query)
        {
            
                DataTable dt = new DataTable();

                //-----------------
                MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(given_filter_query, connection);
                DataTable dt2 = new DataTable("CharacterInfo");
                mySqlDataAdapter2.Fill(dt2);
                dt = dt2;
                int totalRows = dt.Rows.Count;
                return dt;
            

        }
        /// <summary>
        /// -----------Database Functions--------------------
        /// </summary>
        /// <returns></returns>
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

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}

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
    public partial class NewPQ_Adding : UserControl
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        //-----------
        string operation = "";
        int given_id = 0;

        public NewPQ_Adding()
        {
            InitializeComponent();
        }

        public NewPQ_Adding(string opr,int id)
        {
            InitializeComponent();
            operation = opr;
            given_id = id;
        }

        private void NewPQ_Adding_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(getConnectionString());


            if (operation == "Add")
            {
                Old_Question_RadioBtn.Checked = true;
                Update_Btn.Visible = false;
                Add_New_Btn.Visible = true;
                PQ_ID_Label.Text = GetLastID() + "";

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
                /*getSubject();
                getPaper_Name();*/

                Semester_ComboBox.DataSource = new[]{
                    "first",
                    "second"
                };

            }
            else if (operation == "Update")
            {
                Add_New_Btn.Visible = false;
                Update_Btn.Visible = true;
            }
        }

        private void getSubject(string year)
        {
            //MessageBox.Show(Year+"  "+getType());
            // ------------ filling in -------author_name_comboBox--------------------------------------------
            if (this.OpenConnection())
            {
                string query = "select distinct allsubject.Subject_Name from library.allsubject left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID where allsubject.Year='" + year + "' and project_old.Type='"+getType()+"' order by allsubject.Subject_Name asc";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "allsubject");
                Subject_Name_ComboBox.DisplayMember = "Subject_Name";
                //author_name_comboBox.ValueMember = "Book_ID";
                Subject_Name_ComboBox.DataSource = ds.Tables["allsubject"];
                this.Subject_Name_ComboBox.SelectedIndex = -1;

                this.CloseConnection();
            }
        }

        private void getPaper_Name(string year)
        {
            //MessageBox.Show(Year+"  "+getType());
            // ------------ filling in -------author_name_comboBox--------------------------------------------
            if (this.OpenConnection())
            {
                string query = "select distinct allsubject.Paper_No from library.allsubject left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID where allsubject.Year='" + year + "' and project_old.Type='" + getType() + "' order by allsubject.Paper_No asc";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "allsubject");
                Paper_No_ComboBox.DisplayMember = "Paper_No";
                //author_name_comboBox.ValueMember = "Book_ID";
                Paper_No_ComboBox.DataSource = ds.Tables["allsubject"];
                this.Paper_No_ComboBox.SelectedIndex = -1;

                this.CloseConnection();
            }
        }

        // ---------- Update 
        private void Update_Btn_Click(object sender, EventArgs e)
        {

        }

        //--------------- Add New 
        private void Add_New_Btn_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(getSubject_ID()+"");
            int pq_id = Convert.ToInt32(PQ_ID_Label.Text);
            //
            
            string sem = getSem();
            string P_or_Q = getType();
            int academic_year = 0;
            int copies = 0;
            int subject_id = 0;

            string description = Description_Text.Text;

            if (Paper_No_ComboBox.Text != "")
            {
                if (Subject_Name_ComboBox.Text != "")
                {
                    //--------Subject ID-----------------
                    subject_id = getSubject_ID();

                    if (Academic_Year_ComboBox.Text != "")
                    {
                        //----------- Academic Year------------
                        academic_year = Convert.ToInt32(Academic_Year_ComboBox.Text);

                        if (Copies_Text.Text != "")
                        {
                            //----------- Count---------------
                            copies = Convert.ToInt32(Copies_Text.Text);

                            if (this.OpenConnection())
                            {
                                string query_for_insert_NewItem = "insert into project_old values(" + pq_id + ",'" + P_or_Q + "','" + sem + "'," + academic_year + "," + copies + ",'" + description + "'," + subject_id + ")";
                                try
                                {

                                    MySqlCommand command = new MySqlCommand(query_for_insert_NewItem, connection);
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


                        } else MessageBox.Show("Put Number of Copy");

                    }
                    else MessageBox.Show("Select Academic Year");
                    
                }
                else MessageBox.Show("Select Subject Name,Please");

            }
            else MessageBox.Show("Select Paper,Please");

            Old_Question_RadioBtn.Checked = true;
            Update_Btn.Visible = false;
            Add_New_Btn.Visible = true;
            PQ_ID_Label.Text = GetLastID() + "";

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
            /*getSubject();
            getPaper_Name();*/

            Semester_ComboBox.DataSource = new[]{
                    "first",
                    "second"
                };
            Copies_Text.Text = "";
            Description_Text.Text = "";
        }

        //----------- Exit
        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        //---------- Return Old Question or Project
        private string getType()
        {
            string type = "";
            if (Old_Question_RadioBtn.Checked) type = "Old Question";
            else if (Project_RadioBtn.Checked) type = "Project";

            return type;
        }

        //---------- Return Old First or Second
        private string getSem()
        {
            string sem = "";
            sem = Semester_ComboBox.Text;
            return sem;
        }

        //+++++++++++++ Get Subject_ID from allsubject table ----------------
        private int getSubject_ID()
        {
            int Subject_ID = 0;
            string subject = Subject_Name_ComboBox.Text;
            string paper = Paper_No_ComboBox.Text;

            string query_for_lastID = "SELECT allsubject.Subject_ID FROM library.allsubject " +
                "left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID " +
                "where allsubject.Subject_Name='" + subject + "' and allsubject.Paper_No='" + paper + "'";

            if (this.OpenConnection() == true)
            {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query_for_lastID;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Subject_ID = Convert.ToInt32(reader[0]);
                    }
                }


                //PQ_ID_Label.Text = Last_ID + "";

                this.CloseConnection();
            }

            return Subject_ID;
        }

        //----------- Load Subject_Name and Paper with Class -------------------
        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSubject(Class_ComboBox.Text);
            getPaper_Name(Class_ComboBox.Text);
        }

        private int GetLastID()
        {
            int Last_ID = 0;
            string query_for_lastID = "SELECT max(PQ_ID) FROM project_old";
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = query_for_lastID;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Last_ID = Convert.ToInt32(reader[0]);
                    }
                }

                Last_ID += 1;
                //PQ_ID_Label.Text = Last_ID + "";

                this.CloseConnection();
            }
            return Last_ID;
        }

        private void Paper_No_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select distinct allsubject.Subject_Name from library.allsubject left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID where allsubject.Year='" + Class_ComboBox.Text + "' and allsubject.Paper_No='" + Paper_No_ComboBox.Text + "' order by allsubject.Subject_Name asc";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "allsubject");
            Subject_Name_ComboBox.DisplayMember = "Subject_Name";
            //author_name_comboBox.ValueMember = "Book_ID";
            Subject_Name_ComboBox.DataSource = ds.Tables["allsubject"];
            this.Subject_Name_ComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Database Function
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

    }
}

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
    public partial class project_OQ : UserControl
    {
        public project_OQ()
        {
            InitializeComponent();
        }

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        string year = "";
        string type = "";

        //Main Control Load
        private void Project_OQ_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(getConnectionString());
            Old_Question_RadioBtn.Checked = true;
            //getSubject("Fifth Year", "Project");

            year = "First Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = First_Year_Btn.Height;
            Side_panel.Top = First_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);
            Second_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fouth_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fith_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
        }

        private void getSubject(string Year, string Type)
        {
            //MessageBox.Show(Year+"  "+getType());
            // ------------ filling in -------author_name_comboBox--------------------------------------------
            if (this.OpenConnection())
            {
                string query = "select distinct allsubject.Subject_Name from library.allsubject left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID where allsubject.Year='" + Year + "' and project_old.Type='" + Type + "' order by allsubject.Subject_Name asc";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "allsubject");
                Subject_ComboBox.DisplayMember = "Subject_Name";
                //author_name_comboBox.ValueMember = "Book_ID";
                Subject_ComboBox.DataSource = ds.Tables["allsubject"];
                this.Subject_ComboBox.SelectedIndex = -1;

                this.CloseConnection();
            }
        }

        private void getAcademicYear(string Year, string Type)
        {
            //MessageBox.Show(Year+"  "+getType());
            // ------------ filling in -------author_name_comboBox--------------------------------------------
            if (this.OpenConnection())
            {
                string query = "select distinct project_old.Academic_Year from library.allsubject left join library.project_old on allsubject.Subject_ID = project_old.Subject_ID where allsubject.Year='" + Year + "' and project_old.Type='" + Type + "' order by project_old.Academic_Year asc";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "project_old");
                AcademicYear_ComboBox.DisplayMember = "Academic_Year";
                //author_name_comboBox.ValueMember = "Book_ID";
                AcademicYear_ComboBox.DataSource = ds.Tables["project_old"];
                this.AcademicYear_ComboBox.SelectedIndex = -1;

                this.CloseConnection();
            }
        }

        private void First_Year_Btn_Click(object sender, EventArgs e)
        {

            year = "First Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = First_Year_Btn.Height;
            Side_panel.Top = First_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);
            Second_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fouth_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fith_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);

            //Load To ComboBoxes-------------

        }

        private void Second_Year_Btn_Click(object sender, EventArgs e)
        {
            year = "Second Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = Second_Year_Btn.Height;
            Side_panel.Top = Second_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Second_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fouth_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fith_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
        }

        private void Third_Year_Btn_Click(object sender, EventArgs e)
        {
            year = "Third Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = Third_Year_Btn.Height;
            Side_panel.Top = Third_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Second_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);
            Fouth_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fith_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
        }

        private void Fouth_Year_Btn_Click(object sender, EventArgs e)
        {
            year = "Fourth Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = Fouth_Year_Btn.Height;
            Side_panel.Top = Fouth_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Second_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fouth_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);
            Fith_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);

            //
        }

        private void Fith_Year_Btn_Click(object sender, EventArgs e)
        {
            year = "Fifth Year";
            getSubject(year, getType());
            getAcademicYear(year, getType());

            //Side Pannel Moving
            Side_panel.Height = Fith_Year_Btn.Height;
            Side_panel.Top = Fith_Year_Btn.Top;
            //Back Color
            First_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Second_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);//35, 116, 171
            Third_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fouth_Year_Btn.BackColor = Color.FromArgb(35, 116, 171);
            Fith_Year_Btn.BackColor = Color.FromArgb(0, 151, 167);
        }

        //------------------  Search Query --------------------------
        private void Button5_Click(object sender, EventArgs e)
        {
            string query_for_filter = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Year='" + year + "' and project_old.Type='" + type + "' ";

            //select Subject
            if (Subject_ComboBox.Text != "")
            {
                query_for_filter += "and allsubject.Subject_Name='" + Subject_ComboBox.Text + "'";
            }

            //select Academic Year
            if (AcademicYear_ComboBox.Text != "")
            {
                query_for_filter += "and project_old.Academic_Year ='" + AcademicYear_ComboBox.Text + "'";
            }
            else //Select Subject and Academic Year
            if (AcademicYear_ComboBox.Text != "" && Subject_ComboBox.Text != "")
            {
                query_for_filter += "and project_old.Academic_Year ='" + AcademicYear_ComboBox.Text + "'";
            }
            string temp_query = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Year='" + year + "' and project_old.Type='" + type + "' ";
            if (query_for_filter == temp_query)
            {
                query_for_filter = "select project_old.PQ_ID,allsubject.Subject_Name,allsubject.Paper_No,project_old.Semester,project_old.Academic_Year,project_old.Copies,project_old.Type FROM library.project_old " +
                "left join library.allsubject on project_old.Subject_ID = allsubject.Subject_ID where allsubject.Year='" + year + "' and project_old.Type='" + type + "'";
            }

            AllFound_Project_OQ founded_POQ = new AllFound_Project_OQ("", query_for_filter);
            founded_POQ.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(founded_POQ);

            Form1.Instance.PnlContainer.Controls["AllFound_Project_OQ"].BringToFront();
        }

        //--------------- Search with User Text Keyword ----------------------------
        private void Search_project_old_word_btn_Click(object sender, EventArgs e)
        {
            AllFound_Project_OQ founded_POQ = new AllFound_Project_OQ(user_type_word.Text, "");
            founded_POQ.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(founded_POQ);

            Form1.Instance.PnlContainer.Controls["AllFound_Project_OQ"].BringToFront();
        }

        private void Old_Question_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            type = "Old Question";
            getSubject(year, type);
            getAcademicYear(year, getType());
        }

        private void Project_Radio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            type = "Project";
            getSubject(year, type);
            getAcademicYear(year, getType());
        }

        private string getType()
        {
            if (Old_Question_RadioBtn.Checked) type = "Old Question";
            else if (Project_Radio_Btn.Checked) type = "Project";

            return type;
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

        //---------- Add New -----------------
        private void Add_New_Btn_Click(object sender, EventArgs e)
        {
            NewPQ_Adding newPQ_Adding = new NewPQ_Adding("Add",0);
            newPQ_Adding.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(newPQ_Adding);

            Form1.Instance.PnlContainer.Controls["NewPQ_Adding"].BringToFront();
        }

        //------------ Upadte -----------
        private void Edit_Info_Btn_Click(object sender, EventArgs e)
        {
            Update_PQ newPQ_Update = new Update_PQ();
            newPQ_Update.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(newPQ_Update);

            Form1.Instance.PnlContainer.Controls["Update_PQ"].BringToFront();
        }

        private void Subject_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

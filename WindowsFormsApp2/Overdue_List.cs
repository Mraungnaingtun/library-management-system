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
    public partial class Overdue_List : UserControl
    {


        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        public Overdue_List()
        {
            InitializeComponent();
        }

        private void Overdue_List_Load(object sender, EventArgs e)
        {
            //Books_Btn.FlatAppearance.BorderSize = 2;
            Books_Btn.BackColor = Color.FromArgb(231, 77, 57);


            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);

            string query_for_book = "SELECT book.Book_ID,book.Book_Name,member_student.Student_Name,member_teacher_staff.TS_Name,borrowers.End_Date,borrowers.Start_Date,borrowers.Borrower_ID " +
                    "FROM library.borrowers left join library.book on borrowers.Book_ID = book.Book_ID  " +
                    "left join library.member_student on borrowers.MStu_ID = member_student.MStu_ID  " +
                    "left join library.member_teacher_staff on borrowers.MTS_ID = member_teacher_staff.MTS_ID " +
                    "where End_Date < NOW()  ORDER BY End_Date ASC;";

            Borrower_List_GridView.RowTemplate.Height = 45;
            Borrower_List_GridView.DataSource = GetView(query_for_book);
        }

        private void Books_Btn_Click(object sender, EventArgs e)
        {
            Books_Btn.BackColor = Color.FromArgb(231, 77, 57);
            Projects_Btn.BackColor = Color.FromArgb(35, 166, 171);
            Oldquestion_Btn.BackColor = Color.FromArgb(35, 166, 171);

            //
        }

        private void Projects_Btn_Click(object sender, EventArgs e)
        {
            Projects_Btn.BackColor = Color.FromArgb(231, 77, 57);
            Oldquestion_Btn.BackColor = Color.FromArgb(35, 166, 171);
            Books_Btn.BackColor = Color.FromArgb(35, 166, 171);

            //
        }

        private void Oldquestion_Btn_Click(object sender, EventArgs e)
        {
            Oldquestion_Btn.BackColor = Color.FromArgb(231, 77, 57);
            Projects_Btn.BackColor = Color.FromArgb(35, 166, 171);
            Books_Btn.BackColor = Color.FromArgb(35, 166, 171);

            //
        }


        public DataTable GetView(string query)
        {
            if (this.OpenConnection() == true)
            {
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


        // -------------- return A Connection string --------------------
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

        //------------------ open connection to database ------------------
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

        //------------------ Close connection ----------------------------
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

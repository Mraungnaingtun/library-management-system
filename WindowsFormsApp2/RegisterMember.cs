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
    public partial class RegisterMember : UserControl
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        string Stu_ID = "MS-0000";
        string Teacher_Staff_ID = "MTS-0000";
        string last_value_stu = "";
        string last_value_teacher_staff = "";
        // for student 
        string MStu_id, Student_Name, Stu_Uni_EntrenceNo, Stu_Roll_No, Stu_Phone_No, Stu_Address;
        string MTS_ID, MTS_Name, MTS_Depeartment, MTS_Rank, MTS_Phone, MTS_Address;

        private void Student_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Dis_to_Teacher_Staff(false);
            Dis_Student(true);
        }

        private void Teacher_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Dis_to_Teacher_Staff(true);
            Dis_Student(false);
        }

        public RegisterMember()
        {
            InitializeComponent();
        }

        // ------------------------- User Control Load ---
        private void RegisterMember_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            // seperating panel for two borrower
            Student_RadioBtn.Checked = true;
            Dis_to_Teacher_Staff(false);
            Dis_Student(true);

            string last_ID_query = "SELECT max(MStu_ID) FROM member_student";
            string last_techer_staff_ID = "SELECT max(MTS_ID) FROM member_teacher_staff";
            if (this.OpenConnection() == true)
            {
                // ----------------- get stu last id --------------------------------------
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = connection;
                cmd1.CommandText = last_ID_query;

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        { last_value_stu = (string)reader[0]; }
                        else
                        {
                            last_value_stu = Stu_ID;
                        }

                    }
                }

                // MessageBox.Show(last_value);


                // ----------------- get teacher and staff -------------------------------
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandText = last_techer_staff_ID;

                using (MySqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        { last_value_teacher_staff = (string)reader[0]; }
                        else
                        {
                            last_value_teacher_staff = Teacher_Staff_ID;
                        }

                    }
                }

                this.CloseConnection();
            }

            //MessageBox.Show(last_value_teacher_staff);
            Stu_ID_Box.Text = "MS-" + getLastID(last_value_stu, "MS");
            MTS_ID_Box.Text = "MTS-" + getLastID(last_value_teacher_staff, "MTS");
        }

        private void MTS_Rank_Box_TextChanged(object sender, EventArgs e)
        {

        }



        // -------------------- Add New Student Btn CLICK   ---------------------- 
        private void Button1_Click(object sender, EventArgs e)
        {

            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            string last_ID_query = "SELECT max(MStu_ID) FROM member_student";

            if (Stu_ID_Box.Text != "" && Stu_Name_Box.Text != "" && Stu_EntrenceNO_Box.Text != "" && Stu_Roll_No_Box.Text != "" && Stu_Phone_Box.Text != "")
            {
                MStu_id = Stu_ID_Box.Text;
                Student_Name = Stu_Name_Box.Text;
                Stu_Uni_EntrenceNo = Stu_EntrenceNO_Box.Text;
                Stu_Roll_No = Stu_Roll_No_Box.Text;
                Stu_Phone_No = Stu_Phone_Box.Text;
                Stu_Address = Stu_Address_Box.Text;

                if (this.OpenConnection() == true)
                {

                    string query = "insert into member_student(MStu_ID, Student_Name, EnterenceNo, RollNo, PhoneNo, Address) values('" + MStu_id + "', '" + Student_Name + "', '" + Stu_Uni_EntrenceNo + "', '" + Stu_Roll_No + "', '" + Stu_Phone_No + "', '" + Stu_Address + "'); ";

                    try
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Query Executed");
                            
                            Stu_Name_Box.Text = "";
                            Stu_EntrenceNO_Box.Text = "";
                            Stu_Roll_No_Box.Text = "";
                            Stu_Phone_Box.Text = "";
                            Stu_Address_Box.Text = "";
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

                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1.Connection = connection;
                    cmd1.CommandText = last_ID_query;

                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { last_value_stu = (string)reader[0]; }
                            else
                            {
                                last_value_stu = Stu_ID;
                            }

                        }
                    }
                    Stu_ID_Box.Text = "MS-" + getLastID(last_value_stu, "MS");
                    this.CloseConnection();
                }
            }
            else MessageBox.Show("ဆုတောင်းလေ :3");
        }



        //----------- Add New Teacher or Staff Btn CLICK
        private void Adding_Teacher_Member_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            connection = new MySqlConnection(connectionString);
            string last_techer_staff_ID = "SELECT max(MTS_ID) FROM member_teacher_staff";

            if (MTS_ID_Box.Text != "" && MTS_Name_Box.Text != "" && MTS_Depeartment_Box.Text != "" && MTS_Rank_Box.Text != "" && MTS_Phone_Box.Text != "")
            {
                MTS_ID = MTS_ID_Box.Text;
                MTS_Name = MTS_Name_Box.Text;
                MTS_Depeartment = MTS_Depeartment_Box.Text;
                MTS_Rank = MTS_Rank_Box.Text;
                MTS_Phone = MTS_Phone_Box.Text;
                MTS_Address = MTS_Address_Box.Text;

                if (this.OpenConnection() == true)
                {

                    string query = "insert into member_teacher_staff(MTS_ID, TS_Name, Depeartment_Name, Rank_Name, PhoneNo, Address) values('" + MTS_ID + "', '" + MTS_Name + "', '" + MTS_Depeartment + "', '" + MTS_Rank + "', '" + MTS_Phone + "', '" + MTS_Address + "'); ";

                    try
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Query Executed");
                            
                            MTS_Name_Box.Text = "";
                            MTS_Depeartment_Box.Text = "";
                            MTS_Rank_Box.Text = "";
                            MTS_Phone_Box.Text = "";
                            MTS_Address_Box.Text = "";
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

                    // ----------------- get teacher and staff -------------------------------
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = connection;
                    cmd2.CommandText = last_techer_staff_ID;

                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { last_value_teacher_staff = (string)reader[0]; }
                            else
                            {
                                last_value_teacher_staff = Teacher_Staff_ID;
                            }

                        }
                    }

                    MTS_ID_Box.Text = "MTS-" + getLastID(last_value_teacher_staff, "MTS");
                    this.CloseConnection();
                }
            }
            else MessageBox.Show("ဆုတောင်းလေ :3");

        }


        //All Student in database  --------------------
        private void Button1_Click_1(object sender, EventArgs e)
        {
            All_Memeber_List all_Memeber_List = new All_Memeber_List("student");
            all_Memeber_List.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(all_Memeber_List);

            Form1.Instance.PnlContainer.Controls["All_Memeber_List"].BringToFront();
        }


        // All Teacher and Staff in database  --------------------
        private void All_Teacher_Staff_Btn_Click(object sender, EventArgs e)
        {
            All_Memeber_List all_Memeber_List = new All_Memeber_List("teacher");
            all_Memeber_List.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Add(all_Memeber_List);

            Form1.Instance.PnlContainer.Controls["All_Memeber_List"].BringToFront();
        }

        //----------------  Swith Appear or Disapper Teacher_Staff 
        private void Dis_to_Teacher_Staff(Boolean value)
        {
            TeacherStaff_Label.Visible = value;
            MTS_Label.Visible = value;
            MTS_ID_Box.Visible = value;
            Teacher_Name_Label.Visible = value;
            MTS_Name_Box.Visible = value;
            Depeartment_Label.Visible = value;
            MTS_Depeartment_Box.Visible = value;
            Rankl_Label.Visible = value;
            MTS_Rank_Box.Visible = value;
            Teacher_phone_Label.Visible = value;
            MTS_Phone_Box.Visible = value;
            Teacher_Address_Label.Visible = value;
            MTS_Address_Box.Visible = value;
            //
            Adding_Teacher_Member_Btn.Visible = value;
        }

        //----------------  Swith Appear or Disapper Student
        private void Dis_Student(Boolean value)
        {
            Student_Label.Visible = value;
            MStu_ID_Label.Visible = value;
            Stu_ID_Box.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label4.Visible = value;
            label5.Visible = value;
            label6.Visible = value;
            Stu_Name_Box.Visible = value;
            Stu_EntrenceNO_Box.Visible = value;
            Stu_Roll_No_Box.Visible = value;
            Stu_Phone_Box.Visible = value;
            Stu_Address_Box.Visible = value;
            AddNewStudent.Visible = value;
        }


        private string getLastID(string given,string type) {

            string back = ""; int ID;
            if (type == "MS")
            {
                ID = Int32.Parse(given.Substring(3));
            }
            else {
                ID = Int32.Parse(given.Substring(4));
            }
            

            string temp = "";
            for (int i = 1; i <= 4 - ID.ToString().Length; i++)
            {
                temp += "0";
            }
            ID = ID + 1;

            temp += ID.ToString();
            back = temp;

            return back;
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

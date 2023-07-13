using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        All_Book_Founded_List all_Book_Founded_list;
        AddNewBook addNewBook;
        UpdateBook_Control allbook;
        Deleting_Book_Control deleting_Book_Control;

        //Declaring All Member User Contorl
        All_Memeber_List all_Memeber_List;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public delegate void PassData_CallTo(string textBoxData); //note where this is placed.

        //------------------ Main Contructor --------------------------
        public Form1()
        {
            InitializeComponent();

            //remove searching all book by name User Control
            all_Book_Founded_list = new All_Book_Founded_List();
            this.all_Book_Founded_list.Click += new EventHandler(OnCancelAllBookFoundList);

            //remove adding book / update book and delete book User Control
            addNewBook = new AddNewBook();
            this.addNewBook.Click += new EventHandler(onCancelAddNewBooK);

            //remove all book user control
            allbook = new UpdateBook_Control();
            this.allbook.Click += new EventHandler(onCancelALLBook);

            //remoce all Member List User Control
            all_Memeber_List = new All_Memeber_List();
            this.all_Memeber_List.Click += new EventHandler(onCancel_All_Member_List);

            //remove Deleting_Book_Control
            deleting_Book_Control = new Deleting_Book_Control();
            this.deleting_Book_Control.Click += new EventHandler(OnCancelDeleteBookContorl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * full screen
             */
            /*this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;*/

            _obj = this;
            side_pannel.Height = Dashboard_btn.Height;
            side_pannel.Top = Dashboard_btn.Top;

            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 1;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            Home dashboard = new Home();
            dashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(dashboard);
        }


        // Load DashBoard user Control
        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            side_pannel.Height = Dashboard_btn.Height;
            side_pannel.Top = Dashboard_btn.Top;

            // BorderSize
            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 1;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            Home dashboard = new Home();
            dashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(dashboard);

            panelContainer.Controls["Home"].BringToFront();

        }


        // Load Book User Control
        private void Book_btn_Click(object sender, EventArgs e)
        {
            side_pannel.Height = Book_btn.Height;
            side_pannel.Top = Book_btn.Top;

            // BorderSize
            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 1;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            panelContainer.Controls.Clear();
            books_user_control book_controls = new books_user_control();
            book_controls.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(book_controls);
            panelContainer.Controls["books_user_control"].BringToFront();
        }


        // Load Project OQ User Control
        private void ProjectOQ_btn_Click(object sender, EventArgs e)
        {
            side_pannel.Height = ProjectOQ_btn.Height;
            side_pannel.Top = ProjectOQ_btn.Top;

            // BorderSize
            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 1;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            panelContainer.Controls.Clear();
            project_OQ projectOQ_controls = new project_OQ();
            projectOQ_controls.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(projectOQ_controls);
            panelContainer.Controls["project_OQ"].BringToFront();
        }


        // Load Register Member User Control
        private void Button1_Click(object sender, EventArgs e)
        {
            side_pannel.Height = RegisterMember_btn.Height;
            side_pannel.Top = RegisterMember_btn.Top;

            // BorderSize
            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 1;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            RegisterMember registerMember = new RegisterMember();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(registerMember);

            panelContainer.Controls["RegisterMember"].BringToFront();
        }

        // ---------------------------- Load All Borrowed List btn Click ------------------------
        private void All_Borrowed_List_Btn_Click(object sender, EventArgs e)
        {
            side_pannel.Height = All_Borrowed_List_Btn.Height;
            side_pannel.Top = All_Borrowed_List_Btn.Top;

            // BorderSize
            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 1;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;

            All_Borrowed_List all_Borrowed_List = new All_Borrowed_List();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(all_Borrowed_List);

            panelContainer.Controls["All_Borrowed_List"].BringToFront();
        }


        private void New_Cateogry_Shelf_Click(object sender, EventArgs e)
        {
            side_pannel.Height = new_Cateogry_Shelf.Height;
            side_pannel.Top = new_Cateogry_Shelf.Top;

            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 1;

            New_Categroy_Shelf new_Categroy_Shelf = new New_Categroy_Shelf();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new_Categroy_Shelf);

            panelContainer.Controls["New_Categroy_Shelf"].BringToFront();

        }

        // ----------------- Overdue List ----------------------------
        private void Button1_Click_1(object sender, EventArgs e)
        {
            side_pannel.Height = button1.Height;
            side_pannel.Top = button1.Top;

            All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Book_btn.FlatAppearance.BorderSize = 0;
            ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            RegisterMember_btn.FlatAppearance.BorderSize = 0;
            new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;

            Overdue_List overdue_List = new Overdue_List();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(overdue_List);

            panelContainer.Controls["Overdue_List"].BringToFront();
        }

        /*
         * *    *   *   *   *
         * Exit Respective Control
         * *    *   *   *   *
         */


        //Exit All Book Found List User Control
        public void OnCancelAllBookFoundList(object sender, EventArgs e)
        {
            //MessageBox.Show("oops!");
            panelContainer.Controls.Clear();
            books_user_control books_User_Control = new books_user_control();
            panelContainer.Controls.Add(books_User_Control);

            panelContainer.Controls["books_user_control"].BringToFront();
        }


        // Exit Add New Book User Control
        public void onCancelAddNewBooK(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            books_user_control books_User_Control = new books_user_control();
            panelContainer.Controls.Add(books_User_Control);

            panelContainer.Controls["books_user_control"].BringToFront();
        }


        //Exit All Book User Control -------------
        public void onCancelALLBook(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            books_user_control books_User_Control = new books_user_control();
            panelContainer.Controls.Add(books_User_Control);

            panelContainer.Controls["books_user_control"].BringToFront();

        }

        public void OnCancelDeleteBookContorl(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            books_user_control books_User_Control = new books_user_control();
            panelContainer.Controls.Add(books_User_Control);

            panelContainer.Controls["books_user_control"].BringToFront();
        }
         


        // Exit Borrowing User Control
        public void onCancelBorrowing(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            All_Book_Founded_List all_Book_Founded_List = new All_Book_Founded_List();
            panelContainer.Controls.Add(all_Book_Founded_List);

            panelContainer.Controls["All_Book_Founded_List"].BringToFront();
        }


        // Exit All Member List User Contorl
        public void onCancel_All_Member_List(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            RegisterMember registerMember = new RegisterMember();
            panelContainer.Controls.Add(registerMember);

            panelContainer.Controls["RegisterMember"].BringToFront();
        }

        private void About_Btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            About_Control about_Control = new About_Control();
            panelContainer.Controls.Add(about_Control);

            panelContainer.Controls["About_Control"].BringToFront();
        }

        
    }
}

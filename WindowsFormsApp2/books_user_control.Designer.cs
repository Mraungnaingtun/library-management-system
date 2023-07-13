namespace WindowsFormsApp2
{
    partial class books_user_control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books_user_control));
            this.user_type_word = new System.Windows.Forms.TextBox();
            this.author_name_comboBox = new System.Windows.Forms.ComboBox();
            this.Sub_category_ComboBox = new System.Windows.Forms.ComboBox();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUpdateBokk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear_ComboBox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.search_book_word_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.English_Radio = new System.Windows.Forms.RadioButton();
            this.Myanmar_Radio = new System.Windows.Forms.RadioButton();
            this.AddBook_from_BookSearch_Control = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_type_word
            // 
            this.user_type_word.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_type_word.Location = new System.Drawing.Point(172, 43);
            this.user_type_word.Margin = new System.Windows.Forms.Padding(5);
            this.user_type_word.Name = "user_type_word";
            this.user_type_word.Size = new System.Drawing.Size(579, 34);
            this.user_type_word.TabIndex = 1;
            this.user_type_word.Enter += new System.EventHandler(this.IFEnter_Search_Text);
            this.user_type_word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            this.user_type_word.Leave += new System.EventHandler(this.User_type_word_Leave);
            // 
            // author_name_comboBox
            // 
            this.author_name_comboBox.Font = new System.Drawing.Font("Myanmar3", 12F);
            this.author_name_comboBox.FormattingEnabled = true;
            this.author_name_comboBox.Location = new System.Drawing.Point(68, 113);
            this.author_name_comboBox.Name = "author_name_comboBox";
            this.author_name_comboBox.Size = new System.Drawing.Size(435, 31);
            this.author_name_comboBox.TabIndex = 3;
            this.author_name_comboBox.SelectedIndexChanged += new System.EventHandler(this.Author_name_comboBox_SelectedIndexChanged);
            // 
            // Sub_category_ComboBox
            // 
            this.Sub_category_ComboBox.Font = new System.Drawing.Font("Myanmar3", 12F);
            this.Sub_category_ComboBox.FormattingEnabled = true;
            this.Sub_category_ComboBox.Location = new System.Drawing.Point(67, 294);
            this.Sub_category_ComboBox.Name = "Sub_category_ComboBox";
            this.Sub_category_ComboBox.Size = new System.Drawing.Size(435, 31);
            this.Sub_category_ComboBox.TabIndex = 4;
            // 
            // category_comboBox
            // 
            this.category_comboBox.Font = new System.Drawing.Font("Myanmar3", 12F);
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(68, 203);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(435, 31);
            this.category_comboBox.TabIndex = 5;
            this.category_comboBox.SelectedIndexChanged += new System.EventHandler(this.Category_comboBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // AddUpdateBokk
            // 
            this.AddUpdateBokk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.AddUpdateBokk.FlatAppearance.BorderSize = 0;
            this.AddUpdateBokk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUpdateBokk.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateBokk.ForeColor = System.Drawing.Color.White;
            this.AddUpdateBokk.Image = ((System.Drawing.Image)(resources.GetObject("AddUpdateBokk.Image")));
            this.AddUpdateBokk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUpdateBokk.Location = new System.Drawing.Point(792, 297);
            this.AddUpdateBokk.Name = "AddUpdateBokk";
            this.AddUpdateBokk.Size = new System.Drawing.Size(144, 48);
            this.AddUpdateBokk.TabIndex = 9;
            this.AddUpdateBokk.Text = "  Edit Book";
            this.AddUpdateBokk.UseVisualStyleBackColor = false;
            this.AddUpdateBokk.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(312, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // Clear_ComboBox
            // 
            this.Clear_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Clear_ComboBox.FlatAppearance.BorderSize = 0;
            this.Clear_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_ComboBox.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Clear_ComboBox.Location = new System.Drawing.Point(136, 392);
            this.Clear_ComboBox.Name = "Clear_ComboBox";
            this.Clear_ComboBox.Size = new System.Drawing.Size(140, 46);
            this.Clear_ComboBox.TabIndex = 12;
            this.Clear_ComboBox.Text = "Clear All";
            this.Clear_ComboBox.UseVisualStyleBackColor = false;
            this.Clear_ComboBox.Click += new System.EventHandler(this.Clear_ComboBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.user_type_word);
            this.panel1.Controls.Add(this.search_book_word_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 93);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search with Book ID,Book Name,Author,Category and Sub-Category";
            // 
            // search_book_word_btn
            // 
            this.search_book_word_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_book_word_btn.FlatAppearance.BorderSize = 0;
            this.search_book_word_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_book_word_btn.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_book_word_btn.Image = global::WindowsFormsApp2.Properties.Resources.icons8_search_50;
            this.search_book_word_btn.Location = new System.Drawing.Point(761, 36);
            this.search_book_word_btn.Margin = new System.Windows.Forms.Padding(5);
            this.search_book_word_btn.Name = "search_book_word_btn";
            this.search_book_word_btn.Size = new System.Drawing.Size(50, 47);
            this.search_book_word_btn.TabIndex = 2;
            this.search_book_word_btn.UseVisualStyleBackColor = false;
            this.search_book_word_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.English_Radio);
            this.panel2.Controls.Add(this.Myanmar_Radio);
            this.panel2.Controls.Add(this.author_name_comboBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Clear_ComboBox);
            this.panel2.Controls.Add(this.Sub_category_ComboBox);
            this.panel2.Controls.Add(this.category_comboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(167, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 475);
            this.panel2.TabIndex = 14;
            // 
            // English_Radio
            // 
            this.English_Radio.AutoSize = true;
            this.English_Radio.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English_Radio.Location = new System.Drawing.Point(312, 27);
            this.English_Radio.Name = "English_Radio";
            this.English_Radio.Size = new System.Drawing.Size(86, 29);
            this.English_Radio.TabIndex = 15;
            this.English_Radio.TabStop = true;
            this.English_Radio.Text = "English";
            this.English_Radio.UseVisualStyleBackColor = true;
            this.English_Radio.CheckedChanged += new System.EventHandler(this.English_Radio_CheckedChanged);
            // 
            // Myanmar_Radio
            // 
            this.Myanmar_Radio.AutoSize = true;
            this.Myanmar_Radio.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Myanmar_Radio.Location = new System.Drawing.Point(177, 27);
            this.Myanmar_Radio.Name = "Myanmar_Radio";
            this.Myanmar_Radio.Size = new System.Drawing.Size(102, 29);
            this.Myanmar_Radio.TabIndex = 14;
            this.Myanmar_Radio.TabStop = true;
            this.Myanmar_Radio.Text = "Myanmar";
            this.Myanmar_Radio.UseVisualStyleBackColor = true;
            this.Myanmar_Radio.CheckedChanged += new System.EventHandler(this.Myanmar_Radio_CheckedChanged);
            // 
            // AddBook_from_BookSearch_Control
            // 
            this.AddBook_from_BookSearch_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.AddBook_from_BookSearch_Control.FlatAppearance.BorderSize = 0;
            this.AddBook_from_BookSearch_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook_from_BookSearch_Control.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_from_BookSearch_Control.ForeColor = System.Drawing.Color.White;
            this.AddBook_from_BookSearch_Control.Image = ((System.Drawing.Image)(resources.GetObject("AddBook_from_BookSearch_Control.Image")));
            this.AddBook_from_BookSearch_Control.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBook_from_BookSearch_Control.Location = new System.Drawing.Point(792, 239);
            this.AddBook_from_BookSearch_Control.Name = "AddBook_from_BookSearch_Control";
            this.AddBook_from_BookSearch_Control.Size = new System.Drawing.Size(144, 47);
            this.AddBook_from_BookSearch_Control.TabIndex = 15;
            this.AddBook_from_BookSearch_Control.Text = " Add Book";
            this.AddBook_from_BookSearch_Control.UseVisualStyleBackColor = false;
            this.AddBook_from_BookSearch_Control.Click += new System.EventHandler(this.AddBook_from_BookSearch_Control_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(792, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 48);
            this.button6.TabIndex = 16;
            this.button6.Text = "   Delete Book";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // books_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.AddBook_from_BookSearch_Control);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddUpdateBokk);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "books_user_control";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox user_type_word;
        private System.Windows.Forms.Button search_book_word_btn;
        private System.Windows.Forms.ComboBox author_name_comboBox;
        private System.Windows.Forms.ComboBox Sub_category_ComboBox;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUpdateBokk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear_ComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddBook_from_BookSearch_Control;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton English_Radio;
        private System.Windows.Forms.RadioButton Myanmar_Radio;
        private System.Windows.Forms.Label label4;
    }
}

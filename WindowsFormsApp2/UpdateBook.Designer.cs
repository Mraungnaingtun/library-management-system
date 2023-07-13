namespace WindowsFormsApp2
{
    partial class UpdateBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_to_Book_Main_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Row_Combo = new System.Windows.Forms.ComboBox();
            this.clear_all_textBox = new System.Windows.Forms.Button();
            this.Update_Book_info_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Shelf_Row_Combox = new System.Windows.Forms.ComboBox();
            this.Category_Combo = new System.Windows.Forms.ComboBox();
            this.Sub_Category_Combo = new System.Windows.Forms.ComboBox();
            this.Shelf_Combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Edition_Text = new System.Windows.Forms.TextBox();
            this.Price_Text = new System.Windows.Forms.TextBox();
            this.Number_OF_BOOK_Text = new System.Windows.Forms.TextBox();
            this.Publish_Date_Text = new System.Windows.Forms.TextBox();
            this.Publisher_Text = new System.Windows.Forms.TextBox();
            this.Author_Text = new System.Windows.Forms.TextBox();
            this.BookName_Text = new System.Windows.Forms.TextBox();
            this.Book_ID_Label = new System.Windows.Forms.Label();
            this.Description_Text = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.Book_ID_Label);
            this.panel1.Controls.Add(this.Back_to_Book_Main_btn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 72);
            this.panel1.TabIndex = 8;
            // 
            // Back_to_Book_Main_btn
            // 
            this.Back_to_Book_Main_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_to_Book_Main_btn.FlatAppearance.BorderSize = 0;
            this.Back_to_Book_Main_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_to_Book_Main_btn.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.Back_to_Book_Main_btn.Location = new System.Drawing.Point(31, 10);
            this.Back_to_Book_Main_btn.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Back_to_Book_Main_btn.Name = "Back_to_Book_Main_btn";
            this.Back_to_Book_Main_btn.Size = new System.Drawing.Size(62, 55);
            this.Back_to_Book_Main_btn.TabIndex = 3;
            this.Back_to_Book_Main_btn.UseVisualStyleBackColor = false;
            this.Back_to_Book_Main_btn.Click += new System.EventHandler(this.Back_to_Book_Main_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1179, 540);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "Row";
            // 
            // Row_Combo
            // 
            this.Row_Combo.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row_Combo.FormattingEnabled = true;
            this.Row_Combo.Location = new System.Drawing.Point(1184, 572);
            this.Row_Combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Row_Combo.Name = "Row_Combo";
            this.Row_Combo.Size = new System.Drawing.Size(180, 27);
            this.Row_Combo.TabIndex = 44;
            // 
            // clear_all_textBox
            // 
            this.clear_all_textBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_all_textBox.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_textBox.Location = new System.Drawing.Point(250, 462);
            this.clear_all_textBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.clear_all_textBox.Name = "clear_all_textBox";
            this.clear_all_textBox.Size = new System.Drawing.Size(88, 42);
            this.clear_all_textBox.TabIndex = 38;
            this.clear_all_textBox.Text = "Clear_All";
            this.clear_all_textBox.UseVisualStyleBackColor = true;
            this.clear_all_textBox.Click += new System.EventHandler(this.Clear_all_textBox_Click);
            // 
            // Update_Book_info_Btn
            // 
            this.Update_Book_info_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.Update_Book_info_Btn.FlatAppearance.BorderSize = 0;
            this.Update_Book_info_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Book_info_Btn.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Book_info_Btn.ForeColor = System.Drawing.Color.White;
            this.Update_Book_info_Btn.Location = new System.Drawing.Point(227, 518);
            this.Update_Book_info_Btn.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Update_Book_info_Btn.Name = "Update_Book_info_Btn";
            this.Update_Book_info_Btn.Size = new System.Drawing.Size(133, 46);
            this.Update_Book_info_Btn.TabIndex = 47;
            this.Update_Book_info_Btn.Text = "Update";
            this.Update_Book_info_Btn.UseVisualStyleBackColor = false;
            this.Update_Book_info_Btn.Click += new System.EventHandler(this.Update_Book_info_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Row";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(636, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 19);
            this.label13.TabIndex = 73;
            this.label13.Text = "Shelf";
            // 
            // Shelf_Row_Combox
            // 
            this.Shelf_Row_Combox.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shelf_Row_Combox.FormattingEnabled = true;
            this.Shelf_Row_Combox.Location = new System.Drawing.Point(795, 353);
            this.Shelf_Row_Combox.Name = "Shelf_Row_Combox";
            this.Shelf_Row_Combox.Size = new System.Drawing.Size(121, 31);
            this.Shelf_Row_Combox.TabIndex = 72;
            // 
            // Category_Combo
            // 
            this.Category_Combo.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Combo.FormattingEnabled = true;
            this.Category_Combo.Location = new System.Drawing.Point(160, 242);
            this.Category_Combo.Name = "Category_Combo";
            this.Category_Combo.Size = new System.Drawing.Size(276, 31);
            this.Category_Combo.TabIndex = 71;
            this.Category_Combo.SelectedIndexChanged += new System.EventHandler(this.Category_Combo_SelectedIndexChanged);
            // 
            // Sub_Category_Combo
            // 
            this.Sub_Category_Combo.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_Category_Combo.FormattingEnabled = true;
            this.Sub_Category_Combo.Location = new System.Drawing.Point(160, 296);
            this.Sub_Category_Combo.Name = "Sub_Category_Combo";
            this.Sub_Category_Combo.Size = new System.Drawing.Size(276, 31);
            this.Sub_Category_Combo.TabIndex = 70;
            // 
            // Shelf_Combo
            // 
            this.Shelf_Combo.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shelf_Combo.FormattingEnabled = true;
            this.Shelf_Combo.Location = new System.Drawing.Point(640, 353);
            this.Shelf_Combo.Name = "Shelf_Combo";
            this.Shelf_Combo.Size = new System.Drawing.Size(126, 31);
            this.Shelf_Combo.TabIndex = 69;
            this.Shelf_Combo.SelectedIndexChanged += new System.EventHandler(this.Shelf_Combo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(568, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Edition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(576, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 64;
            this.label12.Text = "Place";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 63;
            this.label10.Text = " Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sub_Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Publish Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Publisher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 30);
            this.label11.TabIndex = 57;
            this.label11.Text = "Book_ID :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 56;
            this.label15.Text = "Book Name";
            // 
            // Edition_Text
            // 
            this.Edition_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition_Text.Location = new System.Drawing.Point(640, 236);
            this.Edition_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edition_Text.Name = "Edition_Text";
            this.Edition_Text.Size = new System.Drawing.Size(276, 32);
            this.Edition_Text.TabIndex = 54;
            // 
            // Price_Text
            // 
            this.Price_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Text.Location = new System.Drawing.Point(160, 353);
            this.Price_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Price_Text.Name = "Price_Text";
            this.Price_Text.Size = new System.Drawing.Size(276, 32);
            this.Price_Text.TabIndex = 53;
            // 
            // Number_OF_BOOK_Text
            // 
            this.Number_OF_BOOK_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_OF_BOOK_Text.Location = new System.Drawing.Point(640, 290);
            this.Number_OF_BOOK_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Number_OF_BOOK_Text.Name = "Number_OF_BOOK_Text";
            this.Number_OF_BOOK_Text.Size = new System.Drawing.Size(276, 32);
            this.Number_OF_BOOK_Text.TabIndex = 52;
            // 
            // Publish_Date_Text
            // 
            this.Publish_Date_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publish_Date_Text.Location = new System.Drawing.Point(640, 183);
            this.Publish_Date_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Publish_Date_Text.Name = "Publish_Date_Text";
            this.Publish_Date_Text.Size = new System.Drawing.Size(276, 32);
            this.Publish_Date_Text.TabIndex = 51;
            // 
            // Publisher_Text
            // 
            this.Publisher_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_Text.Location = new System.Drawing.Point(640, 124);
            this.Publisher_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Publisher_Text.Name = "Publisher_Text";
            this.Publisher_Text.Size = new System.Drawing.Size(276, 32);
            this.Publisher_Text.TabIndex = 50;
            // 
            // Author_Text
            // 
            this.Author_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Text.Location = new System.Drawing.Point(160, 186);
            this.Author_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Author_Text.Name = "Author_Text";
            this.Author_Text.Size = new System.Drawing.Size(276, 32);
            this.Author_Text.TabIndex = 49;
            // 
            // BookName_Text
            // 
            this.BookName_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName_Text.Location = new System.Drawing.Point(160, 127);
            this.BookName_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookName_Text.Name = "BookName_Text";
            this.BookName_Text.Size = new System.Drawing.Size(276, 32);
            this.BookName_Text.TabIndex = 48;
            // 
            // Book_ID_Label
            // 
            this.Book_ID_Label.AutoSize = true;
            this.Book_ID_Label.Font = new System.Drawing.Font("Myanmar3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Book_ID_Label.Location = new System.Drawing.Point(487, 17);
            this.Book_ID_Label.Name = "Book_ID_Label";
            this.Book_ID_Label.Size = new System.Drawing.Size(113, 35);
            this.Book_ID_Label.TabIndex = 75;
            this.Book_ID_Label.Text = "M-00021";
            // 
            // Description_Text
            // 
            this.Description_Text.Location = new System.Drawing.Point(640, 411);
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.Size = new System.Drawing.Size(276, 119);
            this.Description_Text.TabIndex = 75;
            this.Description_Text.Text = "";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Shelf_Row_Combox);
            this.Controls.Add(this.Category_Combo);
            this.Controls.Add(this.Sub_Category_Combo);
            this.Controls.Add(this.Shelf_Combo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Edition_Text);
            this.Controls.Add(this.Price_Text);
            this.Controls.Add(this.Number_OF_BOOK_Text);
            this.Controls.Add(this.Publish_Date_Text);
            this.Controls.Add(this.Publisher_Text);
            this.Controls.Add(this.Author_Text);
            this.Controls.Add(this.BookName_Text);
            this.Controls.Add(this.Update_Book_info_Btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Row_Combo);
            this.Controls.Add(this.clear_all_textBox);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateBook";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_to_Book_Main_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Row_Combo;
        private System.Windows.Forms.Button clear_all_textBox;
        private System.Windows.Forms.Button Update_Book_info_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Shelf_Row_Combox;
        private System.Windows.Forms.ComboBox Category_Combo;
        private System.Windows.Forms.ComboBox Sub_Category_Combo;
        private System.Windows.Forms.ComboBox Shelf_Combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Edition_Text;
        private System.Windows.Forms.TextBox Price_Text;
        private System.Windows.Forms.TextBox Number_OF_BOOK_Text;
        private System.Windows.Forms.TextBox Publish_Date_Text;
        private System.Windows.Forms.TextBox Publisher_Text;
        private System.Windows.Forms.TextBox Author_Text;
        private System.Windows.Forms.TextBox BookName_Text;
        private System.Windows.Forms.Label Book_ID_Label;
        private System.Windows.Forms.RichTextBox Description_Text;
    }
}

namespace WindowsFormsApp2
{
    partial class All_Borrowed_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.Book_Borrower_GridView = new System.Windows.Forms.DataGridView();
            this.author_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.member_name_label = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.book_ID_label = new System.Windows.Forms.Label();
            this.book_name_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Borrower_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Borrowed List";
            // 
            // Book_Borrower_GridView
            // 
            this.Book_Borrower_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Book_Borrower_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Borrower_GridView.Location = new System.Drawing.Point(31, 65);
            this.Book_Borrower_GridView.Name = "Book_Borrower_GridView";
            this.Book_Borrower_GridView.Size = new System.Drawing.Size(522, 531);
            this.Book_Borrower_GridView.TabIndex = 14;
            this.Book_Borrower_GridView.DoubleClick += new System.EventHandler(this.DoubleClick_OnBorrower);
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_label.Location = new System.Drawing.Point(685, 342);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(18, 25);
            this.author_label.TabIndex = 12;
            this.author_label.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(673, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Receive Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // member_name_label
            // 
            this.member_name_label.AutoSize = true;
            this.member_name_label.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name_label.Location = new System.Drawing.Point(685, 379);
            this.member_name_label.Name = "member_name_label";
            this.member_name_label.Size = new System.Drawing.Size(18, 25);
            this.member_name_label.TabIndex = 6;
            this.member_name_label.Text = "-";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.end_date_label.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.Color.White;
            this.end_date_label.Location = new System.Drawing.Point(685, 456);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(18, 25);
            this.end_date_label.TabIndex = 7;
            this.end_date_label.Text = "-";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.start_date_label.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.ForeColor = System.Drawing.Color.White;
            this.start_date_label.Location = new System.Drawing.Point(685, 417);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(18, 25);
            this.start_date_label.TabIndex = 8;
            this.start_date_label.Text = "-";
            // 
            // book_ID_label
            // 
            this.book_ID_label.AutoSize = true;
            this.book_ID_label.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_ID_label.ForeColor = System.Drawing.Color.Red;
            this.book_ID_label.Location = new System.Drawing.Point(642, 258);
            this.book_ID_label.Name = "book_ID_label";
            this.book_ID_label.Size = new System.Drawing.Size(92, 27);
            this.book_ID_label.TabIndex = 9;
            this.book_ID_label.Text = "Book_ID";
            // 
            // book_name_label
            // 
            this.book_name_label.AutoSize = true;
            this.book_name_label.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.book_name_label.Location = new System.Drawing.Point(574, 312);
            this.book_name_label.Name = "book_name_label";
            this.book_name_label.Size = new System.Drawing.Size(88, 22);
            this.book_name_label.TabIndex = 10;
            this.book_name_label.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Date     -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Date     -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Borrower     -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Author         -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.BOOK_COVER___website_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(578, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 186);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // All_Borrowed_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book_Borrower_GridView);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.member_name_label);
            this.Controls.Add(this.end_date_label);
            this.Controls.Add(this.start_date_label);
            this.Controls.Add(this.book_ID_label);
            this.Controls.Add(this.book_name_label);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "All_Borrowed_List";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.All_Borrowed_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Borrower_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Book_Borrower_GridView;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label member_name_label;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label book_ID_label;
        private System.Windows.Forms.Label book_name_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

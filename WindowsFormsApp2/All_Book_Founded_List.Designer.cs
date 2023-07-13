namespace WindowsFormsApp2
{
    partial class All_Book_Founded_List
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
            this.Book_Founded_GirdView = new System.Windows.Forms.DataGridView();
            this.back_to_book_user_control = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.No_Book_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookFound_Count_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Founded_GirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Book_Founded_GirdView
            // 
            this.Book_Founded_GirdView.AllowUserToAddRows = false;
            this.Book_Founded_GirdView.AllowUserToDeleteRows = false;
            this.Book_Founded_GirdView.AllowUserToResizeColumns = false;
            this.Book_Founded_GirdView.AllowUserToResizeRows = false;
            this.Book_Founded_GirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Book_Founded_GirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Founded_GirdView.GridColor = System.Drawing.Color.Maroon;
            this.Book_Founded_GirdView.Location = new System.Drawing.Point(17, 84);
            this.Book_Founded_GirdView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Book_Founded_GirdView.Name = "Book_Founded_GirdView";
            this.Book_Founded_GirdView.Size = new System.Drawing.Size(921, 509);
            this.Book_Founded_GirdView.TabIndex = 0;
            this.Book_Founded_GirdView.DoubleClick += new System.EventHandler(this.Request_Book_Double_CLick);
            // 
            // back_to_book_user_control
            // 
            this.back_to_book_user_control.FlatAppearance.BorderSize = 0;
            this.back_to_book_user_control.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_to_book_user_control.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.back_to_book_user_control.Location = new System.Drawing.Point(37, 9);
            this.back_to_book_user_control.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_to_book_user_control.Name = "back_to_book_user_control";
            this.back_to_book_user_control.Size = new System.Drawing.Size(61, 55);
            this.back_to_book_user_control.TabIndex = 1;
            this.back_to_book_user_control.UseVisualStyleBackColor = true;
            this.back_to_book_user_control.Click += new System.EventHandler(this.Back_to_book_user_control_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.BookFound_Count_Label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back_to_book_user_control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 75);
            this.panel1.TabIndex = 3;
            // 
            // No_Book_label
            // 
            this.No_Book_label.AutoSize = true;
            this.No_Book_label.Font = new System.Drawing.Font("Myanmar3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Book_label.Location = new System.Drawing.Point(286, 301);
            this.No_Book_label.Name = "No_Book_label";
            this.No_Book_label.Size = new System.Drawing.Size(367, 42);
            this.No_Book_label.TabIndex = 4;
            this.No_Book_label.Text = "No Book Found,Thank you";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double Click On the Book";
            // 
            // BookFound_Count_Label
            // 
            this.BookFound_Count_Label.AutoSize = true;
            this.BookFound_Count_Label.Font = new System.Drawing.Font("Myanmar3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFound_Count_Label.Location = new System.Drawing.Point(157, 23);
            this.BookFound_Count_Label.Name = "BookFound_Count_Label";
            this.BookFound_Count_Label.Size = new System.Drawing.Size(148, 30);
            this.BookFound_Count_Label.TabIndex = 2;
            this.BookFound_Count_Label.Text = "0 Book Found";
            // 
            // All_Book_Founded_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.No_Book_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Book_Founded_GirdView);
            this.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "All_Book_Founded_List";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.All_Book_Founded_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Founded_GirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Book_Founded_GirdView;
        private System.Windows.Forms.Button back_to_book_user_control;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label No_Book_label;
        private System.Windows.Forms.Label BookFound_Count_Label;
        private System.Windows.Forms.Label label1;
    }
}

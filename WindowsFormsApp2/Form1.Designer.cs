namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.All_Borrowed_List_Btn = new System.Windows.Forms.Button();
            this.new_Cateogry_Shelf = new System.Windows.Forms.Button();
            this.RegisterMember_btn = new System.Windows.Forms.Button();
            this.ProjectOQ_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Book_btn = new System.Windows.Forms.Button();
            this.side_pannel = new System.Windows.Forms.Panel();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.About_Btn);
            this.panel1.Controls.Add(this.All_Borrowed_List_Btn);
            this.panel1.Controls.Add(this.new_Cateogry_Shelf);
            this.panel1.Controls.Add(this.RegisterMember_btn);
            this.panel1.Controls.Add(this.ProjectOQ_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Book_btn);
            this.panel1.Controls.Add(this.side_pannel);
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 611);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Overdue List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // About_Btn
            // 
            this.About_Btn.FlatAppearance.BorderSize = 0;
            this.About_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Btn.ForeColor = System.Drawing.Color.White;
            this.About_Btn.Location = new System.Drawing.Point(12, 552);
            this.About_Btn.Name = "About_Btn";
            this.About_Btn.Size = new System.Drawing.Size(216, 56);
            this.About_Btn.TabIndex = 0;
            this.About_Btn.Text = "About";
            this.About_Btn.UseVisualStyleBackColor = true;
            this.About_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            // 
            // All_Borrowed_List_Btn
            // 
            this.All_Borrowed_List_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.All_Borrowed_List_Btn.FlatAppearance.BorderSize = 0;
            this.All_Borrowed_List_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_Borrowed_List_Btn.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Borrowed_List_Btn.ForeColor = System.Drawing.Color.White;
            this.All_Borrowed_List_Btn.Location = new System.Drawing.Point(12, 319);
            this.All_Borrowed_List_Btn.Name = "All_Borrowed_List_Btn";
            this.All_Borrowed_List_Btn.Size = new System.Drawing.Size(216, 52);
            this.All_Borrowed_List_Btn.TabIndex = 0;
            this.All_Borrowed_List_Btn.Text = "All Borrowed List";
            this.All_Borrowed_List_Btn.UseVisualStyleBackColor = false;
            this.All_Borrowed_List_Btn.Click += new System.EventHandler(this.All_Borrowed_List_Btn_Click);
            // 
            // new_Cateogry_Shelf
            // 
            this.new_Cateogry_Shelf.FlatAppearance.BorderSize = 0;
            this.new_Cateogry_Shelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_Cateogry_Shelf.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Cateogry_Shelf.ForeColor = System.Drawing.Color.White;
            this.new_Cateogry_Shelf.Location = new System.Drawing.Point(12, 425);
            this.new_Cateogry_Shelf.Name = "new_Cateogry_Shelf";
            this.new_Cateogry_Shelf.Size = new System.Drawing.Size(216, 52);
            this.new_Cateogry_Shelf.TabIndex = 0;
            this.new_Cateogry_Shelf.Text = "New Cateogry/Shelf";
            this.new_Cateogry_Shelf.UseVisualStyleBackColor = true;
            this.new_Cateogry_Shelf.Click += new System.EventHandler(this.New_Cateogry_Shelf_Click);
            // 
            // RegisterMember_btn
            // 
            this.RegisterMember_btn.FlatAppearance.BorderSize = 0;
            this.RegisterMember_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterMember_btn.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterMember_btn.ForeColor = System.Drawing.Color.White;
            this.RegisterMember_btn.Location = new System.Drawing.Point(12, 266);
            this.RegisterMember_btn.Name = "RegisterMember_btn";
            this.RegisterMember_btn.Size = new System.Drawing.Size(216, 52);
            this.RegisterMember_btn.TabIndex = 4;
            this.RegisterMember_btn.Text = "Registration";
            this.RegisterMember_btn.UseVisualStyleBackColor = true;
            this.RegisterMember_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ProjectOQ_btn
            // 
            this.ProjectOQ_btn.FlatAppearance.BorderSize = 0;
            this.ProjectOQ_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectOQ_btn.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectOQ_btn.ForeColor = System.Drawing.Color.White;
            this.ProjectOQ_btn.Location = new System.Drawing.Point(12, 213);
            this.ProjectOQ_btn.Name = "ProjectOQ_btn";
            this.ProjectOQ_btn.Size = new System.Drawing.Size(216, 52);
            this.ProjectOQ_btn.TabIndex = 3;
            this.ProjectOQ_btn.Text = "Projects/OQ";
            this.ProjectOQ_btn.UseVisualStyleBackColor = true;
            this.ProjectOQ_btn.Click += new System.EventHandler(this.ProjectOQ_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIS(UCSS)";
            // 
            // Book_btn
            // 
            this.Book_btn.FlatAppearance.BorderSize = 0;
            this.Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_btn.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.ForeColor = System.Drawing.Color.White;
            this.Book_btn.Location = new System.Drawing.Point(12, 160);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(216, 52);
            this.Book_btn.TabIndex = 2;
            this.Book_btn.Text = "Books";
            this.Book_btn.UseVisualStyleBackColor = true;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // side_pannel
            // 
            this.side_pannel.BackColor = System.Drawing.Color.White;
            this.side_pannel.Location = new System.Drawing.Point(0, 107);
            this.side_pannel.Name = "side_pannel";
            this.side_pannel.Size = new System.Drawing.Size(12, 52);
            this.side_pannel.TabIndex = 1;
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 107);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(216, 52);
            this.Dashboard_btn.TabIndex = 1;
            this.Dashboard_btn.Text = "Home";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(229, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(955, 611);
            this.panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Library Information System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProjectOQ_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.Panel side_pannel;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button RegisterMember_btn;
        private System.Windows.Forms.Button All_Borrowed_List_Btn;
        private System.Windows.Forms.Button new_Cateogry_Shelf;
        private System.Windows.Forms.Button About_Btn;
        private System.Windows.Forms.Button button1;
    }
}


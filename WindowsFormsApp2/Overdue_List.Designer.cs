namespace WindowsFormsApp2
{
    partial class Overdue_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.Books_Btn = new System.Windows.Forms.Button();
            this.Projects_Btn = new System.Windows.Forms.Button();
            this.Oldquestion_Btn = new System.Windows.Forms.Button();
            this.Borrower_List_GridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Borrower_List_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 61);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Overdue Borrower List";
            // 
            // Books_Btn
            // 
            this.Books_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.Books_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Books_Btn.FlatAppearance.BorderSize = 0;
            this.Books_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books_Btn.ForeColor = System.Drawing.Color.White;
            this.Books_Btn.Location = new System.Drawing.Point(244, 67);
            this.Books_Btn.Name = "Books_Btn";
            this.Books_Btn.Size = new System.Drawing.Size(151, 41);
            this.Books_Btn.TabIndex = 12;
            this.Books_Btn.Text = "Books";
            this.Books_Btn.UseVisualStyleBackColor = false;
            this.Books_Btn.Click += new System.EventHandler(this.Books_Btn_Click);
            // 
            // Projects_Btn
            // 
            this.Projects_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.Projects_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Projects_Btn.FlatAppearance.BorderSize = 0;
            this.Projects_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Projects_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_Btn.ForeColor = System.Drawing.Color.White;
            this.Projects_Btn.Location = new System.Drawing.Point(395, 67);
            this.Projects_Btn.Name = "Projects_Btn";
            this.Projects_Btn.Size = new System.Drawing.Size(151, 41);
            this.Projects_Btn.TabIndex = 12;
            this.Projects_Btn.Text = "Projects";
            this.Projects_Btn.UseVisualStyleBackColor = false;
            this.Projects_Btn.Click += new System.EventHandler(this.Projects_Btn_Click);
            // 
            // Oldquestion_Btn
            // 
            this.Oldquestion_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.Oldquestion_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Oldquestion_Btn.FlatAppearance.BorderSize = 0;
            this.Oldquestion_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oldquestion_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oldquestion_Btn.ForeColor = System.Drawing.Color.White;
            this.Oldquestion_Btn.Location = new System.Drawing.Point(546, 67);
            this.Oldquestion_Btn.Name = "Oldquestion_Btn";
            this.Oldquestion_Btn.Size = new System.Drawing.Size(151, 41);
            this.Oldquestion_Btn.TabIndex = 12;
            this.Oldquestion_Btn.Text = "OQ";
            this.Oldquestion_Btn.UseVisualStyleBackColor = false;
            this.Oldquestion_Btn.Click += new System.EventHandler(this.Oldquestion_Btn_Click);
            // 
            // Borrower_List_GridView
            // 
            this.Borrower_List_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Borrower_List_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Borrower_List_GridView.Location = new System.Drawing.Point(114, 120);
            this.Borrower_List_GridView.Name = "Borrower_List_GridView";
            this.Borrower_List_GridView.Size = new System.Drawing.Size(706, 423);
            this.Borrower_List_GridView.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(666, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reprot";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Overdue_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Borrower_List_GridView);
            this.Controls.Add(this.Oldquestion_Btn);
            this.Controls.Add(this.Projects_Btn);
            this.Controls.Add(this.Books_Btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Overdue_List";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.Overdue_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Borrower_List_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Books_Btn;
        private System.Windows.Forms.Button Projects_Btn;
        private System.Windows.Forms.Button Oldquestion_Btn;
        private System.Windows.Forms.DataGridView Borrower_List_GridView;
        private System.Windows.Forms.Button button1;
    }
}

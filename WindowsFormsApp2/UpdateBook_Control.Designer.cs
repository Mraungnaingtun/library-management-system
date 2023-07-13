namespace WindowsFormsApp2
{
    partial class UpdateBook_Control
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.allBookGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_ID_Text_Btn = new System.Windows.Forms.Button();
            this.Book_ID_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allBookGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.button1.Location = new System.Drawing.Point(35, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1057, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // allBookGridView
            // 
            this.allBookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.allBookGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.allBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBookGridView.GridColor = System.Drawing.Color.Maroon;
            this.allBookGridView.Location = new System.Drawing.Point(20, 91);
            this.allBookGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.allBookGridView.Name = "allBookGridView";
            this.allBookGridView.Size = new System.Drawing.Size(919, 505);
            this.allBookGridView.TabIndex = 4;
            this.allBookGridView.DoubleClick += new System.EventHandler(this.DoubleON_Grid);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.Search_ID_Text_Btn);
            this.panel1.Controls.Add(this.Book_ID_Text);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 70);
            this.panel1.TabIndex = 5;
            // 
            // Search_ID_Text_Btn
            // 
            this.Search_ID_Text_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.Search_ID_Text_Btn.FlatAppearance.BorderSize = 0;
            this.Search_ID_Text_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_ID_Text_Btn.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ID_Text_Btn.ForeColor = System.Drawing.Color.White;
            this.Search_ID_Text_Btn.Location = new System.Drawing.Point(599, 21);
            this.Search_ID_Text_Btn.Name = "Search_ID_Text_Btn";
            this.Search_ID_Text_Btn.Size = new System.Drawing.Size(124, 34);
            this.Search_ID_Text_Btn.TabIndex = 5;
            this.Search_ID_Text_Btn.Text = "Search";
            this.Search_ID_Text_Btn.UseVisualStyleBackColor = false;
            this.Search_ID_Text_Btn.Click += new System.EventHandler(this.Search_ID_Text_Btn_Click);
            // 
            // Book_ID_Text
            // 
            this.Book_ID_Text.Font = new System.Drawing.Font("Myanmar3", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID_Text.Location = new System.Drawing.Point(366, 21);
            this.Book_ID_Text.Name = "Book_ID_Text";
            this.Book_ID_Text.Size = new System.Drawing.Size(233, 34);
            this.Book_ID_Text.TabIndex = 4;
            this.Book_ID_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeypress);
            // 
            // UpdateBook_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allBookGridView);
            this.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UpdateBook_Control";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.AllBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allBookGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView allBookGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Book_ID_Text;
        private System.Windows.Forms.Button Search_ID_Text_Btn;
    }
}

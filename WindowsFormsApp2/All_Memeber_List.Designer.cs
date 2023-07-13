namespace WindowsFormsApp2
{
    partial class All_Memeber_List
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
            this.Search_Member_Btn = new System.Windows.Forms.Button();
            this.Search_Member_By_Everying = new System.Windows.Forms.TextBox();
            this.Back_To_Register_Member = new System.Windows.Forms.Button();
            this.all_Memeber_LIst_GridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_Memeber_LIst_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.Search_Member_Btn);
            this.panel1.Controls.Add(this.Search_Member_By_Everying);
            this.panel1.Controls.Add(this.Back_To_Register_Member);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 70);
            this.panel1.TabIndex = 0;
            // 
            // Search_Member_Btn
            // 
            this.Search_Member_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.Search_Member_Btn.FlatAppearance.BorderSize = 0;
            this.Search_Member_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Member_Btn.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Member_Btn.ForeColor = System.Drawing.Color.White;
            this.Search_Member_Btn.Location = new System.Drawing.Point(810, 14);
            this.Search_Member_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_Member_Btn.Name = "Search_Member_Btn";
            this.Search_Member_Btn.Size = new System.Drawing.Size(114, 42);
            this.Search_Member_Btn.TabIndex = 2;
            this.Search_Member_Btn.Text = "Search";
            this.Search_Member_Btn.UseVisualStyleBackColor = false;
            // 
            // Search_Member_By_Everying
            // 
            this.Search_Member_By_Everying.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Member_By_Everying.Location = new System.Drawing.Point(416, 14);
            this.Search_Member_By_Everying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_Member_By_Everying.Name = "Search_Member_By_Everying";
            this.Search_Member_By_Everying.Size = new System.Drawing.Size(388, 37);
            this.Search_Member_By_Everying.TabIndex = 1;
            // 
            // Back_To_Register_Member
            // 
            this.Back_To_Register_Member.BackColor = System.Drawing.Color.Transparent;
            this.Back_To_Register_Member.FlatAppearance.BorderSize = 0;
            this.Back_To_Register_Member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_To_Register_Member.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_To_Register_Member.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.Back_To_Register_Member.Location = new System.Drawing.Point(58, 5);
            this.Back_To_Register_Member.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Back_To_Register_Member.Name = "Back_To_Register_Member";
            this.Back_To_Register_Member.Size = new System.Drawing.Size(58, 53);
            this.Back_To_Register_Member.TabIndex = 0;
            this.Back_To_Register_Member.UseVisualStyleBackColor = false;
            this.Back_To_Register_Member.Click += new System.EventHandler(this.Back_To_Register_Member_Click);
            // 
            // all_Memeber_LIst_GridView
            // 
            this.all_Memeber_LIst_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_Memeber_LIst_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_Memeber_LIst_GridView.GridColor = System.Drawing.Color.Maroon;
            this.all_Memeber_LIst_GridView.Location = new System.Drawing.Point(105, 78);
            this.all_Memeber_LIst_GridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.all_Memeber_LIst_GridView.Name = "all_Memeber_LIst_GridView";
            this.all_Memeber_LIst_GridView.Size = new System.Drawing.Size(732, 526);
            this.all_Memeber_LIst_GridView.TabIndex = 1;
            // 
            // All_Memeber_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.all_Memeber_LIst_GridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "All_Memeber_List";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.All_Memeber_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_Memeber_LIst_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_To_Register_Member;
        private System.Windows.Forms.DataGridView all_Memeber_LIst_GridView;
        private System.Windows.Forms.Button Search_Member_Btn;
        private System.Windows.Forms.TextBox Search_Member_By_Everying;
    }
}

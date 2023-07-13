namespace WindowsFormsApp2
{
    partial class Deleting_Book_Control
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
            this.Back_Delete_Control_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Delete_GridView = new System.Windows.Forms.DataGridView();
            this.Search_Text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_GridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Delete_Control_Btn
            // 
            this.Back_Delete_Control_Btn.FlatAppearance.BorderSize = 0;
            this.Back_Delete_Control_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Delete_Control_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Back_Delete_Control_Btn.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.Back_Delete_Control_Btn.Location = new System.Drawing.Point(41, 12);
            this.Back_Delete_Control_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_Delete_Control_Btn.Name = "Back_Delete_Control_Btn";
            this.Back_Delete_Control_Btn.Size = new System.Drawing.Size(54, 52);
            this.Back_Delete_Control_Btn.TabIndex = 0;
            this.Back_Delete_Control_Btn.UseVisualStyleBackColor = true;
            this.Back_Delete_Control_Btn.Click += new System.EventHandler(this.Back_Delete_Control_Btn_Click);
            // 
            // Search_Btn
            // 
            this.Search_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.Search_Btn.FlatAppearance.BorderSize = 0;
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.ForeColor = System.Drawing.Color.White;
            this.Search_Btn.Location = new System.Drawing.Point(612, 22);
            this.Search_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(108, 32);
            this.Search_Btn.TabIndex = 1;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.UseVisualStyleBackColor = false;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // Delete_GridView
            // 
            this.Delete_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.Delete_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Delete_GridView.GridColor = System.Drawing.Color.Maroon;
            this.Delete_GridView.Location = new System.Drawing.Point(22, 80);
            this.Delete_GridView.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_GridView.Name = "Delete_GridView";
            this.Delete_GridView.Size = new System.Drawing.Size(919, 527);
            this.Delete_GridView.TabIndex = 2;
            this.Delete_GridView.DoubleClick += new System.EventHandler(this.Delete_GridView_DoubleClick);
            // 
            // Search_Text
            // 
            this.Search_Text.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Text.Location = new System.Drawing.Point(365, 22);
            this.Search_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Text.Name = "Search_Text";
            this.Search_Text.Size = new System.Drawing.Size(245, 32);
            this.Search_Text.TabIndex = 3;
            this.Search_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.Back_Delete_Control_Btn);
            this.panel1.Controls.Add(this.Search_Text);
            this.panel1.Controls.Add(this.Search_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 72);
            this.panel1.TabIndex = 4;
            // 
            // Deleting_Book_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete_GridView);
            this.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Deleting_Book_Control";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.Deleting_Book_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_GridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Delete_Control_Btn;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.DataGridView Delete_GridView;
        private System.Windows.Forms.TextBox Search_Text;
        private System.Windows.Forms.Panel panel1;
    }
}

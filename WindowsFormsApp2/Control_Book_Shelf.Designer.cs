namespace WindowsFormsApp2
{
    partial class Control_Book_Shelf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Last_id_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Book_Shelf_Btn = new System.Windows.Forms.Button();
            this.row_Add_Text = new System.Windows.Forms.TextBox();
            this.shelf_Add_text = new System.Windows.Forms.TextBox();
            this.Update_Delete_Panel = new System.Windows.Forms.Panel();
            this.Selected_shelf_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete_shelf_Btn = new System.Windows.Forms.Button();
            this.Update_shelf_Btn = new System.Windows.Forms.Button();
            this.row_update_Text = new System.Windows.Forms.TextBox();
            this.shelf_Update_text = new System.Windows.Forms.TextBox();
            this.shelf_GridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Title_Update_Delete = new System.Windows.Forms.Label();
            this.Double_Click_Update_Delete = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Update_Delete_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shelf_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 62);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.button3.Location = new System.Drawing.Point(72, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 51);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Book Shelf";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Last_id_label);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Add_Book_Shelf_Btn);
            this.panel2.Controls.Add(this.row_Add_Text);
            this.panel2.Controls.Add(this.shelf_Add_text);
            this.panel2.Location = new System.Drawing.Point(110, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 200);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Row";
            // 
            // Last_id_label
            // 
            this.Last_id_label.AutoSize = true;
            this.Last_id_label.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_id_label.Location = new System.Drawing.Point(123, 152);
            this.Last_id_label.Name = "Last_id_label";
            this.Last_id_label.Size = new System.Drawing.Size(19, 23);
            this.Last_id_label.TabIndex = 3;
            this.Last_id_label.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Last ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shelf";
            // 
            // Add_Book_Shelf_Btn
            // 
            this.Add_Book_Shelf_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.Add_Book_Shelf_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Book_Shelf_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Book_Shelf_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Book_Shelf_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Book_Shelf_Btn.Location = new System.Drawing.Point(194, 144);
            this.Add_Book_Shelf_Btn.Name = "Add_Book_Shelf_Btn";
            this.Add_Book_Shelf_Btn.Size = new System.Drawing.Size(89, 39);
            this.Add_Book_Shelf_Btn.TabIndex = 1;
            this.Add_Book_Shelf_Btn.Text = "Add";
            this.Add_Book_Shelf_Btn.UseVisualStyleBackColor = false;
            this.Add_Book_Shelf_Btn.Click += new System.EventHandler(this.Add_Book_Shelf_Btn_Click);
            // 
            // row_Add_Text
            // 
            this.row_Add_Text.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row_Add_Text.Location = new System.Drawing.Point(62, 97);
            this.row_Add_Text.Name = "row_Add_Text";
            this.row_Add_Text.Size = new System.Drawing.Size(221, 31);
            this.row_Add_Text.TabIndex = 0;
            // 
            // shelf_Add_text
            // 
            this.shelf_Add_text.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelf_Add_text.Location = new System.Drawing.Point(62, 29);
            this.shelf_Add_text.Name = "shelf_Add_text";
            this.shelf_Add_text.Size = new System.Drawing.Size(221, 31);
            this.shelf_Add_text.TabIndex = 0;
            // 
            // Update_Delete_Panel
            // 
            this.Update_Delete_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.Update_Delete_Panel.Controls.Add(this.Selected_shelf_ID);
            this.Update_Delete_Panel.Controls.Add(this.label6);
            this.Update_Delete_Panel.Controls.Add(this.label5);
            this.Update_Delete_Panel.Controls.Add(this.label4);
            this.Update_Delete_Panel.Controls.Add(this.Delete_shelf_Btn);
            this.Update_Delete_Panel.Controls.Add(this.Update_shelf_Btn);
            this.Update_Delete_Panel.Controls.Add(this.row_update_Text);
            this.Update_Delete_Panel.Controls.Add(this.shelf_Update_text);
            this.Update_Delete_Panel.Location = new System.Drawing.Point(103, 369);
            this.Update_Delete_Panel.Name = "Update_Delete_Panel";
            this.Update_Delete_Panel.Size = new System.Drawing.Size(367, 237);
            this.Update_Delete_Panel.TabIndex = 1;
            // 
            // Selected_shelf_ID
            // 
            this.Selected_shelf_ID.AutoSize = true;
            this.Selected_shelf_ID.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_shelf_ID.Location = new System.Drawing.Point(151, 13);
            this.Selected_shelf_ID.Name = "Selected_shelf_ID";
            this.Selected_shelf_ID.Size = new System.Drawing.Size(19, 23);
            this.Selected_shelf_ID.TabIndex = 4;
            this.Selected_shelf_ID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar3", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selected ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shelf";
            // 
            // Delete_shelf_Btn
            // 
            this.Delete_shelf_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Delete_shelf_Btn.FlatAppearance.BorderSize = 0;
            this.Delete_shelf_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_shelf_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_shelf_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_shelf_Btn.Location = new System.Drawing.Point(194, 184);
            this.Delete_shelf_Btn.Name = "Delete_shelf_Btn";
            this.Delete_shelf_Btn.Size = new System.Drawing.Size(89, 39);
            this.Delete_shelf_Btn.TabIndex = 1;
            this.Delete_shelf_Btn.Text = "Delete";
            this.Delete_shelf_Btn.UseVisualStyleBackColor = false;
            this.Delete_shelf_Btn.Click += new System.EventHandler(this.Delete_shelf_Btn_Click);
            // 
            // Update_shelf_Btn
            // 
            this.Update_shelf_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.Update_shelf_Btn.FlatAppearance.BorderSize = 0;
            this.Update_shelf_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_shelf_Btn.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_shelf_Btn.ForeColor = System.Drawing.Color.White;
            this.Update_shelf_Btn.Location = new System.Drawing.Point(81, 184);
            this.Update_shelf_Btn.Name = "Update_shelf_Btn";
            this.Update_shelf_Btn.Size = new System.Drawing.Size(89, 39);
            this.Update_shelf_Btn.TabIndex = 1;
            this.Update_shelf_Btn.Text = "Update";
            this.Update_shelf_Btn.UseVisualStyleBackColor = false;
            this.Update_shelf_Btn.Click += new System.EventHandler(this.Update_shelf_Btn_Click);
            // 
            // row_update_Text
            // 
            this.row_update_Text.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row_update_Text.Location = new System.Drawing.Point(62, 132);
            this.row_update_Text.Name = "row_update_Text";
            this.row_update_Text.Size = new System.Drawing.Size(221, 31);
            this.row_update_Text.TabIndex = 0;
            // 
            // shelf_Update_text
            // 
            this.shelf_Update_text.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelf_Update_text.Location = new System.Drawing.Point(62, 71);
            this.shelf_Update_text.Name = "shelf_Update_text";
            this.shelf_Update_text.Size = new System.Drawing.Size(221, 31);
            this.shelf_Update_text.TabIndex = 0;
            // 
            // shelf_GridView
            // 
            this.shelf_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shelf_GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.shelf_GridView.GridColor = System.Drawing.Color.Maroon;
            this.shelf_GridView.Location = new System.Drawing.Point(549, 88);
            this.shelf_GridView.Name = "shelf_GridView";
            this.shelf_GridView.Size = new System.Drawing.Size(348, 492);
            this.shelf_GridView.TabIndex = 2;
            this.shelf_GridView.DoubleClick += new System.EventHandler(this.Double_Click_GridVIew);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.label9.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(112, 74);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Size = new System.Drawing.Size(186, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Add New Category";
            // 
            // Title_Update_Delete
            // 
            this.Title_Update_Delete.AutoSize = true;
            this.Title_Update_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Title_Update_Delete.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Update_Delete.ForeColor = System.Drawing.Color.White;
            this.Title_Update_Delete.Location = new System.Drawing.Point(105, 337);
            this.Title_Update_Delete.Name = "Title_Update_Delete";
            this.Title_Update_Delete.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Title_Update_Delete.Size = new System.Drawing.Size(153, 32);
            this.Title_Update_Delete.TabIndex = 17;
            this.Title_Update_Delete.Text = "Update / Delete";
            // 
            // Double_Click_Update_Delete
            // 
            this.Double_Click_Update_Delete.AutoSize = true;
            this.Double_Click_Update_Delete.Font = new System.Drawing.Font("Myanmar3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_Click_Update_Delete.Location = new System.Drawing.Point(105, 413);
            this.Double_Click_Update_Delete.Name = "Double_Click_Update_Delete";
            this.Double_Click_Update_Delete.Size = new System.Drawing.Size(343, 30);
            this.Double_Click_Update_Delete.TabIndex = 18;
            this.Double_Click_Update_Delete.Text = "Double Click To Update and Delete";
            // 
            // Control_Book_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Double_Click_Update_Delete);
            this.Controls.Add(this.Title_Update_Delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shelf_GridView);
            this.Controls.Add(this.Update_Delete_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Book_Shelf";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.Control_Book_Shelf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Update_Delete_Panel.ResumeLayout(false);
            this.Update_Delete_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shelf_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Update_Delete_Panel;
        private System.Windows.Forms.DataGridView shelf_GridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add_Book_Shelf_Btn;
        private System.Windows.Forms.TextBox row_Add_Text;
        private System.Windows.Forms.TextBox shelf_Add_text;
        private System.Windows.Forms.Button Delete_shelf_Btn;
        private System.Windows.Forms.Button Update_shelf_Btn;
        private System.Windows.Forms.TextBox row_update_Text;
        private System.Windows.Forms.TextBox shelf_Update_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Last_id_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Selected_shelf_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Title_Update_Delete;
        private System.Windows.Forms.Label Double_Click_Update_Delete;
    }
}

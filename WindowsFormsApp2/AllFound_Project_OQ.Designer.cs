namespace WindowsFormsApp2
{
    partial class AllFound_Project_OQ
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
            this.Result_Count_Label = new System.Windows.Forms.Label();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.Project_OR_OQ_GridView = new System.Windows.Forms.DataGridView();
            this.NoItemFound_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_OR_OQ_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Result_Count_Label);
            this.panel1.Controls.Add(this.Back_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 63);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Double Click On the Book";
            // 
            // Result_Count_Label
            // 
            this.Result_Count_Label.AutoSize = true;
            this.Result_Count_Label.Font = new System.Drawing.Font("Myanmar3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Count_Label.Location = new System.Drawing.Point(124, 15);
            this.Result_Count_Label.Name = "Result_Count_Label";
            this.Result_Count_Label.Size = new System.Drawing.Size(126, 30);
            this.Result_Count_Label.TabIndex = 17;
            this.Result_Count_Label.Text = "0 PQ Found";
            // 
            // Back_Btn
            // 
            this.Back_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_Btn.FlatAppearance.BorderSize = 0;
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Btn.Image = global::WindowsFormsApp2.Properties.Resources.icons8_back_arrow_50;
            this.Back_Btn.Location = new System.Drawing.Point(44, 4);
            this.Back_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(58, 56);
            this.Back_Btn.TabIndex = 4;
            this.Back_Btn.UseVisualStyleBackColor = false;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // Project_OR_OQ_GridView
            // 
            this.Project_OR_OQ_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Project_OR_OQ_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_OR_OQ_GridView.Location = new System.Drawing.Point(91, 70);
            this.Project_OR_OQ_GridView.Name = "Project_OR_OQ_GridView";
            this.Project_OR_OQ_GridView.Size = new System.Drawing.Size(737, 518);
            this.Project_OR_OQ_GridView.TabIndex = 16;
            // 
            // NoItemFound_Label
            // 
            this.NoItemFound_Label.AutoSize = true;
            this.NoItemFound_Label.Font = new System.Drawing.Font("Myanmar3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoItemFound_Label.Location = new System.Drawing.Point(284, 323);
            this.NoItemFound_Label.Name = "NoItemFound_Label";
            this.NoItemFound_Label.Size = new System.Drawing.Size(360, 39);
            this.NoItemFound_Label.TabIndex = 17;
            this.NoItemFound_Label.Text = "No Items Found, Thank You";
            // 
            // AllFound_Project_OQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoItemFound_Label);
            this.Controls.Add(this.Project_OR_OQ_GridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllFound_Project_OQ";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.AllFound_Project_OQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_OR_OQ_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_Btn;
        private System.Windows.Forms.DataGridView Project_OR_OQ_GridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result_Count_Label;
        private System.Windows.Forms.Label NoItemFound_Label;
    }
}

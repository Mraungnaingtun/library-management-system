namespace WindowsFormsApp2
{
    partial class Update_PQ
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
            this.Back_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Class_ComboBox = new System.Windows.Forms.ComboBox();
            this.Academic_Year_ComboBox = new System.Windows.Forms.ComboBox();
            this.FoundPQ_GridView = new System.Windows.Forms.DataGridView();
            this.Project_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Old_Question_RadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundPQ_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.Project_RadioBtn);
            this.panel1.Controls.Add(this.Old_Question_RadioBtn);
            this.panel1.Controls.Add(this.Back_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 63);
            this.panel1.TabIndex = 16;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Academic Year";
            // 
            // Class_ComboBox
            // 
            this.Class_ComboBox.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_ComboBox.FormattingEnabled = true;
            this.Class_ComboBox.Location = new System.Drawing.Point(138, 87);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.Size = new System.Drawing.Size(144, 31);
            this.Class_ComboBox.TabIndex = 19;
            this.Class_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Class_ComboBox_SelectedIndexChanged);
            // 
            // Academic_Year_ComboBox
            // 
            this.Academic_Year_ComboBox.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academic_Year_ComboBox.FormattingEnabled = true;
            this.Academic_Year_ComboBox.Location = new System.Drawing.Point(449, 87);
            this.Academic_Year_ComboBox.Name = "Academic_Year_ComboBox";
            this.Academic_Year_ComboBox.Size = new System.Drawing.Size(144, 31);
            this.Academic_Year_ComboBox.TabIndex = 17;
            this.Academic_Year_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Academic_Year_ComboBox_SelectedIndexChanged);
            // 
            // FoundPQ_GridView
            // 
            this.FoundPQ_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FoundPQ_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundPQ_GridView.Location = new System.Drawing.Point(82, 142);
            this.FoundPQ_GridView.Name = "FoundPQ_GridView";
            this.FoundPQ_GridView.Size = new System.Drawing.Size(790, 451);
            this.FoundPQ_GridView.TabIndex = 23;
            // 
            // Project_RadioBtn
            // 
            this.Project_RadioBtn.AutoSize = true;
            this.Project_RadioBtn.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project_RadioBtn.Location = new System.Drawing.Point(514, 16);
            this.Project_RadioBtn.Name = "Project_RadioBtn";
            this.Project_RadioBtn.Size = new System.Drawing.Size(90, 31);
            this.Project_RadioBtn.TabIndex = 5;
            this.Project_RadioBtn.TabStop = true;
            this.Project_RadioBtn.Text = "Project";
            this.Project_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // Old_Question_RadioBtn
            // 
            this.Old_Question_RadioBtn.AutoSize = true;
            this.Old_Question_RadioBtn.Font = new System.Drawing.Font("Myanmar3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Old_Question_RadioBtn.Location = new System.Drawing.Point(351, 16);
            this.Old_Question_RadioBtn.Name = "Old_Question_RadioBtn";
            this.Old_Question_RadioBtn.Size = new System.Drawing.Size(144, 31);
            this.Old_Question_RadioBtn.TabIndex = 6;
            this.Old_Question_RadioBtn.TabStop = true;
            this.Old_Question_RadioBtn.Text = "Old Question";
            this.Old_Question_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // Update_PQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FoundPQ_GridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.Academic_Year_ComboBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Update_PQ";
            this.Size = new System.Drawing.Size(955, 611);
            this.Load += new System.EventHandler(this.Update_PQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundPQ_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Class_ComboBox;
        private System.Windows.Forms.ComboBox Academic_Year_ComboBox;
        private System.Windows.Forms.DataGridView FoundPQ_GridView;
        private System.Windows.Forms.RadioButton Project_RadioBtn;
        private System.Windows.Forms.RadioButton Old_Question_RadioBtn;
    }
}

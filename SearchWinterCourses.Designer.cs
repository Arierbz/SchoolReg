﻿namespace SchoolReg
{
    partial class SearchWinterCourses
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            WinterCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)WinterCourses).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(33, 32);
            button1.Name = "button1";
            button1.Size = new Size(171, 40);
            button1.TabIndex = 3;
            button1.Text = "Change Term";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 112);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 5;
            label1.Text = "Search for 2026 Winter classes";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(33, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(929, 38);
            textBox1.TabIndex = 4;
            // 
            // WinterCourses
            // 
            WinterCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WinterCourses.Location = new Point(33, 206);
            WinterCourses.Name = "WinterCourses";
            WinterCourses.RowHeadersWidth = 51;
            WinterCourses.Size = new Size(929, 377);
            WinterCourses.TabIndex = 6;
            // 
            // SearchWinterCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(WinterCourses);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "SearchWinterCourses";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)WinterCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView WinterCourses;
    }
}
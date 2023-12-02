﻿namespace GUI
{
    partial class UC_CTThuoc
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.545454F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.4545441F));
            tableLayoutPanel1.Size = new Size(694, 666);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 124);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 39);
            label1.Name = "label1";
            label1.Size = new Size(309, 50);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT THUỐC";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 530);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 80);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã lô";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 239);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 1;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 161);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 2;
            label4.Text = "Mã thuốc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 319);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 3;
            label5.Text = "Ghi chú";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 303);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 76);
            textBox3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(239, 232);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(167, 39);
            numericUpDown1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(467, 436);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            // 
            // UC_CTThuoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_CTThuoc";
            Size = new Size(694, 666);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
    }
}

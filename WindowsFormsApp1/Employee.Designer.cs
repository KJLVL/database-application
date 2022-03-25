
namespace WindowsFormsApp1
{
    partial class Employee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.err = new System.Windows.Forms.Label();
            this.t7 = new System.Windows.Forms.ComboBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.ComboBox();
            this.addB = new System.Windows.Forms.Button();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1628, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back,
            this.exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.файлToolStripMenuItem.Text = "Система";
            // 
            // back
            // 
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(166, 34);
            this.back.Text = "Назад";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(166, 34);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1628, 661);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.table1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1620, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // table1
            // 
            this.table1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1.Location = new System.Drawing.Point(3, 3);
            this.table1.Name = "table1";
            this.table1.RowHeadersWidth = 62;
            this.table1.RowTemplate.Height = 28;
            this.table1.Size = new System.Drawing.Size(1614, 622);
            this.table1.TabIndex = 0;
            this.table1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table1_CellContentClick);
            this.table1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table1_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.tabPage2.Controls.Add(this.err);
            this.tabPage2.Controls.Add(this.t7);
            this.tabPage2.Controls.Add(this.t5);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.t4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.t1);
            this.tabPage2.Controls.Add(this.addB);
            this.tabPage2.Controls.Add(this.t3);
            this.tabPage2.Controls.Add(this.t2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1620, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Location = new System.Drawing.Point(20, 204);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 20);
            this.err.TabIndex = 18;
            // 
            // t7
            // 
            this.t7.FormattingEnabled = true;
            this.t7.Location = new System.Drawing.Point(155, 79);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(170, 28);
            this.t7.TabIndex = 17;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(1079, 22);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(140, 26);
            this.t5.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1006, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Пароль";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(849, 22);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(140, 26);
            this.t4.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Логин";
            // 
            // t1
            // 
            this.t1.FormattingEnabled = true;
            this.t1.Location = new System.Drawing.Point(109, 22);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(216, 28);
            this.t1.TabIndex = 10;
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.addB.FlatAppearance.BorderSize = 2;
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addB.Location = new System.Drawing.Point(12, 129);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(132, 51);
            this.addB.TabIndex = 8;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(628, 22);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(140, 26);
            this.t3.TabIndex = 7;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(382, 22);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(140, 26);
            this.t2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рабочий график";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.table2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1620, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "История изменений";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // table2
            // 
            this.table2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table2.Location = new System.Drawing.Point(0, 0);
            this.table2.Name = "table2";
            this.table2.RowHeadersWidth = 62;
            this.table2.RowTemplate.Height = 28;
            this.table2.Size = new System.Drawing.Size(1620, 628);
            this.table2.TabIndex = 1;
            this.table2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table2_CellDoubleClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1628, 694);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem back;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox t1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox t7;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView table2;
    }
}
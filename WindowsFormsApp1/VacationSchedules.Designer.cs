
namespace WindowsFormsApp1
{
    partial class VacationSchedules
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.t3 = new System.Windows.Forms.DateTimePicker();
            this.t2 = new System.Windows.Forms.DateTimePicker();
            this.errorAdd = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 33);
            this.menuStrip1.TabIndex = 10;
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
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(166, 34);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.tabPage2.Controls.Add(this.t3);
            this.tabPage2.Controls.Add(this.t2);
            this.tabPage2.Controls.Add(this.errorAdd);
            this.tabPage2.Controls.Add(this.t1);
            this.tabPage2.Controls.Add(this.error);
            this.tabPage2.Controls.Add(this.addB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1144, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(459, 71);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(166, 26);
            this.t3.TabIndex = 28;
            this.t3.Value = new System.DateTime(2021, 11, 29, 0, 37, 49, 0);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(144, 71);
            this.t2.MaxDate = new System.DateTime(2055, 12, 31, 0, 0, 0, 0);
            this.t2.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(166, 26);
            this.t2.TabIndex = 27;
            this.t2.Value = new System.DateTime(2021, 11, 29, 0, 37, 38, 0);
            // 
            // errorAdd
            // 
            this.errorAdd.AutoSize = true;
            this.errorAdd.Location = new System.Drawing.Point(12, 192);
            this.errorAdd.Name = "errorAdd";
            this.errorAdd.Size = new System.Drawing.Size(0, 20);
            this.errorAdd.TabIndex = 26;
            // 
            // t1
            // 
            this.t1.FormattingEnabled = true;
            this.t1.Location = new System.Drawing.Point(109, 22);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(147, 28);
            this.t1.TabIndex = 10;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(12, 139);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 9;
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.addB.FlatAppearance.BorderSize = 2;
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addB.Location = new System.Drawing.Point(12, 124);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(132, 51);
            this.addB.TabIndex = 8;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конец отпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало отпуска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.table1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 570);
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
            this.table1.Size = new System.Drawing.Size(1138, 564);
            this.table1.TabIndex = 0;
            this.table1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table1_CellContentClick);
            this.table1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.table1_CellFormatting_1);
            this.table1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table1_CellValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 603);
            this.tabControl1.TabIndex = 11;
            // 
            // VacationSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1152, 636);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VacationSchedules";
            this.Text = "VacationSchedules";
            this.Load += new System.EventHandler(this.VacationSchedules_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem back;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox t1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label errorAdd;
        private System.Windows.Forms.DateTimePicker t3;
        private System.Windows.Forms.DateTimePicker t2;
    }
}
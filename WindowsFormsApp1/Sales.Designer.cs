
namespace WindowsFormsApp1
{
    partial class Sales
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
            this.list = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPurL = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.Label();
            this.buyB = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.list.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPurL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1083, 33);
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
            // list
            // 
            this.list.Controls.Add(this.tabPage1);
            this.list.Controls.Add(this.tabPage2);
            this.list.Controls.Add(this.tabPage3);
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Location = new System.Drawing.Point(0, 33);
            this.list.Name = "list";
            this.list.SelectedIndex = 0;
            this.list.Size = new System.Drawing.Size(1083, 630);
            this.list.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.tPurL);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список товаров";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.add.FlatAppearance.BorderSize = 2;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(8, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(179, 41);
            this.add.TabIndex = 22;
            this.add.Text = "Добавить товары";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.err);
            this.panel2.Controls.Add(this.addB);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 244);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Location = new System.Drawing.Point(26, 203);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 20);
            this.err.TabIndex = 21;
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.addB.FlatAppearance.BorderSize = 2;
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addB.Location = new System.Drawing.Point(30, 139);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(132, 51);
            this.addB.TabIndex = 20;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количество";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Наименование";
            // 
            // tPurL
            // 
            this.tPurL.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tPurL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tPurL.Location = new System.Drawing.Point(334, 6);
            this.tPurL.Name = "tPurL";
            this.tPurL.RowHeadersWidth = 62;
            this.tPurL.RowTemplate.Height = 28;
            this.tPurL.Size = new System.Drawing.Size(720, 335);
            this.tPurL.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.tabPage2.Controls.Add(this.table1);
            this.tabPage2.Controls.Add(this.error);
            this.tabPage2.Controls.Add(this.buyB);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажа";
            // 
            // table1
            // 
            this.table1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Location = new System.Drawing.Point(18, 17);
            this.table1.Name = "table1";
            this.table1.RowHeadersWidth = 62;
            this.table1.RowTemplate.Height = 28;
            this.table1.Size = new System.Drawing.Size(868, 557);
            this.table1.TabIndex = 10;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(12, 212);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 9;
            // 
            // buyB
            // 
            this.buyB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.buyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buyB.FlatAppearance.BorderSize = 2;
            this.buyB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyB.Location = new System.Drawing.Point(918, 17);
            this.buyB.Name = "buyB";
            this.buyB.Size = new System.Drawing.Size(132, 51);
            this.buyB.TabIndex = 8;
            this.buyB.Text = "Продать";
            this.buyB.UseVisualStyleBackColor = false;
            this.buyB.Click += new System.EventHandler(this.buyB_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.table2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1075, 597);
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
            this.table2.Size = new System.Drawing.Size(1075, 597);
            this.table2.TabIndex = 11;
            this.table2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table2_CellDoubleClick);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1083, 663);
            this.Controls.Add(this.list);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.list.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPurL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem back;
        private System.Windows.Forms.TabControl list;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tPurL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button buyB;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView table2;
    }
}
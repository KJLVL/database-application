
namespace WindowsFormsApp1
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.prB = new System.Windows.Forms.Button();
            this.purP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.v);
            this.panel1.Controls.Add(this.backB);
            this.panel1.Controls.Add(this.prB);
            this.panel1.Controls.Add(this.purP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.openP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 358);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(429, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "загрузить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.Color.SlateGray;
            this.v.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v.FlatAppearance.BorderSize = 2;
            this.v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v.Location = new System.Drawing.Point(301, 301);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(122, 45);
            this.v.TabIndex = 13;
            this.v.Text = "выгрузить";
            this.v.UseVisualStyleBackColor = false;
            this.v.Click += new System.EventHandler(this.button1_Click);
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.SlateGray;
            this.backB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backB.FlatAppearance.BorderSize = 2;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backB.Location = new System.Drawing.Point(12, 301);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(86, 45);
            this.backB.TabIndex = 12;
            this.backB.Text = "выход";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // prB
            // 
            this.prB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.prB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.prB.FlatAppearance.BorderSize = 2;
            this.prB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prB.Location = new System.Drawing.Point(301, 145);
            this.prB.Name = "prB";
            this.prB.Size = new System.Drawing.Size(211, 41);
            this.prB.TabIndex = 11;
            this.prB.Text = "Товар\r\n";
            this.prB.UseVisualStyleBackColor = false;
            this.prB.Click += new System.EventHandler(this.prB_Click_3);
            // 
            // purP
            // 
            this.purP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.purP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.purP.FlatAppearance.BorderSize = 2;
            this.purP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.purP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purP.Location = new System.Drawing.Point(301, 204);
            this.purP.Name = "purP";
            this.purP.Size = new System.Drawing.Size(211, 41);
            this.purP.TabIndex = 10;
            this.purP.Text = "Закупка товара";
            this.purP.UseVisualStyleBackColor = false;
            this.purP.Click += new System.EventHandler(this.purP_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Таблицы для редактирования:\r\n";
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.openP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openP.FlatAppearance.BorderSize = 2;
            this.openP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openP.Location = new System.Drawing.Point(301, 70);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(211, 41);
            this.openP.TabIndex = 6;
            this.openP.Text = "Посмотреть данные\r\n";
            this.openP.UseVisualStyleBackColor = false;
            this.openP.Click += new System.EventHandler(this.openP_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Просмотр доступных таблиц:\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(145)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 52);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать, администратор\r\n";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 358);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button purP;
        private System.Windows.Forms.Button prB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button v;
    }
}

namespace WindowsFormsApp1
{
    partial class SellerOpen
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
            this.backB = new System.Windows.Forms.Button();
            this.vacationB = new System.Windows.Forms.Button();
            this.workB = new System.Windows.Forms.Button();
            this.tableP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.backB);
            this.panel1.Controls.Add(this.vacationB);
            this.panel1.Controls.Add(this.workB);
            this.panel1.Controls.Add(this.tableP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 319);
            this.panel1.TabIndex = 3;
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.SlateGray;
            this.backB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backB.FlatAppearance.BorderSize = 2;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backB.Location = new System.Drawing.Point(3, 262);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(145, 45);
            this.backB.TabIndex = 6;
            this.backB.Text = "назад";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // vacationB
            // 
            this.vacationB.BackColor = System.Drawing.Color.SteelBlue;
            this.vacationB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vacationB.FlatAppearance.BorderSize = 2;
            this.vacationB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacationB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacationB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vacationB.Location = new System.Drawing.Point(3, 89);
            this.vacationB.Name = "vacationB";
            this.vacationB.Size = new System.Drawing.Size(145, 74);
            this.vacationB.TabIndex = 5;
            this.vacationB.Text = "График отпусков";
            this.vacationB.UseVisualStyleBackColor = false;
            this.vacationB.Click += new System.EventHandler(this.vacationB_Click);
            // 
            // workB
            // 
            this.workB.BackColor = System.Drawing.Color.SteelBlue;
            this.workB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workB.FlatAppearance.BorderSize = 2;
            this.workB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workB.Location = new System.Drawing.Point(3, 12);
            this.workB.Name = "workB";
            this.workB.Size = new System.Drawing.Size(145, 71);
            this.workB.TabIndex = 4;
            this.workB.Text = "Рабочий график";
            this.workB.UseVisualStyleBackColor = false;
            this.workB.Click += new System.EventHandler(this.workB_Click);
            // 
            // tableP
            // 
            this.tableP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.tableP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableP.Location = new System.Drawing.Point(154, 12);
            this.tableP.Name = "tableP";
            this.tableP.RowHeadersWidth = 62;
            this.tableP.RowTemplate.Height = 28;
            this.tableP.Size = new System.Drawing.Size(660, 295);
            this.tableP.TabIndex = 2;
            // 
            // SellerOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 319);
            this.Controls.Add(this.panel1);
            this.Name = "SellerOpen";
            this.Text = "SellerOpen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button vacationB;
        private System.Windows.Forms.Button workB;
        private System.Windows.Forms.DataGridView tableP;
    }
}
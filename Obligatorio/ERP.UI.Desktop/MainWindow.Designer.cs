namespace ERP.UI
{
    partial class MainWindow
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
            this.title = new System.Windows.Forms.Label();
            this.subjectMB = new System.Windows.Forms.Button();
            this.teacherMB = new System.Windows.Forms.Button();
            this.studentMB = new System.Windows.Forms.Button();
            this.vanMB = new System.Windows.Forms.Button();
            this.subMenuPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(30, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(346, 42);
            this.title.TabIndex = 0;
            this.title.Text = "SISTEMA DEL COLEGIO";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subjectMB
            // 
            this.subjectMB.BackColor = System.Drawing.Color.SteelBlue;
            this.subjectMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectMB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectMB.ForeColor = System.Drawing.Color.AliceBlue;
            this.subjectMB.Location = new System.Drawing.Point(37, 78);
            this.subjectMB.Name = "subjectMB";
            this.subjectMB.Size = new System.Drawing.Size(147, 46);
            this.subjectMB.TabIndex = 1;
            this.subjectMB.Text = "MATERIAS";
            this.subjectMB.UseVisualStyleBackColor = false;
            this.subjectMB.Click += new System.EventHandler(this.subjectMB_Click_1);
            // 
            // teacherMB
            // 
            this.teacherMB.BackColor = System.Drawing.Color.SteelBlue;
            this.teacherMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherMB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherMB.ForeColor = System.Drawing.Color.AliceBlue;
            this.teacherMB.Location = new System.Drawing.Point(190, 78);
            this.teacherMB.Name = "teacherMB";
            this.teacherMB.Size = new System.Drawing.Size(147, 46);
            this.teacherMB.TabIndex = 2;
            this.teacherMB.Text = "DOCENTES";
            this.teacherMB.UseVisualStyleBackColor = false;
            this.teacherMB.Click += new System.EventHandler(this.teacherMB_Click);
            // 
            // studentMB
            // 
            this.studentMB.BackColor = System.Drawing.Color.SteelBlue;
            this.studentMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentMB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentMB.ForeColor = System.Drawing.Color.AliceBlue;
            this.studentMB.Location = new System.Drawing.Point(343, 78);
            this.studentMB.Name = "studentMB";
            this.studentMB.Size = new System.Drawing.Size(147, 46);
            this.studentMB.TabIndex = 3;
            this.studentMB.Text = "ALUMNOS";
            this.studentMB.UseVisualStyleBackColor = false;
            this.studentMB.Click += new System.EventHandler(this.studentMB_Click);
            // 
            // vanMB
            // 
            this.vanMB.BackColor = System.Drawing.Color.SteelBlue;
            this.vanMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vanMB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanMB.ForeColor = System.Drawing.Color.AliceBlue;
            this.vanMB.Location = new System.Drawing.Point(496, 78);
            this.vanMB.Name = "vanMB";
            this.vanMB.Size = new System.Drawing.Size(147, 46);
            this.vanMB.TabIndex = 4;
            this.vanMB.Text = "CAMIONETAS";
            this.vanMB.UseVisualStyleBackColor = false;
            this.vanMB.Click += new System.EventHandler(this.vanMB_Click);
            // 
            // subMenuPanel
            // 
            this.subMenuPanel.Location = new System.Drawing.Point(37, 130);
            this.subMenuPanel.Name = "subMenuPanel";
            this.subMenuPanel.Size = new System.Drawing.Size(147, 531);
            this.subMenuPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(190, 130);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(898, 531);
            this.mainPanel.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 674);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.subMenuPanel);
            this.Controls.Add(this.vanMB);
            this.Controls.Add(this.studentMB);
            this.Controls.Add(this.teacherMB);
            this.Controls.Add(this.subjectMB);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Sistema del colegio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button subjectMB;
        private System.Windows.Forms.Button teacherMB;
        private System.Windows.Forms.Button studentMB;
        private System.Windows.Forms.Button vanMB;
        private System.Windows.Forms.Panel subMenuPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}


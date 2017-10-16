namespace ERP.UI.Teacher
{
    partial class TeacherMain
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.vanDataGrid = new System.Windows.Forms.DataGridView();
            this.subjectsBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vanDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "VISUALIZACION DE DOCENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vanDataGrid
            // 
            this.vanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanDataGrid.Location = new System.Drawing.Point(35, 64);
            this.vanDataGrid.Name = "vanDataGrid";
            this.vanDataGrid.Size = new System.Drawing.Size(396, 311);
            this.vanDataGrid.TabIndex = 12;
            // 
            // subjectsBox
            // 
            this.subjectsBox.FormattingEnabled = true;
            this.subjectsBox.ItemHeight = 19;
            this.subjectsBox.Location = new System.Drawing.Point(437, 86);
            this.subjectsBox.Name = "subjectsBox";
            this.subjectsBox.Size = new System.Drawing.Size(337, 289);
            this.subjectsBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Materias dictadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Listado de docentes";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.AliceBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.editButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.editButton.Location = new System.Drawing.Point(35, 381);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 37);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "EDITAR";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.AliceBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(123, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 37);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "ELIMINAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectsBox);
            this.Controls.Add(this.vanDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherMain";
            this.Size = new System.Drawing.Size(898, 531);
            ((System.ComponentModel.ISupportInitialize)(this.vanDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vanDataGrid;
        private System.Windows.Forms.ListBox subjectsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

namespace ERP.UI.Student
{
    partial class StudentMain
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectsBox = new System.Windows.Forms.ListBox();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.AliceBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(211, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 37);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "ELIMINAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.AliceBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.editButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.editButton.Location = new System.Drawing.Point(123, 381);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 37);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "EDITAR";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Listado de alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Materias a las que se encuentra inscripto";
            // 
            // subjectsBox
            // 
            this.subjectsBox.FormattingEnabled = true;
            this.subjectsBox.ItemHeight = 19;
            this.subjectsBox.Location = new System.Drawing.Point(532, 86);
            this.subjectsBox.Name = "subjectsBox";
            this.subjectsBox.Size = new System.Drawing.Size(320, 289);
            this.subjectsBox.TabIndex = 29;
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.LastName,
            this.studentNumber,
            this.Id});
            this.studentDataGrid.Location = new System.Drawing.Point(35, 64);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.Size = new System.Drawing.Size(487, 311);
            this.studentDataGrid.TabIndex = 28;
            this.studentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "VISUALIZACION DE ALUMNOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.addButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addButton.Location = new System.Drawing.Point(35, 381);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 37);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "NUEVO";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellido";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // studentNumber
            // 
            this.studentNumber.HeaderText = "#Estudiante";
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "CI";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectsBox);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(898, 531);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox subjectsBox;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

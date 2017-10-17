namespace ERP.UI.Subject
{
    partial class SubjectMenu
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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.addStudentButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addStudentButton.Location = new System.Drawing.Point(3, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(141, 37);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Nueva Materia";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // SubjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addStudentButton);
            this.Name = "SubjectMenu";
            this.Size = new System.Drawing.Size(147, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
    }
}

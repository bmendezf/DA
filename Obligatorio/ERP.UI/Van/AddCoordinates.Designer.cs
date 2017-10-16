namespace ERP.UI.Van
{
    partial class AddCoordinates
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yCoordinate = new System.Windows.Forms.NumericUpDown();
            this.xCoordinate = new System.Windows.Forms.NumericUpDown();
            this.studentSelectBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinate)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.addButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addButton.Location = new System.Drawing.Point(446, 166);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 37);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "AGREGAR";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(111, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 37);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "CANCELAR";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "COORDENADA X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "ALUMNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "AGREGAR COORDENADAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "COORDENADA Y";
            // 
            // yCoordinate
            // 
            this.yCoordinate.Location = new System.Drawing.Point(446, 99);
            this.yCoordinate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.yCoordinate.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.yCoordinate.Name = "yCoordinate";
            this.yCoordinate.Size = new System.Drawing.Size(82, 27);
            this.yCoordinate.TabIndex = 18;
            // 
            // xCoordinate
            // 
            this.xCoordinate.Location = new System.Drawing.Point(233, 101);
            this.xCoordinate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.xCoordinate.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.xCoordinate.Name = "xCoordinate";
            this.xCoordinate.Size = new System.Drawing.Size(82, 27);
            this.xCoordinate.TabIndex = 19;
            // 
            // studentSelectBox
            // 
            this.studentSelectBox.FormattingEnabled = true;
            this.studentSelectBox.Location = new System.Drawing.Point(111, 54);
            this.studentSelectBox.Name = "studentSelectBox";
            this.studentSelectBox.Size = new System.Drawing.Size(417, 27);
            this.studentSelectBox.TabIndex = 20;
            // 
            // AddCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentSelectBox);
            this.Controls.Add(this.xCoordinate);
            this.Controls.Add(this.yCoordinate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCoordinates";
            this.Size = new System.Drawing.Size(898, 531);
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yCoordinate;
        private System.Windows.Forms.NumericUpDown xCoordinate;
        private System.Windows.Forms.ComboBox studentSelectBox;
    }
}

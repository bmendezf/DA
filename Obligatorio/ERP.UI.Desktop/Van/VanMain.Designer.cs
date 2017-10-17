namespace ERP.UI.Van
{
    partial class VanMain
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "VISUALIZACION DE CAMIONETAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vanDataGrid
            // 
            this.vanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanDataGrid.Location = new System.Drawing.Point(9, 50);
            this.vanDataGrid.Name = "vanDataGrid";
            this.vanDataGrid.Size = new System.Drawing.Size(779, 287);
            this.vanDataGrid.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.addButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addButton.Location = new System.Drawing.Point(9, 343);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 37);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "NUEVO";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.AliceBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(185, 343);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 37);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "ELIMINAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.AliceBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.editButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.editButton.Location = new System.Drawing.Point(97, 343);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 37);
            this.editButton.TabIndex = 35;
            this.editButton.Text = "EDITAR";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // VanMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.vanDataGrid);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VanMain";
            this.Size = new System.Drawing.Size(898, 531);
            ((System.ComponentModel.ISupportInitialize)(this.vanDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vanDataGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}

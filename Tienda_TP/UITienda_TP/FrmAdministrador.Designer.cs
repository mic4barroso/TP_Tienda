namespace UITienda_TP
{
    partial class FmrAdministrador
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
            this.grilla_empleados = new System.Windows.Forms.DataGridView();
            this.lblVerEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_empleados
            // 
            this.grilla_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_empleados.Location = new System.Drawing.Point(25, 60);
            this.grilla_empleados.Name = "grilla_empleados";
            this.grilla_empleados.Size = new System.Drawing.Size(425, 158);
            this.grilla_empleados.TabIndex = 0;
            this.grilla_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_empleados_CellContentClick);
            // 
            // lblVerEmpleados
            // 
            this.lblVerEmpleados.AutoSize = true;
            this.lblVerEmpleados.Location = new System.Drawing.Point(22, 35);
            this.lblVerEmpleados.Name = "lblVerEmpleados";
            this.lblVerEmpleados.Size = new System.Drawing.Size(123, 13);
            this.lblVerEmpleados.TabIndex = 1;
            this.lblVerEmpleados.Text = "Empleados en el sistema";
            // 
            // FmrAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVerEmpleados);
            this.Controls.Add(this.grilla_empleados);
            this.Name = "FmrAdministrador";
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FmrAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_empleados;
        private System.Windows.Forms.Label lblVerEmpleados;
    }
}
namespace Presentacion.AgenciaA
{
    partial class FrmPrincipal
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnHerramienta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(185, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(615, 450);
            this.pnlContenedor.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(49, 50);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(49, 114);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(49, 166);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnHerramienta
            // 
            this.btnHerramienta.Location = new System.Drawing.Point(49, 214);
            this.btnHerramienta.Name = "btnHerramienta";
            this.btnHerramienta.Size = new System.Drawing.Size(75, 23);
            this.btnHerramienta.TabIndex = 3;
            this.btnHerramienta.Text = "HERRAMIENTA";
            this.btnHerramienta.UseVisualStyleBackColor = true;
            this.btnHerramienta.Click += new System.EventHandler(this.btnHerramienta_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHerramienta);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmPrincipal";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnHerramienta;
    }
}
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
            this.pnlContenedor.Location = new System.Drawing.Point(259, 14);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(660, 409);
            this.pnlContenedor.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdmin.Location = new System.Drawing.Point(35, 201);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(163, 69);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.RosyBrown;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(35, 14);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(163, 64);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnProductos.Location = new System.Drawing.Point(35, 296);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(163, 79);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnHerramienta
            // 
            this.btnHerramienta.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHerramienta.Location = new System.Drawing.Point(35, 104);
            this.btnHerramienta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHerramienta.Name = "btnHerramienta";
            this.btnHerramienta.Size = new System.Drawing.Size(163, 71);
            this.btnHerramienta.TabIndex = 3;
            this.btnHerramienta.Text = "HERRAMIENTA";
            this.btnHerramienta.UseVisualStyleBackColor = false;
            this.btnHerramienta.Click += new System.EventHandler(this.btnHerramienta_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(927, 430);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnHerramienta);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
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
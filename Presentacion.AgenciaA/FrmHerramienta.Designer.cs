namespace Presentacion.AgenciaA
{
    partial class FrmHerramienta
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
            this.dtgHerramienta = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHerramienta
            // 
            this.dtgHerramienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHerramienta.Location = new System.Drawing.Point(30, 276);
            this.dtgHerramienta.Name = "dtgHerramienta";
            this.dtgHerramienta.RowHeadersWidth = 51;
            this.dtgHerramienta.RowTemplate.Height = 24;
            this.dtgHerramienta.Size = new System.Drawing.Size(627, 150);
            this.dtgHerramienta.TabIndex = 1;
            this.dtgHerramienta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHerramienta_CellEnter);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(43, 197);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(586, 34);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FrmHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 466);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgHerramienta);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHerramienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHerramienta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHerramienta;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
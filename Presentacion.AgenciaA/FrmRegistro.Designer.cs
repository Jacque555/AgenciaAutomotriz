namespace Presentacion.AgenciaA
{
    partial class FrmRegistro
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfContrasena = new System.Windows.Forms.TextBox();
            this.chnMostrarC = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(121, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 34);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(335, 536);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(166, 93);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(237, 34);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // txtConfContrasena
            // 
            this.txtConfContrasena.Location = new System.Drawing.Point(309, 165);
            this.txtConfContrasena.Name = "txtConfContrasena";
            this.txtConfContrasena.Size = new System.Drawing.Size(237, 34);
            this.txtConfContrasena.TabIndex = 5;
            this.txtConfContrasena.Enter += new System.EventHandler(this.txtConfContrasena_Enter);
            this.txtConfContrasena.Leave += new System.EventHandler(this.txtConfContrasena_Leave);
            // 
            // chnMostrarC
            // 
            this.chnMostrarC.AutoSize = true;
            this.chnMostrarC.Location = new System.Drawing.Point(253, 248);
            this.chnMostrarC.Name = "chnMostrarC";
            this.chnMostrarC.Size = new System.Drawing.Size(223, 31);
            this.chnMostrarC.TabIndex = 7;
            this.chnMostrarC.Text = "Mostrar Contraseña";
            this.chnMostrarC.UseVisualStyleBackColor = true;
            this.chnMostrarC.CheckedChanged += new System.EventHandler(this.chnMostrarC_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 276);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 34);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "APELLIDO PATERNO";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(207, 335);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(237, 34);
            this.txtApellidoP.TabIndex = 10;
            this.txtApellidoP.Enter += new System.EventHandler(this.txtApellidoP_Enter);
            this.txtApellidoP.Leave += new System.EventHandler(this.txtApellidoP_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "APELLIDO MATERNO";
            // 
            // txtApellidom
            // 
            this.txtApellidom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtApellidom.Location = new System.Drawing.Point(207, 389);
            this.txtApellidom.Name = "txtApellidom";
            this.txtApellidom.Size = new System.Drawing.Size(237, 34);
            this.txtApellidom.TabIndex = 12;
            this.txtApellidom.Enter += new System.EventHandler(this.txtApellidom_Enter);
            this.txtApellidom.Leave += new System.EventHandler(this.txtApellidom_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "FECHA NACIMIENTO";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFecha.Location = new System.Drawing.Point(207, 441);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(237, 34);
            this.txtFecha.TabIndex = 14;
            this.txtFecha.Enter += new System.EventHandler(this.txtFecha_Enter);
            this.txtFecha.Leave += new System.EventHandler(this.txtFecha_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "PERMISOS";
            // 
            // txtPermisos
            // 
            this.txtPermisos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPermisos.Location = new System.Drawing.Point(209, 496);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(237, 34);
            this.txtPermisos.TabIndex = 16;
            this.txtPermisos.Enter += new System.EventHandler(this.txtPermisos_Enter);
            this.txtPermisos.Leave += new System.EventHandler(this.txtPermisos_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(450, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 589);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPermisos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.chnMostrarC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfContrasena;
        private System.Windows.Forms.CheckBox chnMostrarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPermisos;
        private System.Windows.Forms.Button btnCancelar;
    }
}
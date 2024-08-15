namespace Astronauta
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviarClave = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnAtaqueFuerte = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblSaludAstronauta = new System.Windows.Forms.Label();
            this.btnAtaqueRapido = new System.Windows.Forms.Button();
            this.pnlCombate = new System.Windows.Forms.Panel();
            this.pnlClave = new System.Windows.Forms.Panel();
            this.lstInventario = new System.Windows.Forms.ListBox();
            this.lblSaludEnemigo = new System.Windows.Forms.Label();
            this.lblEstadoCombate = new System.Windows.Forms.Label();
            this.btnDefender = new System.Windows.Forms.Button();
            this.pnlCombate.SuspendLayout();
            this.pnlClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarClave
            // 
            this.btnEnviarClave.Location = new System.Drawing.Point(176, 54);
            this.btnEnviarClave.Name = "btnEnviarClave";
            this.btnEnviarClave.Size = new System.Drawing.Size(103, 39);
            this.btnEnviarClave.TabIndex = 6;
            this.btnEnviarClave.Text = "Enter";
            this.btnEnviarClave.UseVisualStyleBackColor = true;
            this.btnEnviarClave.Click += new System.EventHandler(this.btnEnviarClave_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(532, 92);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(146, 63);
            this.btnOpcion2.TabIndex = 1;
            this.btnOpcion2.Text = "Opción 2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(532, 13);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(146, 62);
            this.btnOpcion1.TabIndex = 0;
            this.btnOpcion1.Text = "Opción 1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(34, 64);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(118, 20);
            this.txtClave.TabIndex = 3;
            // 
            // btnAtaqueFuerte
            // 
            this.btnAtaqueFuerte.Location = new System.Drawing.Point(14, 45);
            this.btnAtaqueFuerte.Name = "btnAtaqueFuerte";
            this.btnAtaqueFuerte.Size = new System.Drawing.Size(103, 39);
            this.btnAtaqueFuerte.TabIndex = 2;
            this.btnAtaqueFuerte.Text = "AtaqueFuerte";
            this.btnAtaqueFuerte.UseVisualStyleBackColor = true;
//            this.btnAtaqueFuerte.Click += new System.EventHandler(this.btnHuir_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 13);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(25, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "lblH";
            // 
            // lblSaludAstronauta
            // 
            this.lblSaludAstronauta.AutoSize = true;
            this.lblSaludAstronauta.Location = new System.Drawing.Point(9, 209);
            this.lblSaludAstronauta.Name = "lblSaludAstronauta";
            this.lblSaludAstronauta.Size = new System.Drawing.Size(95, 13);
            this.lblSaludAstronauta.TabIndex = 2;
            this.lblSaludAstronauta.Text = "lblSaludAstronauta";
            // 
            // btnAtaqueRapido
            // 
            this.btnAtaqueRapido.Location = new System.Drawing.Point(133, 45);
            this.btnAtaqueRapido.Name = "btnAtaqueRapido";
            this.btnAtaqueRapido.Size = new System.Drawing.Size(103, 39);
            this.btnAtaqueRapido.TabIndex = 5;
            this.btnAtaqueRapido.Text = "Ataque Rápido";
            this.btnAtaqueRapido.UseVisualStyleBackColor = true;
      //      this.btnAtaqueRapido.Click += new System.EventHandler(this.Atacar_Click);
            // 
            // pnlCombate
            // 
            this.pnlCombate.Controls.Add(this.btnDefender);
            this.pnlCombate.Controls.Add(this.lblEstadoCombate);
            this.pnlCombate.Controls.Add(this.btnAtaqueRapido);
            this.pnlCombate.Controls.Add(this.btnAtaqueFuerte);
            this.pnlCombate.Location = new System.Drawing.Point(15, 287);
            this.pnlCombate.Name = "pnlCombate";
            this.pnlCombate.Size = new System.Drawing.Size(378, 148);
            this.pnlCombate.TabIndex = 7;
            // 
            // pnlClave
            // 
            this.pnlClave.Controls.Add(this.btnEnviarClave);
            this.pnlClave.Controls.Add(this.txtClave);
            this.pnlClave.Location = new System.Drawing.Point(399, 287);
            this.pnlClave.Name = "pnlClave";
            this.pnlClave.Size = new System.Drawing.Size(355, 148);
            this.pnlClave.TabIndex = 8;
            // 
            // lstInventario
            // 
            this.lstInventario.FormattingEnabled = true;
            this.lstInventario.Location = new System.Drawing.Point(532, 174);
            this.lstInventario.Name = "lstInventario";
            this.lstInventario.Size = new System.Drawing.Size(146, 95);
            this.lstInventario.TabIndex = 9;
            // 
            // lblSaludEnemigo
            // 
            this.lblSaludEnemigo.AutoSize = true;
            this.lblSaludEnemigo.Location = new System.Drawing.Point(9, 241);
            this.lblSaludEnemigo.Name = "lblSaludEnemigo";
            this.lblSaludEnemigo.Size = new System.Drawing.Size(85, 13);
            this.lblSaludEnemigo.TabIndex = 10;
            this.lblSaludEnemigo.Text = "lblSaludEnemigo";
            // 
            // lblEstadoCombate
            // 
            this.lblEstadoCombate.AutoSize = true;
            this.lblEstadoCombate.Location = new System.Drawing.Point(41, 4);
            this.lblEstadoCombate.Name = "lblEstadoCombate";
            this.lblEstadoCombate.Size = new System.Drawing.Size(92, 13);
            this.lblEstadoCombate.TabIndex = 6;
            this.lblEstadoCombate.Text = "lblEstadoCombate";
            // 
            // btnDefender
            // 
            this.btnDefender.Location = new System.Drawing.Point(259, 45);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(103, 39);
            this.btnDefender.TabIndex = 7;
            this.btnDefender.Text = "Defender";
            this.btnDefender.UseVisualStyleBackColor = true;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 447);
            this.Controls.Add(this.lblSaludEnemigo);
            this.Controls.Add(this.lstInventario);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.pnlClave);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.pnlCombate);
            this.Controls.Add(this.lblSaludAstronauta);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCombate.ResumeLayout(false);
            this.pnlCombate.PerformLayout();
            this.pnlClave.ResumeLayout(false);
            this.pnlClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtaqueFuerte;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblSaludAstronauta;
        private System.Windows.Forms.Button btnAtaqueRapido;
        private System.Windows.Forms.Button btnEnviarClave;
        private System.Windows.Forms.Panel pnlCombate;
        private System.Windows.Forms.Panel pnlClave;
        private System.Windows.Forms.ListBox lstInventario;
        private System.Windows.Forms.Button btnDefender;
        private System.Windows.Forms.Label lblEstadoCombate;
        private System.Windows.Forms.Label lblSaludEnemigo;
    }
}


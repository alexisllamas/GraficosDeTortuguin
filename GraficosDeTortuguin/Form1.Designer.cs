namespace GraficosDeTortuguin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.txtCaminar = new System.Windows.Forms.TextBox();
            this.cmdCaminar = new System.Windows.Forms.Button();
            this.cmdGirarIzquierda = new System.Windows.Forms.Button();
            this.cmdGirarDerecha = new System.Windows.Forms.Button();
            this.cmdPlumaArriba = new System.Windows.Forms.Button();
            this.cmdPlumaAbajo = new System.Windows.Forms.Button();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(16, 258);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 16;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // txtCaminar
            // 
            this.txtCaminar.Location = new System.Drawing.Point(80, 210);
            this.txtCaminar.Name = "txtCaminar";
            this.txtCaminar.Size = new System.Drawing.Size(36, 20);
            this.txtCaminar.TabIndex = 15;
            // 
            // cmdCaminar
            // 
            this.cmdCaminar.Location = new System.Drawing.Point(16, 208);
            this.cmdCaminar.Name = "cmdCaminar";
            this.cmdCaminar.Size = new System.Drawing.Size(58, 23);
            this.cmdCaminar.TabIndex = 14;
            this.cmdCaminar.Text = "Caminar";
            this.cmdCaminar.UseVisualStyleBackColor = true;
            this.cmdCaminar.Click += new System.EventHandler(this.cmdCaminar_Click);
            // 
            // cmdGirarIzquierda
            // 
            this.cmdGirarIzquierda.Location = new System.Drawing.Point(16, 164);
            this.cmdGirarIzquierda.Name = "cmdGirarIzquierda";
            this.cmdGirarIzquierda.Size = new System.Drawing.Size(94, 23);
            this.cmdGirarIzquierda.TabIndex = 12;
            this.cmdGirarIzquierda.Text = "Girar izquierda";
            this.cmdGirarIzquierda.UseVisualStyleBackColor = true;
            this.cmdGirarIzquierda.Click += new System.EventHandler(this.cmdGirarIzquierda_Click);
            // 
            // cmdGirarDerecha
            // 
            this.cmdGirarDerecha.Location = new System.Drawing.Point(16, 118);
            this.cmdGirarDerecha.Name = "cmdGirarDerecha";
            this.cmdGirarDerecha.Size = new System.Drawing.Size(94, 23);
            this.cmdGirarDerecha.TabIndex = 11;
            this.cmdGirarDerecha.Text = "Girar derecha";
            this.cmdGirarDerecha.UseVisualStyleBackColor = true;
            this.cmdGirarDerecha.Click += new System.EventHandler(this.cmdGirarDerecha_Click);
            // 
            // cmdPlumaArriba
            // 
            this.cmdPlumaArriba.Location = new System.Drawing.Point(16, 66);
            this.cmdPlumaArriba.Name = "cmdPlumaArriba";
            this.cmdPlumaArriba.Size = new System.Drawing.Size(75, 23);
            this.cmdPlumaArriba.TabIndex = 10;
            this.cmdPlumaArriba.Text = "Pluma arriba";
            this.cmdPlumaArriba.UseVisualStyleBackColor = true;
            this.cmdPlumaArriba.Click += new System.EventHandler(this.cmdPlumaArriba_Click);
            // 
            // cmdPlumaAbajo
            // 
            this.cmdPlumaAbajo.Location = new System.Drawing.Point(16, 13);
            this.cmdPlumaAbajo.Name = "cmdPlumaAbajo";
            this.cmdPlumaAbajo.Size = new System.Drawing.Size(75, 23);
            this.cmdPlumaAbajo.TabIndex = 9;
            this.cmdPlumaAbajo.Text = "Pluma abajo";
            this.cmdPlumaAbajo.UseVisualStyleBackColor = true;
            this.cmdPlumaAbajo.Click += new System.EventHandler(this.cmdPlumaAbajo_Click);
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(12, 287);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(186, 268);
            this.txtTablero.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.txtCaminar);
            this.Controls.Add(this.cmdCaminar);
            this.Controls.Add(this.txtTablero);
            this.Controls.Add(this.cmdGirarIzquierda);
            this.Controls.Add(this.cmdGirarDerecha);
            this.Controls.Add(this.cmdPlumaArriba);
            this.Controls.Add(this.cmdPlumaAbajo);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.TextBox txtCaminar;
        private System.Windows.Forms.Button cmdCaminar;
        private System.Windows.Forms.Button cmdGirarIzquierda;
        private System.Windows.Forms.Button cmdGirarDerecha;
        private System.Windows.Forms.Button cmdPlumaArriba;
        private System.Windows.Forms.Button cmdPlumaAbajo;
        private System.Windows.Forms.TextBox txtTablero;
    }
}


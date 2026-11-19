namespace FormCRUDB
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnInventarioProductos = new System.Windows.Forms.Button();
            this.btnBarista = new System.Windows.Forms.Button();
            this.btnSesionFuera = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btnVenta);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnSesionFuera);
            this.panel1.Controls.Add(this.btnBarista);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnInventarioProductos);
            this.panel1.Controls.Add(this.btnCocina);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnCierre);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 443);
            this.panel1.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(9, 9);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(105, 23);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(9, 401);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(105, 23);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(9, 97);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(105, 23);
            this.btnCocina.TabIndex = 2;
            this.btnCocina.Text = "Cocina(Barista)";
            this.btnCocina.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(9, 51);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(105, 23);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnCierre
            // 
            this.btnCierre.BackColor = System.Drawing.Color.Transparent;
            this.btnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCierre.Location = new System.Drawing.Point(9, 142);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(105, 23);
            this.btnCierre.TabIndex = 3;
            this.btnCierre.Text = "Cierre de caja";
            this.btnCierre.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTituloForm);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panel2.Location = new System.Drawing.Point(172, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 74);
            this.panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 450);
            this.panelContenedor.TabIndex = 2;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Location = new System.Drawing.Point(28, 9);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(35, 13);
            this.lblTituloForm.TabIndex = 2;
            this.lblTituloForm.Text = "label1";
            // 
            // btnInventarioProductos
            // 
            this.btnInventarioProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnInventarioProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventarioProductos.Location = new System.Drawing.Point(9, 51);
            this.btnInventarioProductos.Name = "btnInventarioProductos";
            this.btnInventarioProductos.Size = new System.Drawing.Size(105, 23);
            this.btnInventarioProductos.TabIndex = 1;
            this.btnInventarioProductos.Text = "Inventario";
            this.btnInventarioProductos.UseVisualStyleBackColor = false;
            this.btnInventarioProductos.Click += new System.EventHandler(this.btnInventarioProductos_Click);
            // 
            // btnBarista
            // 
            this.btnBarista.BackColor = System.Drawing.Color.Transparent;
            this.btnBarista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBarista.Location = new System.Drawing.Point(9, 97);
            this.btnBarista.Name = "btnBarista";
            this.btnBarista.Size = new System.Drawing.Size(105, 23);
            this.btnBarista.TabIndex = 2;
            this.btnBarista.Text = "Cocina(Barista)";
            this.btnBarista.UseVisualStyleBackColor = false;
            // 
            // btnSesionFuera
            // 
            this.btnSesionFuera.BackColor = System.Drawing.Color.Transparent;
            this.btnSesionFuera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesionFuera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSesionFuera.Location = new System.Drawing.Point(9, 401);
            this.btnSesionFuera.Name = "btnSesionFuera";
            this.btnSesionFuera.Size = new System.Drawing.Size(105, 23);
            this.btnSesionFuera.TabIndex = 4;
            this.btnSesionFuera.Text = "Cerrar Sesión";
            this.btnSesionFuera.UseVisualStyleBackColor = false;
            this.btnSesionFuera.Click += new System.EventHandler(this.btnSesionFuera_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVenta.Location = new System.Drawing.Point(9, 9);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(105, 23);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Ventas";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnSesionFuera;
        private System.Windows.Forms.Button btnBarista;
        private System.Windows.Forms.Button btnInventarioProductos;
    }
}
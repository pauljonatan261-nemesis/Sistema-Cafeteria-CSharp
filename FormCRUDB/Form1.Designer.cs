namespace FormCRUDB
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnVolverInicioInv = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProducto.Location = new System.Drawing.Point(9, 31);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 18);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecio.Location = new System.Drawing.Point(12, 59);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategoria.Location = new System.Drawing.Point(9, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidad.Location = new System.Drawing.Point(9, 119);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(90, 31);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(159, 20);
            this.txtProducto.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(90, 59);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(90, 89);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(159, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(90, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(12, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(235, 183);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 34);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(442, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(636, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 34);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnVolverInicioInv);
            this.panelTop.Controls.Add(this.lblProducto);
            this.panelTop.Controls.Add(this.btnLimpiar);
            this.panelTop.Controls.Add(this.lblPrecio);
            this.panelTop.Controls.Add(this.btnEliminar);
            this.panelTop.Controls.Add(this.lblCategoria);
            this.panelTop.Controls.Add(this.btnEditar);
            this.panelTop.Controls.Add(this.lblCantidad);
            this.panelTop.Controls.Add(this.btnAgregar);
            this.panelTop.Controls.Add(this.txtPrecio);
            this.panelTop.Controls.Add(this.txtCantidad);
            this.panelTop.Controls.Add(this.txtCategoria);
            this.panelTop.Controls.Add(this.txtProducto);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 450);
            this.panelTop.TabIndex = 13;
            // 
            // btnVolverInicioInv
            // 
            this.btnVolverInicioInv.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverInicioInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverInicioInv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolverInicioInv.Location = new System.Drawing.Point(670, 26);
            this.btnVolverInicioInv.Name = "btnVolverInicioInv";
            this.btnVolverInicioInv.Size = new System.Drawing.Size(102, 23);
            this.btnVolverInicioInv.TabIndex = 13;
            this.btnVolverInicioInv.Text = "Volver al inicio";
            this.btnVolverInicioInv.UseVisualStyleBackColor = false;
            this.btnVolverInicioInv.Click += new System.EventHandler(this.btnVolverInicioInv_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 220);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(800, 230);
            this.dgvProductos.TabIndex = 14;
            this.dgvProductos.CellBorderStyleChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            this.dgvProductos.DataSourceChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVolverInicioInv;
    }
}


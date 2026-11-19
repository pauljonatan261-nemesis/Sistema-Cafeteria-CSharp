namespace FormCRUDB
{
    partial class FormVentas
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
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.btnCatPostres = new System.Windows.Forms.Button();
            this.btnCatTodos = new System.Windows.Forms.Button();
            this.btnCatPanaderia = new System.Windows.Forms.Button();
            this.btnCatCalientes = new System.Windows.Forms.Button();
            this.btnCatFrias = new System.Windows.Forms.Button();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCategorias.SuspendLayout();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategorias
            // 
            this.panelCategorias.Controls.Add(this.btnCatPostres);
            this.panelCategorias.Controls.Add(this.btnCatTodos);
            this.panelCategorias.Controls.Add(this.btnCatPanaderia);
            this.panelCategorias.Controls.Add(this.btnCatCalientes);
            this.panelCategorias.Controls.Add(this.btnCatFrias);
            this.panelCategorias.Location = new System.Drawing.Point(12, 12);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(140, 426);
            this.panelCategorias.TabIndex = 0;
            // 
            // btnCatPostres
            // 
            this.btnCatPostres.Location = new System.Drawing.Point(19, 227);
            this.btnCatPostres.Name = "btnCatPostres";
            this.btnCatPostres.Size = new System.Drawing.Size(75, 23);
            this.btnCatPostres.TabIndex = 5;
            this.btnCatPostres.Text = "Postres";
            this.btnCatPostres.UseVisualStyleBackColor = true;
            this.btnCatPostres.Click += new System.EventHandler(this.btnCatPostres_Click);
            // 
            // btnCatTodos
            // 
            this.btnCatTodos.Location = new System.Drawing.Point(19, 16);
            this.btnCatTodos.Name = "btnCatTodos";
            this.btnCatTodos.Size = new System.Drawing.Size(75, 23);
            this.btnCatTodos.TabIndex = 1;
            this.btnCatTodos.Text = "Todos";
            this.btnCatTodos.UseVisualStyleBackColor = true;
            this.btnCatTodos.Click += new System.EventHandler(this.btnCatTodos_Click);
            // 
            // btnCatPanaderia
            // 
            this.btnCatPanaderia.Location = new System.Drawing.Point(19, 175);
            this.btnCatPanaderia.Name = "btnCatPanaderia";
            this.btnCatPanaderia.Size = new System.Drawing.Size(75, 23);
            this.btnCatPanaderia.TabIndex = 4;
            this.btnCatPanaderia.Text = "Panaderia";
            this.btnCatPanaderia.UseVisualStyleBackColor = true;
            this.btnCatPanaderia.Click += new System.EventHandler(this.btnCatPanaderia_Click);
            // 
            // btnCatCalientes
            // 
            this.btnCatCalientes.Location = new System.Drawing.Point(19, 63);
            this.btnCatCalientes.Name = "btnCatCalientes";
            this.btnCatCalientes.Size = new System.Drawing.Size(96, 23);
            this.btnCatCalientes.TabIndex = 2;
            this.btnCatCalientes.Text = "BebidasCalientes";
            this.btnCatCalientes.UseVisualStyleBackColor = true;
            this.btnCatCalientes.Click += new System.EventHandler(this.btnCatCalientes_Click);
            // 
            // btnCatFrias
            // 
            this.btnCatFrias.Location = new System.Drawing.Point(19, 118);
            this.btnCatFrias.Name = "btnCatFrias";
            this.btnCatFrias.Size = new System.Drawing.Size(83, 23);
            this.btnCatFrias.TabIndex = 3;
            this.btnCatFrias.Text = "BebidasFrias";
            this.btnCatFrias.UseVisualStyleBackColor = true;
            this.btnCatFrias.Click += new System.EventHandler(this.btnCatFrias_Click);
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.cmbMetodoPago);
            this.panelTicket.Controls.Add(this.cmbCliente);
            this.panelTicket.Controls.Add(this.btnEliminarProducto);
            this.panelTicket.Controls.Add(this.btnProcesar);
            this.panelTicket.Controls.Add(this.lblTotal);
            this.panelTicket.Controls.Add(this.dgvTicket);
            this.panelTicket.Location = new System.Drawing.Point(599, 12);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(189, 426);
            this.panelTicket.TabIndex = 6;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(3, 331);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(180, 21);
            this.cmbMetodoPago.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(3, 304);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(180, 21);
            this.cmbCliente.TabIndex = 8;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(0, 387);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(186, 23);
            this.btnEliminarProducto.TabIndex = 6;
            this.btnEliminarProducto.Text = "Eliminar Item";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(0, 358);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(186, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar Item";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(18, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:$0.00";
            // 
            // dgvTicket
            // 
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(6, 63);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(183, 223);
            this.dgvTicket.TabIndex = 0;
            // 
            // flpProductos
            // 
            this.flpProductos.Location = new System.Drawing.Point(20, 16);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Size = new System.Drawing.Size(415, 394);
            this.flpProductos.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpProductos);
            this.panel3.Location = new System.Drawing.Point(158, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 426);
            this.panel3.TabIndex = 7;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.panelCategorias);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panelCategorias.ResumeLayout(false);
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Button btnCatPostres;
        private System.Windows.Forms.Button btnCatTodos;
        private System.Windows.Forms.Button btnCatPanaderia;
        private System.Windows.Forms.Button btnCatCalientes;
        private System.Windows.Forms.Button btnCatFrias;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}
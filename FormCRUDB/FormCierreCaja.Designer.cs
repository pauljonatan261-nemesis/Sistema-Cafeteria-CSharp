namespace FormCRUDB
{
    partial class FormCierreCaja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnConsultarCaja = new System.Windows.Forms.Button();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.dgvHistorialPedidos = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCli = new System.Windows.Forms.Button();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.btnGuardarCli = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCaja);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCaja
            // 
            this.tabCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tabCaja.Controls.Add(this.lblTotalGeneral);
            this.tabCaja.Controls.Add(this.lblTransferencia);
            this.tabCaja.Controls.Add(this.lblTarjeta);
            this.tabCaja.Controls.Add(this.lblEfectivo);
            this.tabCaja.Controls.Add(this.dgvPagos);
            this.tabCaja.Controls.Add(this.btnConsultarCaja);
            this.tabCaja.Controls.Add(this.dtpFechaCaja);
            this.tabCaja.Controls.Add(this.lblFecha);
            this.tabCaja.Location = new System.Drawing.Point(4, 24);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(614, 332);
            this.tabCaja.TabIndex = 0;
            this.tabCaja.Text = "Arqueo y Cierre de Caja";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(12, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de Corte:";
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(107, 11);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(115, 23);
            this.dtpFechaCaja.TabIndex = 1;
            // 
            // btnConsultarCaja
            // 
            this.btnConsultarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnConsultarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarCaja.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCaja.Location = new System.Drawing.Point(232, 9);
            this.btnConsultarCaja.Name = "btnConsultarCaja";
            this.btnConsultarCaja.Size = new System.Drawing.Size(120, 27);
            this.btnConsultarCaja.TabIndex = 2;
            this.btnConsultarCaja.Text = "Consultar Corte";
            this.btnConsultarCaja.UseVisualStyleBackColor = false;
            this.btnConsultarCaja.Click += new System.EventHandler(this.btnConsultarCaja_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(12, 44);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(590, 225);
            this.dgvPagos.TabIndex = 3;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEfectivo.ForeColor = System.Drawing.Color.LightGreen;
            this.lblEfectivo.Location = new System.Drawing.Point(12, 278);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(107, 17);
            this.lblEfectivo.TabIndex = 4;
            this.lblEfectivo.Text = "Efectivo: $0.00";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTarjeta.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTarjeta.Location = new System.Drawing.Point(175, 278);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(100, 17);
            this.lblTarjeta.TabIndex = 5;
            this.lblTarjeta.Text = "Tarjeta: $0.00";
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTransferencia.ForeColor = System.Drawing.Color.Khaki;
            this.lblTransferencia.Location = new System.Drawing.Point(335, 278);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(141, 17);
            this.lblTransferencia.TabIndex = 6;
            this.lblTransferencia.Text = "Transferencia: $0.00";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalGeneral.ForeColor = System.Drawing.Color.White;
            this.lblTotalGeneral.Location = new System.Drawing.Point(12, 303);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(166, 20);
            this.lblTotalGeneral.TabIndex = 7;
            this.lblTotalGeneral.Text = "TOTAL EN CAJA: $0.00";
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tabClientes.Controls.Add(this.lblHistorial);
            this.tabClientes.Controls.Add(this.dgvHistorialPedidos);
            this.tabClientes.Controls.Add(this.btnLimpiarCli);
            this.tabClientes.Controls.Add(this.btnEditarCli);
            this.tabClientes.Controls.Add(this.btnGuardarCli);
            this.tabClientes.Controls.Add(this.txtDireccion);
            this.tabClientes.Controls.Add(this.txtTelefono);
            this.tabClientes.Controls.Add(this.txtApellido);
            this.tabClientes.Controls.Add(this.txtNombre);
            this.tabClientes.Controls.Add(this.lblDir);
            this.tabClientes.Controls.Add(this.lblTel);
            this.tabClientes.Controls.Add(this.lblApe);
            this.tabClientes.Controls.Add(this.lblNom);
            this.tabClientes.Controls.Add(this.dgvClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 24);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(614, 332);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes e Historial de Pedidos";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(10, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.ForeColor = System.Drawing.Color.White;
            this.lblApe.Location = new System.Drawing.Point(205, 12);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(54, 15);
            this.lblApe.TabIndex = 2;
            this.lblApe.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(265, 9);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(10, 42);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 15);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 39);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 23);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.ForeColor = System.Drawing.Color.White;
            this.lblDir.Location = new System.Drawing.Point(205, 42);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(60, 15);
            this.lblDir.TabIndex = 6;
            this.lblDir.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(265, 39);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(120, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // btnGuardarCli
            // 
            this.btnGuardarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCli.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCli.Location = new System.Drawing.Point(10, 70);
            this.btnGuardarCli.Name = "btnGuardarCli";
            this.btnGuardarCli.Size = new System.Drawing.Size(115, 26);
            this.btnGuardarCli.TabIndex = 8;
            this.btnGuardarCli.Text = "Nuevo Cliente";
            this.btnGuardarCli.UseVisualStyleBackColor = false;
            this.btnGuardarCli.Click += new System.EventHandler(this.btnGuardarCli_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCli.ForeColor = System.Drawing.Color.White;
            this.btnEditarCli.Location = new System.Drawing.Point(135, 70);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(115, 26);
            this.btnEditarCli.TabIndex = 9;
            this.btnEditarCli.Text = "Actualizar";
            this.btnEditarCli.UseVisualStyleBackColor = false;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // btnLimpiarCli
            // 
            this.btnLimpiarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLimpiarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCli.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCli.Location = new System.Drawing.Point(260, 70);
            this.btnLimpiarCli.Name = "btnLimpiarCli";
            this.btnLimpiarCli.Size = new System.Drawing.Size(125, 26);
            this.btnLimpiarCli.TabIndex = 10;
            this.btnLimpiarCli.Text = "Limpiar Campos";
            this.btnLimpiarCli.UseVisualStyleBackColor = false;
            this.btnLimpiarCli.Click += new System.EventHandler(this.btnLimpiarCli_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(10, 105);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(375, 215);
            this.dgvClientes.TabIndex = 11;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.White;
            this.lblHistorial.Location = new System.Drawing.Point(395, 12);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(147, 15);
            this.lblHistorial.TabIndex = 12;
            this.lblHistorial.Text = "Pedidos del Cliente (SP):";
            // 
            // dgvHistorialPedidos
            // 
            this.dgvHistorialPedidos.AllowUserToAddRows = false;
            this.dgvHistorialPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPedidos.Location = new System.Drawing.Point(395, 35);
            this.dgvHistorialPedidos.Name = "dgvHistorialPedidos";
            this.dgvHistorialPedidos.ReadOnly = true;
            this.dgvHistorialPedidos.RowHeadersVisible = false;
            this.dgvHistorialPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialPedidos.Size = new System.Drawing.Size(210, 285);
            this.dgvHistorialPedidos.TabIndex = 13;
            // 
            // FormCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 360);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCierreCaja";
            this.Text = "FormCierreCaja";
            this.Load += new System.EventHandler(this.FormCierreCaja_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCaja.ResumeLayout(false);
            this.tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCaja;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.Button btnConsultarCaja;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardarCli;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.Button btnLimpiarCli;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialPedidos;
    }
}
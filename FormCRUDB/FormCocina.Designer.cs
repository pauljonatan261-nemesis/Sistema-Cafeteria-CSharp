namespace FormCRUDB
{
    partial class FormCocina
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(12, 10);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(141, 19);
            this.lblPedidos.TabIndex = 0;
            this.lblPedidos.Text = "Pedidos Pendientes";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(335, 10);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(185, 19);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "Productos a Preparar (Orden)";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 34);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(310, 265);
            this.dgvPedidos.TabIndex = 2;
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.dgvPedidos_SelectionChanged);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(335, 34);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(275, 265);
            this.dgvDetalle.TabIndex = 3;
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntregar.ForeColor = System.Drawing.Color.White;
            this.btnEntregar.Location = new System.Drawing.Point(335, 312);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(165, 35);
            this.btnEntregar.TabIndex = 4;
            this.btnEntregar.Text = "Marcar Entregado";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPedido.Location = new System.Drawing.Point(506, 312);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(104, 35);
            this.btnCancelarPedido.TabIndex = 5;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(12, 312);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(130, 35);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "Actualizar Lista";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FormCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(622, 360);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblPedidos);
            this.Name = "FormCocina";
            this.Text = "FormCocina";
            this.Load += new System.EventHandler(this.FormCocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnRefrescar;
    }
}
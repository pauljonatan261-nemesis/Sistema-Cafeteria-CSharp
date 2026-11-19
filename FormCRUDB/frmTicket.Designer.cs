namespace FormCRUDB
{
    partial class frmTicket
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
            this.pnlBorderTicket = new System.Windows.Forms.Panel();
            this.rtbTicket = new System.Windows.Forms.RichTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBorderTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorderTicket
            // 
            this.pnlBorderTicket.BackColor = System.Drawing.Color.White;
            this.pnlBorderTicket.Controls.Add(this.rtbTicket);
            this.pnlBorderTicket.Location = new System.Drawing.Point(12, 12);
            this.pnlBorderTicket.Name = "pnlBorderTicket";
            this.pnlBorderTicket.Padding = new System.Windows.Forms.Padding(8);
            this.pnlBorderTicket.Size = new System.Drawing.Size(340, 430);
            this.pnlBorderTicket.TabIndex = 0;
            // 
            // rtbTicket
            // 
            this.rtbTicket.BackColor = System.Drawing.Color.White;
            this.rtbTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTicket.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTicket.Location = new System.Drawing.Point(8, 8);
            this.rtbTicket.Name = "rtbTicket";
            this.rtbTicket.ReadOnly = true;
            this.rtbTicket.Size = new System.Drawing.Size(324, 414);
            this.rtbTicket.TabIndex = 0;
            this.rtbTicket.Text = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(12, 465);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Confirmar e imprimir";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(195, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 521);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlBorderTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comprobante de Pago";
            this.pnlBorderTicket.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBorderTicket;
        private System.Windows.Forms.RichTextBox rtbTicket;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
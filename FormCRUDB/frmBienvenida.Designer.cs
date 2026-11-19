namespace FormCRUDB
{
    partial class frmBienvenida
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloSC = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTituloSC
            // 
            this.lblTituloSC.AutoSize = true;
            this.lblTituloSC.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloSC.Location = new System.Drawing.Point(75, 9);
            this.lblTituloSC.Name = "lblTituloSC";
            this.lblTituloSC.Size = new System.Drawing.Size(452, 24);
            this.lblTituloSC.TabIndex = 0;
            this.lblTituloSC.Text = "☕ BIENVENIDO AL SISTEMA DE CAFETERÍA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEstado.Location = new System.Drawing.Point(171, 214);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(224, 16);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Cargando componentes de la base de datos...";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPorcentaje.Location = new System.Drawing.Point(261, 230);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(30, 22);
            this.lblPorcentaje.TabIndex = 2;
            this.lblPorcentaje.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(173, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(222, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            this.timerCarga.Interval = 30;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTituloSC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSC;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerCarga;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                // Incrementar la barra de progreso
                progressBar1.Value += 2;
                lblPorcentaje.Text = progressBar1.Value + "%";

                // Cambiar el mensaje según el avance
                if (progressBar1.Value == 20)
                {
                    lblEstado.Text = "Conectando con SQL Server...";
                }
                else if (progressBar1.Value == 50)
                {
                    lblEstado.Text = "Verificando stock e inventario...";
                }
                else if (progressBar1.Value == 80)
                {
                    lblEstado.Text = "Cargando interfaz del punto de venta...";
                }
            }
            else
            {
                // Detener temporizador
                timerCarga.Stop();

                // Instanciar y abrir la vista principal
                frmPrincipal principal = new frmPrincipal();
                principal.Show();

                // Ocultar la pantalla de bienvenida
                this.Hide();
            }

             }


        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            timerCarga.Start();
        }
    }
}

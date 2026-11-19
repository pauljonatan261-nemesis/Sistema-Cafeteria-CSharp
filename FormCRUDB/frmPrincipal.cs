using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class frmPrincipal : Form
    {
        private Form formularioActivo = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Método genérico para incrustar un formulario dentro del panel central
        private void AbrirFormularioHijo(Form formularioHijo, string titulo)
        {
            // Si ya hay un formulario abierto, se cierra para liberar memoria
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false; // Indica que no es una ventana independiente
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita la barra de título del hijo
            formularioHijo.Dock = DockStyle.Fill; // Lo estira para llenar todo el panel

            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

            lblTituloForm.Text = titulo; // Cambia el título de la barra superior
        }

        // --- EVENTOS DE LOS BOTONES DEL MENÚ LATERAL ---

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // AbrirFormularioHijo(new FormVentas(), "Punto de Venta - Pedidos");
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Carga tu Form1 (el CRUD que acabas de programar)
            AbrirFormularioHijo(new frmProductos(), "Gestión de Productos e Inventario");
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            // AbrirFormularioHijo(new FormCocina(), "Comandos y Pedidos de Barista");
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            // AbrirFormularioHijo(new FormCierreCaja(), "Cierre de Caja y Arqueo");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el dashboard
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de FormVentas y la inserta en el panel central
            AbrirFormularioHijo(new FormVentas(), "Punto de Venta - Registrador de Pedidos");
        }

        private void btnInventarioProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmProductos(), "Gestión de Productos e Inventario");
        }

        private void btnSesionFuera_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el dashboard y vuelve al login
        }
    }
}
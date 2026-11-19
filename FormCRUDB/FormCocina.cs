using System;
using System.Data;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class FormCocina : Form
    {
        public FormCocina()
        {
            InitializeComponent();
        }

        private void FormCocina_Load(object sender, EventArgs e)
        {
            CargarPedidosPendientes();
        }

        private void CargarPedidosPendientes()
        {
            try
            {
                dgvPedidos.SelectionChanged -= dgvPedidos_SelectionChanged;

                DataTable dtPedidos = CocinaDAL.ObtenerPedidosPendientes();
                dgvPedidos.DataSource = dtPedidos;

                if (dgvPedidos.Rows.Count > 0)
                {
                    dgvPedidos.Rows[0].Selected = true;
                    MostrarDetalleSeleccionado();
                }
                else
                {
                    dgvDetalle.DataSource = null;
                    lblDetalle.Text = "Sin pedidos pendientes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos pendientes: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            }
        }

        private void MostrarDetalleSeleccionado()
        {
            if (dgvPedidos.CurrentRow != null && dgvPedidos.CurrentRow.Cells["Pedido #"].Value != null)
            {
                int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Pedido #"].Value);
                lblDetalle.Text = $"Productos a Preparar (Pedido #{idPedido})";
                dgvDetalle.DataSource = CocinaDAL.ObtenerDetallePedido(idPedido);
            }
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            MostrarDetalleSeleccionado();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null || dgvPedidos.CurrentRow.Cells["Pedido #"].Value == null)
            {
                MessageBox.Show("Seleccione un pedido pendiente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Pedido #"].Value);

            if (CocinaDAL.MarcarComoEntregado(idPedido))
            {
                MessageBox.Show($"Pedido #{idPedido} marcado como ENTREGADO.", "Orden Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPedidosPendientes();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null || dgvPedidos.CurrentRow.Cells["Pedido #"].Value == null)
            {
                MessageBox.Show("Seleccione el pedido que desea cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Pedido #"].Value);
            var confirm = MessageBox.Show($"¿Cancelar el Pedido #{idPedido}? Se devolverán los productos al inventario.",
                                          "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    CocinaDAL.CancelarPedido(idPedido);
                    MessageBox.Show($"Pedido #{idPedido} cancelado y stock restaurado.", "Pedido Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPedidosPendientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar pedido: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarPedidosPendientes();
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class FormCierreCaja : Form
    {
        public FormCierreCaja()
        {
            InitializeComponent();
        }

        private void FormCierreCaja_Load(object sender, EventArgs e)
        {
            dtpFechaCaja.Value = DateTime.Now.Date;
            CargarCorteCaja();
            CargarClientes();
        }

        // ==========================================
        // PESTAÑA 1: ARQUEO DE CAJA
        // ==========================================
        private void CargarCorteCaja()
        {
            try
            {
                DataTable dt = CajaClientesDAL.ObtenerPagosPorFecha(dtpFechaCaja.Value);
                dgvPagos.DataSource = dt;

                decimal efectivo = 0, tarjeta = 0, transferencia = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string metodo = row["Método"].ToString().ToLower();
                    decimal monto = Convert.ToDecimal(row["Monto"]);

                    if (metodo.Contains("efectivo")) efectivo += monto;
                    else if (metodo.Contains("tarjeta")) tarjeta += monto;
                    else if (metodo.Contains("transferencia")) transferencia += monto;
                }

                decimal total = efectivo + tarjeta + transferencia;

                lblEfectivo.Text = $"Efectivo: ${efectivo:0.00}";
                lblTarjeta.Text = $"Tarjeta: ${tarjeta:0.00}";
                lblTransferencia.Text = $"Transferencia: ${transferencia:0.00}";
                lblTotalGeneral.Text = $"TOTAL EN CAJA: ${total:0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cierre de caja: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarCaja_Click(object sender, EventArgs e)
        {
            CargarCorteCaja();
        }

        // ==========================================
        // PESTAÑA 2: CLIENTES Y PROCEDIMIENTO SP
        // ==========================================
        private void CargarClientes()
        {
            try
            {
                dgvClientes.SelectionChanged -= dgvClientes_SelectionChanged;
                dgvClientes.DataSource = CajaClientesDAL.ListarClientes();

                if (dgvClientes.Rows.Count > 0)
                {
                    dgvClientes.Rows[0].Selected = true;
                    MostrarDatosYHistorialCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            }
        }

        private void MostrarDatosYHistorialCliente()
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.Cells["ID"].Value != null)
            {
                int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value);

                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["Teléfono"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["Dirección"].Value?.ToString() ?? "";

                // Ejecuta sp_ObtenerPedidosPorCliente
                dgvHistorialPedidos.DataSource = CajaClientesDAL.ObtenerPedidosPorCliente(idCliente);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            MostrarDatosYHistorialCliente();
        }

        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Nombre, Apellido y Teléfono son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CajaClientesDAL.AgregarCliente(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim()))
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                LimpiarCamposCliente();
            }
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null || dgvClientes.CurrentRow.Cells["ID"].Value == null) return;

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value);

            if (CajaClientesDAL.ActualizarCliente(idCliente, txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim()))
            {
                MessageBox.Show("Datos del cliente actualizados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
        }

        private void btnLimpiarCli_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();
        }

        private void LimpiarCamposCliente()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtNombre.Focus();
        }
    }
}
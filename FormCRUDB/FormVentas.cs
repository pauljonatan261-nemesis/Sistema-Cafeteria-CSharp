using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class FormVentas : Form
    {
        private List<Producto> listaProductosBase = new List<Producto>();
        private decimal totalAcumulado = 0.00m;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            ConfigurarGridTicket();
            CargarCombosVenta();
            CargarProductosDesdeBD();
            MostrarBotonesProductos(listaProductosBase);
        }

        private void CargarCombosVenta()
        {
            try
            {
                // Cargar clientes desde CafeteriaDB
                cmbCliente.DataSource = VentaDAL.ObtenerClientes();
                cmbCliente.DisplayMember = "NombreCompleto";
                cmbCliente.ValueMember = "Id_cliente";

                // Cargar métodos de pago disponibles
                cmbMetodoPago.Items.Clear();
                cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
                cmbMetodoPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGridTicket()
        {
            dgvTicket.Columns.Clear();
            dgvTicket.Columns.Add("Id", "ID");
            dgvTicket.Columns.Add("Producto", "Producto");
            dgvTicket.Columns.Add("Precio", "Precio Unit.");
            dgvTicket.Columns.Add("Cantidad", "Cant.");
            dgvTicket.Columns.Add("Subtotal", "Subtotal");

            dgvTicket.Columns["Id"].Visible = false;
            dgvTicket.AllowUserToAddRows = false; // Quita la fila vacía (*) de abajo
            dgvTicket.ReadOnly = true;
            dgvTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarProductosDesdeBD()
        {
            listaProductosBase = ProductoDAL.ObtenerProductos();
        }

        private void MostrarBotonesProductos(List<Producto> productosFiltrados)
        {
            flpProductos.Controls.Clear();

            foreach (var item in productosFiltrados)
            {
                Button btn = new Button
                {
                    Width = 130,
                    Height = 90,
                    Text = $"{item.Nombre}\n${item.Precio:0.00}\n(Stock: {item.Cantidad})",
                    Tag = item,
                    BackColor = item.Cantidad > 0 ? Color.FromArgb(45, 52, 54) : Color.FromArgb(178, 190, 195),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Margin = new Padding(8),
                    Enabled = item.Cantidad > 0
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.Click += BotonProducto_Click;
                flpProductos.Controls.Add(btn);
            }
        }

        private void BotonProducto_Click(object sender, EventArgs e)
        {
            Button btnPresionado = (Button)sender;
            Producto p = (Producto)btnPresionado.Tag;

            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == p.Id)
                {
                    int cantActual = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    if (cantActual + 1 > p.Cantidad)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.", "Límite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["Cantidad"].Value = cantActual + 1;
                    row.Cells["Subtotal"].Value = (cantActual + 1) * p.Precio;
                    CalcularTotal();
                    return;
                }
            }

            dgvTicket.Rows.Add(p.Id, p.Nombre, p.Precio, 1, p.Precio);
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            totalAcumulado = 0;
            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    totalAcumulado += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            lblTotal.Text = $"Total: ${totalAcumulado:0.00}";
        }

        // --- FILTROS DE CATEGORÍA ---

        private void btnCatTodos_Click(object sender, EventArgs e)
        {
            MostrarBotonesProductos(listaProductosBase);
        }

        private void btnCatCalientes_Click(object sender, EventArgs e)
        {
            var filtrados = listaProductosBase.Where(p => p.Categoria.ToLower().Contains("caliente")).ToList();
            MostrarBotonesProductos(filtrados);
        }

        private void btnCatFrias_Click(object sender, EventArgs e)
        {
            var filtrados = listaProductosBase.Where(p => p.Categoria.ToLower().Contains("fría") || p.Categoria.ToLower().Contains("fria")).ToList();
            MostrarBotonesProductos(filtrados);
        }

        private void btnCatPanaderia_Click(object sender, EventArgs e)
        {
            var filtrados = listaProductosBase.Where(p => p.Categoria.ToLower().Contains("reposter") || p.Categoria.ToLower().Contains("panader")).ToList();
            MostrarBotonesProductos(filtrados);
        }

        private void btnCatPostres_Click(object sender, EventArgs e)
        {
            var filtrados = listaProductosBase.Where(p => p.Categoria.ToLower().Contains("snack") || p.Categoria.ToLower().Contains("postre")).ToList();
            MostrarBotonesProductos(filtrados);
        }

        // --- PROCESAR VENTA Y QUITAR ITEM ---

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvTicket.Rows.Count == 0 || (dgvTicket.Rows.Count == 1 && dgvTicket.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay productos seleccionados para generar el ticket.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente antes de procesar la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtVista = new DataTable();
            dtVista.Columns.Add("Id", typeof(int));
            dtVista.Columns.Add("Producto", typeof(string));
            dtVista.Columns.Add("Cantidad", typeof(int));
            dtVista.Columns.Add("Precio", typeof(decimal));
            dtVista.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                if (row.Cells["Producto"].Value != null && !row.IsNewRow)
                {
                    dtVista.Rows.Add(
                        Convert.ToInt32(row.Cells["Id"].Value),
                        row.Cells["Producto"].Value.ToString(),
                        Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Convert.ToDecimal(row.Cells["Precio"].Value),
                        Convert.ToDecimal(row.Cells["Subtotal"].Value)
                    );
                }
            }

            using (frmTicket vistaTicket = new frmTicket(dtVista, totalAcumulado))
            {
                if (vistaTicket.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                        string metodoPago = cmbMetodoPago.Text;

                        int idPedidoGenerado = VentaDAL.RegistrarVentaCompleta(idCliente, dtVista, totalAcumulado, metodoPago);

                        MessageBox.Show($"¡Pedido #{idPedidoGenerado} registrado con éxito!\nInventario actualizado y pago guardado.",
                                        "Venta Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar orden actual y recargar stock de los botones
                        dgvTicket.Rows.Clear();
                        CalcularTotal();
                        CargarProductosDesdeBD();
                        MostrarBotonesProductos(listaProductosBase);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar la venta en SQL Server:\n" + ex.Message,
                                        "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvTicket.CurrentRow != null && !dgvTicket.CurrentRow.IsNewRow)
            {
                DataGridViewRow fila = dgvTicket.CurrentRow;
                int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal precioUnitario = Convert.ToDecimal(fila.Cells["Precio"].Value);

                if (cantidadActual > 1)
                {
                    int nuevaCantidad = cantidadActual - 1;
                    fila.Cells["Cantidad"].Value = nuevaCantidad;
                    fila.Cells["Subtotal"].Value = nuevaCantidad * precioUnitario;
                }
                else
                {
                    dgvTicket.Rows.Remove(fila);
                }

                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

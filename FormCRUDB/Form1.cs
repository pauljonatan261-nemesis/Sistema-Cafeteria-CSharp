using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class Form1 : Form
    {
        // NO agregamos 'private DataGridView dgvProductos;' aquí para evitar conflictos con el Designer

        public Form1()
        {
            InitializeComponent();
            ConfigurarEstructuraTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CargarProductos();
        }

        private void ConfigurarEstructuraTabla()
        {
            if (dgvProductos == null)
            {
                MessageBox.Show("El control dgvProductos es NULL. Verifica la propiedad Name en el Diseñador.", "Atención");
                return;
            }

            // IMPORTANTE: Se quita DockStyle.Fill para evitar que la tabla se meta debajo de los botones
            dgvProductos.Dock = DockStyle.None;

            // Estilos de los Encabezados (Cabecera)
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProductos.ColumnHeadersHeight = 35;
            dgvProductos.ColumnHeadersVisible = true;

            // Color visible para los encabezados
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            // Apariencia general de las celdas
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.BackColor = Color.White;

            // Configuración de comportamiento
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

            // Generación de columnas
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add("Id", "ID");
            dgvProductos.Columns.Add("Nombre", "Producto");
            dgvProductos.Columns.Add("Precio", "Precio ($)");
            dgvProductos.Columns.Add("Categoria", "Categoría");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");

            // Anchos de columna
            dgvProductos.Columns["Id"].Width = 60;
            dgvProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["Precio"].Width = 100;
            dgvProductos.Columns["Categoria"].Width = 140;
            dgvProductos.Columns["Cantidad"].Width = 90;
        }

        public void CargarProductos()
        {
            if (dgvProductos == null) return;

            try
            {
                dgvProductos.SelectionChanged -= dgvProductos_SelectionChanged;
                dgvProductos.Rows.Clear();

                List<Producto> lista = ProductoDAL.ObtenerProductos();

                // Verificación de datos devueltos por la base de datos
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("La consulta SQL no devolvió registros (lista vacía).", "Diagnóstico");
                    return;
                }

                foreach (var p in lista)
                {
                    dgvProductos.Rows.Add(p.Id, p.Nombre, p.Precio.ToString("N2"), p.Categoria, p.Cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            }
        }

        private void LimpiarCampos()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtProducto.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Producto p = new Producto
                {
                    Nombre = txtProducto.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text.Trim()),
                    Categoria = txtCategoria.Text.Trim(),
                    Cantidad = Convert.ToInt32(txtCantidad.Text.Trim())
                };

                if (ProductoDAL.AgregarProducto(p))
                {
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la tabla para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos())
            {
                Producto p = new Producto
                {
                    Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value),
                    Nombre = txtProducto.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text.Trim()),
                    Categoria = txtCategoria.Text.Trim(),
                    Cantidad = Convert.ToInt32(txtCantidad.Text.Trim())
                };

                if (ProductoDAL.ModificarProducto(p))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (ProductoDAL.EliminarProducto(id))
                {
                    MessageBox.Show("Producto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos != null &&
                dgvProductos.CurrentRow != null &&
                dgvProductos.CurrentRow.Cells["Id"].Value != null)
            {
                txtProducto.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value?.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value?.ToString();
                txtCategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value?.ToString();
                txtCantidad.Text = dgvProductos.CurrentRow.Cells["Cantidad"].Value?.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Asegúrese de llenar todos los campos con valores correctos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Precio y Cantidad deben ser números válidos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnVolverInicioInv_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is frmPrincipal principal)
            {
                principal.MostrarPantallaInicio();
            }
        }
    }
   
    }
    
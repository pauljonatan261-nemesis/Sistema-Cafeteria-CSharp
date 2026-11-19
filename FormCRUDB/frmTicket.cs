using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FormCRUDB
{
    public partial class frmTicket : Form
    {
        public frmTicket(DataTable detalleCarrito, decimal totalCobrar)
        {
            InitializeComponent();
            ConstruirVistaTicket(detalleCarrito, totalCobrar);
        }

        private void ConstruirVistaTicket(DataTable detalle, decimal total)
        {
            rtbTicket.Clear();

            // Cálculos simulados para previsualización visual
            decimal subtotalSinIva = total / 1.13m;
            decimal ivaCalculado = total - subtotalSinIva;

            // Encabezado
            rtbTicket.AppendText("======================================\n");
            rtbTicket.SelectionFont = new Font("Consolas", 10, FontStyle.Bold);
            rtbTicket.AppendText("            CAFETERÍA UTEC            \n");
            rtbTicket.SelectionFont = new Font("Consolas", 9.5f, FontStyle.Regular);
            rtbTicket.AppendText("     San Salvador, El Salvador        \n");
            rtbTicket.AppendText("======================================\n");
            rtbTicket.AppendText($"Fecha  : {DateTime.Now:dd/MM/yyyy HH:mm}\n");
            rtbTicket.AppendText($"Orden  : #{new Random().Next(100, 999)}\n");
            rtbTicket.AppendText("--------------------------------------\n");
            rtbTicket.AppendText(string.Format("{0,-5} {1,-14} {2,-7} {3,6}\n", "Cant", "Producto", "Precio", "Subt"));
            rtbTicket.AppendText("--------------------------------------\n");

            // Recorrer filas recibidas desde la interfaz de ventas
            foreach (DataRow fila in detalle.Rows)
            {
                string nombre = fila["Producto"].ToString();
                if (nombre.Length > 13) nombre = nombre.Substring(0, 11) + "..";

                int cant = Convert.ToInt32(fila["Cantidad"]);
                decimal precio = Convert.ToDecimal(fila["Precio"]);
                decimal subtotal = Convert.ToDecimal(fila["Subtotal"]);

                rtbTicket.AppendText(string.Format("{0,-5} {1,-14} ${2,-6:0.00} ${3,5:0.00}\n", cant, nombre, precio, subtotal));
            }

            // Pie del ticket
            rtbTicket.AppendText("--------------------------------------\n");
            rtbTicket.AppendText(string.Format("{0,27} ${1,6:0.00}\n", "Subtotal:", subtotalSinIva));
            rtbTicket.AppendText(string.Format("{0,27} ${1,6:0.00}\n", "IVA (13%):", ivaCalculado));
            rtbTicket.AppendText("======================================\n");

            // Destacar Total
            rtbTicket.AppendText(string.Format("{0,27} ${1,6:0.00}\n", "TOTAL A PAGAR:", total));
            rtbTicket.AppendText("======================================\n\n");
            rtbTicket.AppendText("     ¡GRACIAS POR SU COMPRA!          \n");
            rtbTicket.AppendText("         Vuelva Pronto                \n");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
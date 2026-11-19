using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCRUDB
{
    public class Producto
    {
        // Es fundamental que todos tengan { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
    }
}

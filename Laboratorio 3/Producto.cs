using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Producto
    {
        public Producto(string nombreProducto, double precioProducto)
        {
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
        }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public void MostrarProducto()
        {
            Console.WriteLine($"Nombre: {NombreProducto} / Precio:   {PrecioProducto}");
        }
    }
}

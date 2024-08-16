using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Pedidos
    {
        public Cliente ClientePedido { get; set; }
        public int IdPedido { get; set; }
        public DateTime Tiempo { get; set; }
        public List<Producto> Productos { get; set; }
        public double TotalPedido {  get; set; }
        public Pedidos(Cliente clientePedido, int idPedido, DateTime tiempo, List<Producto> productos)
        {
            ClientePedido = clientePedido;
            Tiempo = tiempo;
            Productos = productos;
            TotalPedido = CalcularTotal();
        }

        public virtual void MostrarInformacionPedido()
        {
            Console.WriteLine($"Pedido ID : {ClientePedido}, Total: {TotalPedido}, {Tiempo} ");
            Console.WriteLine("Lista de productos: ");
            foreach (var producto in Productos)
            {
                producto.MostrarProducto();
            }
        }
        public double CalcularTotal()
        {
            double total = Productos.Sum(p => p.PrecioProducto);
            if (ClientePedido is ClienteVIP vipCliente)
            {
                total -= total * (vipCliente.DescuentoVip );
            }
            else if (ClientePedido is ClienteCorporativo corpCliente)
            {
                total -= total * (corpCliente.DescuentoCorporativo);
            }
            return total;
        }

    }
}

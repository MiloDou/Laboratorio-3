using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class ClienteVIP : Cliente
    {
        public double DescuentoVip { get; set; }

        public ClienteVIP(string nombre, string correo, int direccion) : base(nombre, correo, direccion)
        {
            DescuentoVip = 0.05;
        }
        public override void MostraInformacion()
        {
            base.MostraInformacion();
            Console.WriteLine("Cliente VIP, descuento de 5%\n");
        }
    }
}


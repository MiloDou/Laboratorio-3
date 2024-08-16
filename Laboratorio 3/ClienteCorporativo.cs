using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class ClienteCorporativo:Cliente
    {
        public double DescuentoCorporativo {  get; set; }
        public ClienteCorporativo(string nombre, string correo, int direccion)
        :base(nombre, correo, direccion)
        { 
        DescuentoCorporativo = 0.15;
        }
        public override void MostraInformacion()
        {
            base.MostraInformacion();
            Console.WriteLine($"Cliente Corporativo, descuento de 15%\n");
        }


    }
}

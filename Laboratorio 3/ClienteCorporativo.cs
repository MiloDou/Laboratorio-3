using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class ClienteCorporativo:Cliente
    {
        public double Descuento {  get; set; }
        public ClienteCorporativo(int nombre, string correo, int direccion, double descuento)
        :base(nombre, correo, direccion)
        { 
        Descuento = descuento;
        }

    }
}

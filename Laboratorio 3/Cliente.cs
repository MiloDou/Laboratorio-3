using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Cliente
    {
        public int nombre { get; set; }
        public string correo { get; set; }
        public int direccion { get; set; }
        public Cliente(int nombre, string correo, int direccion)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.direccion = direccion;
        }

    }
}

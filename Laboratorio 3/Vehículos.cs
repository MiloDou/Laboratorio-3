using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Vehículos
    {
        public Vehículos(int nombre, int correo, int direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }

        public int Nombre {  get; set; }
        public int Correo {  get; set; }
        public int Direccion { get; set; }

    }
}

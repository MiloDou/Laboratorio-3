using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public int direccion { get; set; }
        public Cliente(string nombre, string correo, int direccion)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.direccion = direccion;
        }
        public virtual void MostraInformacion()
        {
            Console.WriteLine($"El nombre: {nombre}, El correo: {correo}");
        }

    }
}

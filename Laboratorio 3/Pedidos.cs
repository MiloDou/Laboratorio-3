using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Pedidos
    {
        public int ID { get; set; }
        public DateTime Tiempo { get; set; }
        public string Productos { get; set; }
        public Pedidos(int iD, DateTime tiempo, string productos)
        {
            ID = iD;
            Tiempo = tiempo;
            Productos = productos;
        }
    }
}

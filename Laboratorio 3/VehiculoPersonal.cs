using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class VehiculoPersonal:Vehiculos
    {
        public VehiculoPersonal(int matricula, int modelo, string combustible) : base(matricula, modelo, combustible)
        { }
        public override void MostraInformacion()
        {
            base.MostraInformacion();
            Console.WriteLine("Vehiculo Personal\n");
        }

    }
}

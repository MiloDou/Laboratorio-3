using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Vehiculos
    {
       
        public Vehiculos(int matricula, int modelo, string combustible)
        {
            Matricula = matricula;
            Modelo = modelo;
            Combustible = combustible;
        }

        public int Matricula {  get; set; }
        public int Modelo {  get; set; }
        public string Combustible { get; set; }
        
        public virtual void MostraInformacion()
        {
            Console.WriteLine($"Matrícula del carro: {Matricula}, Modelo: {Modelo}, Tipo de combustible: {Combustible}");
        }

    }
}

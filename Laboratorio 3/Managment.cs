using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Managment
    {
        public List<Cliente> ListaClientes;
        public List<Pedidos> ListaPedidos;
        public List<Vehículos> ListaVehiculos;
        public Managment()
        {
            ListaClientes = new List<Cliente>();
            ListaPedidos = new List<Pedidos>();
            ListaVehiculos = new List<Vehículos>();
        }
        public void AddClient()
        {
            try
            {
                Console.Clear();
                AddClientMenu();
                Console.Write("Elige una opcion: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteRegular NuevoClienteRegular = new ClienteRegular(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteRegular);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteVIP NuevoClienteVIP = new ClienteVIP(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteVIP);
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteCorporativo NuevoClienteCorporativo = new ClienteCorporativo(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteCorporativo);
                        }
                        break;
                    case 4:
                        {
                            Console.ReadKey();
                            Console.WriteLine("\nRegresando al menu...");
                        }
                        break;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void AddClientMenu()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("      AGREGAR CLIENTE");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("3. Cliente Corporativo");
            Console.WriteLine("4. Regresar al menù");
        }
        public void ShowClient()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("     MOSTRAR CLIENTES");
            Console.WriteLine("--------------------------\n");
            if (ListaClientes.Count > 0)
            {
                foreach(var cliente in ListaClientes)
                {
                    cliente.MostraInformacion();
                }
            }
            Console.ReadKey();
        }
        public void AddVehicle()
        {

        }
        


    }
}


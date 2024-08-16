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
        public List<Vehiculos> ListaVehiculos;
        int IdPedido = 001;
        public Managment()
        {
            ListaClientes = new List<Cliente>();
            ListaPedidos = new List<Pedidos>();
            ListaVehiculos = new List<Vehiculos>();
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
                            Console.Clear();
                            Console.WriteLine("CLIENTE REGULAR\n");
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteRegular NuevoClienteRegular = new ClienteRegular(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteRegular);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("CLIENTE VIP\n");
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteVIP NuevoClienteVIP = new ClienteVIP(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteVIP);
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("CLIENTE CORPORATIVO\n");
                            Console.Write("Escriba el nombre: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.Write("Escriba el correo: ");
                            string NuevoCorreo = Console.ReadLine();
                            Console.Write("Escriba la dirección: ");
                            int NuevoDireccion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\nCliente {NuevoNombre} ha sido creado");
                            ClienteCorporativo NuevoClienteCorporativo = new ClienteCorporativo(NuevoNombre, NuevoCorreo, NuevoDireccion);
                            ListaClientes.Add(NuevoClienteCorporativo);
                            Console.ReadKey();
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
        public void AddVehicle()
        {
            Cliente ElQueLoRegistra;
            bool continuar = true;
            while (continuar)
            {
                try
                {
                    AddVehicleMenu();
                    Console.Write("Escriba el correo del usuario: ");
                    string BuscarCorreo = Console.ReadLine();
                    foreach (var BuscarClientes in ListaClientes)
                    {
                        if (BuscarClientes.correo == BuscarCorreo)
                        {
                            ElQueLoRegistra = BuscarClientes;
                        }
                    }
                    Console.Write("Elige una opción: ");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            {
                                try
                                {
                                    Console.Write("Escriba matrícula : ");
                                    int NuevaMatricula = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Escriba modelo: ");
                                    int NuevoModelo = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Escriba tipo de combustible: ");
                                    string NuevoCombustible = Console.ReadLine();
                                    Console.WriteLine($"\n Vehiculo ingresado {NuevaMatricula}");
                                    VehiculoPersonal NuevoVehiculo = new VehiculoPersonal(NuevaMatricula, NuevoModelo, NuevoCombustible);
                                    ListaVehiculos.Add(NuevoVehiculo);

                                }
                                catch (FormatException)
                                {

                                }
                                Console.ReadKey();

                            }
                            break;
                        case 2:
                            {
                                try
                                {
                                    Console.Write("Escriba nombre del corporativo");
                                    string CompararNombre = Console.ReadLine();

                                    if (CompararNombre == CompararNombre)
                                    {
                                        Console.Write("Escriba matrícula : ");
                                        int NuevaMatricula = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Escriba modelo: ");
                                        int NuevoModelo = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Escriba tipo de combustible: ");
                                        string NuevoCombustible = Console.ReadLine();
                                        Console.WriteLine($"\n Vehiculo ingresado {NuevaMatricula}");
                                        VehiculoCorporativo NuevoVehiculoCorp = new VehiculoCorporativo(NuevaMatricula, NuevoModelo, NuevoCombustible);
                                        ListaVehiculos.Add(NuevoVehiculoCorp);
                                    }
                                    else
                                        Console.WriteLine("\nCliente no encontado");


                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            continuar = false;
                            Console.ReadKey(); break;
                    }
                    Console.ReadKey();


                }
                catch (FormatException)
                {

                }
                Console.ReadKey();
            }

        }
        static void AddVehicleMenu()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("      AGREGAR CLIENTE");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("1. Vehiculo Personal");
            Console.WriteLine("2. Vehiculo Corporativo");
            Console.WriteLine("3. Regresar al menù");
        }
        public void ShowClient()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("     MOSTRAR CLIENTES");
            Console.WriteLine("--------------------------\n");
            if (ListaClientes.Count > 0)
            {
                foreach (var cliente in ListaClientes)
                {
                    cliente.MostraInformacion();
                }
            }
            Console.ReadKey();
        }
        public void ShowVehicle()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("     MOSTRAR VEHICULOS");
            Console.WriteLine("--------------------------\n");
            foreach (var VehiculosAMostar in ListaVehiculos)
            {
                VehiculosAMostar.MostraInformacion();
            }
            Console.ReadKey();
        }
        public void ShowPedido()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("     MOSTRAR PEDIDOS");
            Console.WriteLine("--------------------------\n");
            foreach(var PedidosMostar in ListaPedidos)
            {
                PedidosMostar.MostrarInformacionPedido();
            }
            Console.ReadKey();

        }
        public void SearchClient()
        {
            Console.Clear();
            bool nombreEncontrado = false;
            Console.Write("Escriba el nombre a buscar: ");
            string BuscarNombre = Console.ReadLine();
            foreach (var cliente in ListaClientes)
            {
                if (BuscarNombre.ToLower() == cliente.nombre.ToLower())
                {
                    cliente.MostraInformacion();
                    nombreEncontrado = true;
                }
            }
            if (!nombreEncontrado)
            {
                Console.WriteLine("Cliente no encontrado");
            }
            Console.ReadKey();
        }
        public void SearchVehicle()
        {
            Console.Clear();
            bool VehiculoEncontrado = false;
            Console.Write("Escriba la matrícula: ");
            int BuscarMatricula = Convert.ToInt32(Console.ReadLine());
            foreach (var vehiculos in ListaVehiculos)
            {
                if (BuscarMatricula == vehiculos.Matricula) ;
                {
                    vehiculos.MostraInformacion();
                    VehiculoEncontrado = true;
                }

            }
            if (!VehiculoEncontrado)
            {
                Console.WriteLine("Cliente no encontrado");
            }
            Console.ReadKey();
        }
        public void SearchPedido()
        {
            Console.Clear();
            bool Pedido = false;
            int BuscarId = Convert.ToInt32(Console.ReadLine());
            foreach(var BuscandoId in ListaPedidos)
            {
                BuscandoId.MostrarInformacionPedido();
                Pedido = true;
            }
            if (!Pedido) {
                Console.WriteLine("Cliente no encontradods");
            }

        }
        public void AddPedido(List<Cliente> ListaClientes, List<Producto> ListaProducto)
        {
            Console.Clear();
            bool encontrado = false;
            Cliente Comprador = null;
            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("        AGREGAR PEDIDO");
                Console.WriteLine("-----------------------------");
                Console.Write("Escriba el correo del cliente: ");
                string CorreoABuscar = Console.ReadLine();
                foreach (Cliente Clientes in ListaClientes)
                {
                    if (Clientes.correo == CorreoABuscar)
                    {
                        encontrado = true;
                        Comprador = Clientes;
                    }
                }
                if (!encontrado) Console.WriteLine("Cliente no encontrado");

            } while (!encontrado);
            Console.WriteLine("------------------------------");
            Console.WriteLine("      REGISTAR PRODUCTO");
            Console.WriteLine("------------------------------\n");
            Console.Write("Número ID:");
            int NuevoId = Convert.ToInt32(Console.ReadLine());

            Pedidos NuevoPedido = new Pedidos(Comprador, NuevoId, DateTime.Now, ListaProducto);
            ListaPedidos.Add(NuevoPedido);




        }
        public List<Producto> AgregarProductos()
        {
            List<Producto> ListaProducto = new List<Producto>();
            {
                do
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(" AGREGAR PRODUCTO");
                    Console.WriteLine("---------------------\n");
                    Console.Write("Nombre de Producto: ");
                    string NuevoProducto = Console.ReadLine();
                    Console.Write("Precio de Producto: ");
                    double NuevoPrecio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Producto {NuevoProducto}, agregado correctamente\n");
                    Console.Clear();
                    Console.Write("\nDesea agregar otro producto(y/n): ");
                    string option = Console.ReadLine().ToLower().Trim();
                    if (option == "n") { break; }

                } while (true);

            }
            return ListaProducto;
        }
    }

}



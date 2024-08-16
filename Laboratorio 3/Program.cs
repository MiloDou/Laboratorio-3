namespace Laboratorio_3
{
    class principal
    {
  
        static void Main(String[] args)
        {
             List<Producto> Productos = new List<Producto>();
                ;List<Cliente> ListaClientes = new List<Cliente>();
       List<Pedidos> ListaPedidos = new List<Pedidos>();
         List<Vehiculos> ListaVehiculos = new List<Vehiculos>();
        Managment manejo = new Managment();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("      MENU PRINCIPAL");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("1. Agregar Cliente");
                    Console.WriteLine("2. Agregar Vehículos");
                    Console.WriteLine("3. Agregar Pedido");
                    Console.WriteLine("4. Mostar Cliente");
                    Console.WriteLine("5. Mostar Vehículos");
                    Console.WriteLine("6. Mostar Pedidos");
                    Console.WriteLine("7. Buscar Cliente");
                    Console.WriteLine("8. Buscar Vehículo");
                    Console.WriteLine("9. Buscar Pedido");
                    Console.WriteLine("10. Salir");
                    Console.Write("Elige una opción: ");
                    int Option = Convert.ToInt32 (Console.ReadLine());
                    switch (Option)
                    {
                        case 1: 
                            {
                                manejo.AddClient();
                            } break;

                        case 2:
                            {
                                manejo.AddVehicle();

                            } break;
                            
                        case 3:
                            manejo.AddPedido( ListaClientes, Productos);
                            break;

                        case 4:
                            manejo.ShowVehicle();
                            break;

                        case 5:
                            manejo.ShowClient();
                            break;

                        case 6:
                            manejo.ShowPedido();
                            break;

                        case 7:
                            manejo.SearchClient();
                            break;

                        case 8:
                            manejo.SearchVehicle();
                            break;

                        case 9: 
                            manejo.SearchPedido();
                            
                            break;
                        case 10:
                            {
                                Console.WriteLine("Ciao User");
                                Console.ReadKey();

                            }break;
                    }

                }
                catch (Exception )
                {

                }

            }
        }
    }
}
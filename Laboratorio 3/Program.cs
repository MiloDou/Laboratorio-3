namespace Laboratorio_3
{
    class principal
    {
        static void Main(String[] args)
        {
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
                    Console.WriteLine("3. Mostar Cliente");
                    Console.WriteLine("4. Mostar Vehículos");
                    Console.WriteLine("5. Buscar Cliente");
                    Console.WriteLine("6. Buscar Vehículo");
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
                            manejo.ShowClient();
                            break;

                        case 4: break;
                        case 5:
                            manejo.SearchClient();
                            break;

                        case 6:
                            manejo.SearchVehicle();
                            break;
                        case 7: break;
                        case 8: break;
                        case 9: break;
                    }

                }
                catch (Exception )
                {

                }

            }
        }
    }
}
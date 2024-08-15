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
                    
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("      MENU PRINCIPAL");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("1. Agregar Cliente");
                    Console.WriteLine("2. Mostar Cliente");
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
                                manejo.ShowClient();
                            } break;

                        case 3:break;
                        case 4:break;
                        case 5:break;
                        case 6:break;
                    }

                }
                catch (Exception e)
                {

                }

            }
        }
    }
}
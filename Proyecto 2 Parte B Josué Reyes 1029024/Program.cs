using Proyecto_2_Parte_B_Josué_Reyes_1029024;

class Program
{
    static void Main(string[] args)
    {
        Tablero tools = new Tablero();

        int p;
        do
        {
            Console.WriteLine("------Menu Ajedrez------");
            Console.WriteLine("");
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("1. Agregar Piezas");
            Console.WriteLine("2. Agregar Dama");
            Console.WriteLine("3. Movimientos Dama");
            Console.WriteLine("4. Imprimir Tablero");
            Console.WriteLine("5. Salir");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:

                    Console.WriteLine("Ingrese cuantas piezas desea agregar al tablero");
                    int n = int.Parse(Console.ReadLine());
                    int s = 1;
                    for (int i = 0; i < n; i++)
                    {
                        tools.AgregarPieza(s);
                        s++;
                    }
                    break;

                case 2:
                    bool d = tools.DamaExiste();
                    tools.AgregarDama(d);
                   
                    break;

                case 3:
                    tools.MovimientosDama();
                    break;

                case 4:
                    tools.ImprimirMatriz();
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Vuelva pronto");
                    break;
            }
        } while (p != 5);
    }
}
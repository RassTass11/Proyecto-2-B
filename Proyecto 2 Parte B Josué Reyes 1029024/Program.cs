using Proyecto_2_Parte_B_Josué_Reyes_1029024;

class Program
{
    static void Main(string[] args)
    {
        Tablero tools = new Tablero();

        int p;
        do
        {       //menu realizado con un ciclo do while
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
                    int n = int.Parse(Console.ReadLine()); //solicita cuantas piezas desea agregar.
                    int s = 1;
                    for (int i = 0; i < n; i++) //ciclo for para agregar las piezas que solicite el usuario
                    {                           //tomando como parametro la variable n.
                        tools.AgregarPieza(s);
                        s++;
                    }
                    break;

                case 2:
                    bool d = tools.DamaExiste(); //metodo para validar si hay una dama existente antes.
                    tools.AgregarDama(d);        //metodo para crear la dama tomando como parametro el metodo anterior.
                   
                    break;

                case 3:
                    tools.MovimientosDama(); //metodo de la realización e impresión de los movimientos posibles para la dama.
                    break;

                case 4:
                    tools.ImprimirMatriz(); //metodo para imprimir la matriz completa.
                    break;

                default: //opción salir
                    Console.WriteLine("");
                    Console.WriteLine("Vuelva pronto");
                    break;
            }
        } while (p != 5);
    }
}
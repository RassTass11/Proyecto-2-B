using System.Net;

namespace Proyecto_2_Parte_B_Josué_Reyes_1029024;

public class Tablero
{


   public Piezas[,] piezasTab = new Piezas[8, 8];

   //Metodo para crear una nueva pieza.   
   public void AgregarPieza(int n)
   {
      Console.WriteLine($"Ingrese el tipo de la pieza #{n}");
      string Tpieza = Console.ReadLine();

      int color;
      char colorP = 'A'; //valor inicializado, se cambiara posteriormente.
      do
      {

         Console.WriteLine($"Ingrese el color de la pieza #{n}");
         Console.WriteLine("1. Blanco");
         Console.WriteLine("2. Negro");
         color = int.Parse(Console.ReadLine());

      } while (color == 0);

      switch (color)
      {
         case 1:
            colorP = 'B';
            break;

         case 2:
            colorP = 'N';
            break;

         default:
            Console.WriteLine("Color inexistente");
            break;
      }

      Piezas pieza1 = new Piezas(Tpieza, colorP);
      AsignarPosición(pieza1);
   }
   //Metodo para verificar si ya hay una dama en el tablero.
   public bool DamaExiste()
   {
      for (int i = 0; i < piezasTab.GetLength(0); i++) //fila
      {
         for (int j = 0; j < piezasTab.GetLength(1); j++) //columna
         {
            if (piezasTab[i, j] != null && piezasTab[i, j].Tipo != null)
            {
               if (piezasTab[i, j].Tipo == "Dama")
               {
                  return true;
               }
            }
         }
      }
      return false;
   }

   //Metodo para crear una nueva dama.
   public void AgregarDama(bool Dam)
   {
      if (Dam == false)
      {
         int color;
         char colorP = 'A'; //valor inicializado, se cambiara posteriormente.
         do
         {
            Console.WriteLine("Ingrese el color de la dama");
            Console.WriteLine("1. Blanco");
            Console.WriteLine("2. Negro");
            color = int.Parse(Console.ReadLine());
         } while (color == 0);

         switch (color)
         {
            case 1:
               colorP = 'B';
               break;

            case 2:
               colorP = 'N';
               break;

            default:
               Console.WriteLine("Color inexistente");
               break;
         }

         Dama dama1 = new Dama(colorP);
         AsignarPosición(dama1);
      }
      else
      {
         Console.WriteLine("");
         Console.WriteLine("Solo puede existir una dama");
      }
   }



   //Metodo para asginarle una posición a una pieza creada.
   public void AsignarPosición(Piezas pieza)
   {

      int X = 0;
      Console.WriteLine("Ingrese la posición ");
      string posi = Console.ReadLine();

      //Se realiza un bucle en la asignación para poder validar las posiciones.
      while (X == 0)
      {
         string cl = posi[0].ToString();
         char fl = posi[1];

         int col = 0;
         int fil = 0;

         //Transformación de la notación de matriz a notación de tablero.
         switch (cl)
         {
            case "a":
               col = 0;
               break;
            case "b":
               col = 1;
               break;
            case "c":
               col = 2;
               break;
            case "d":
               col = 3;
               break;
            case "e":
               col = 4;
               break;
            case "f":
               col = 5;
               break;
            case "g":
               col = 6;
               break;
            case "h":
               col = 7;
               break;
            default:
               col = 99;
               break;
         }

         switch (fl)
         {
            case '1':
               fil = 7;
               break;
            case '2':
               fil = 6;
               break;
            case '3':
               fil = 5;
               break;
            case '4':
               fil = 4;
               break;
            case '5':
               fil = 3;
               break;
            case '6':
               fil = 2;
               break;
            case '7':
               fil = 1;
               break;
            case '8':
               fil = 0;
               break;
            default:
               fil = 99;
               break;
         }
         //Validación de que la posición deseada este disponible en el tablero utilizando un ciclo while.
         if ((fil >= 0 && fil < 8) && (col >= 0 && col < 8))
         {
            if (piezasTab[fil, col] != null)
            {
               Console.WriteLine("Posición no disponible");
               Console.WriteLine("Ingrese una posición valida");
               posi = Console.ReadLine();
            }
            else
            {
               Console.WriteLine("");
               piezasTab[fil, col] = pieza;
               Console.WriteLine($"Pieza agregada exitosamente en {posi},({fil},{col}): {piezasTab[fil, col].Tipo}");
               X = 1;
            }
         }
         else
         {
            Console.WriteLine("Posición inexistente");
            Console.WriteLine("Ingrese una posición valida");
            posi = Console.ReadLine();
         }
      };
   }

   public void AsignarPosición(Dama dama)
   {
      int X = 0;
      Console.WriteLine("Ingrese la posición ");
      string posi = Console.ReadLine();

      while (X == 0)
      {
         string cl = posi[0].ToString();
         char fl = posi[1];


         int col = 0;
         int fil = 0;
         //Transformación de la notación de matriz a notación de tablero.
         switch (cl)
         {
            case "a":
               col = 0;
               break;
            case "b":
               col = 1;
               break;
            case "c":
               col = 2;
               break;
            case "d":
               col = 3;
               break;
            case "e":
               col = 4;
               break;
            case "f":
               col = 5;
               break;
            case "g":
               col = 6;
               break;
            case "h":
               col = 7;
               break;
            default:
               col = 99;
               break;
         }

         switch (fl)
         {
            case '1':
               fil = 7;
               break;
            case '2':
               fil = 6;
               break;
            case '3':
               fil = 5;
               break;
            case '4':
               fil = 4;
               break;
            case '5':
               fil = 3;
               break;
            case '6':
               fil = 2;
               break;
            case '7':
               fil = 1;
               break;
            case '8':
               fil = 0;
               break;

            default:
               fil = 99;
               break;
         }
         //Validación de que la posición deseada este disponible en el tablero utilizando un ciclo while.
         if ((fil >= 0 && fil < 8) && (col >= 0 && col < 8))
         {
            if (piezasTab[fil, col] != null)
            {
               Console.WriteLine("Posición no disponible");
               Console.WriteLine("Ingrese una posición valida");
               posi = Console.ReadLine();
            }
            else
            {

               Console.WriteLine("");
               piezasTab[fil, col] = dama;
               Console.WriteLine($"Dama agregada exitosamente en {posi},({fil},{col})");
               X = 1;
            }
         }
         else
         {
            Console.WriteLine("Posición inexistente");
            Console.WriteLine("Ingrese una posición valida");
            posi = Console.ReadLine();
         }
      };
   }

   //Metodo para imprimir la matriz
   public void ImprimirMatriz()
   {
      for (int i = 0; i < piezasTab.GetLength(0); i++) //fila
      {
         for (int j = 0; j < piezasTab.GetLength(1); j++) //columna
         {
            if (piezasTab[i, j] == null)
            {
               Console.Write(" ⊠ ");
            }
            else
            {
               Console.Write($"{piezasTab[i, j].Tipo[0]}.{piezasTab[i, j].Color}");
            }
         }
         Console.WriteLine();
      }
   }

   public void ImprMovs(int f, int c, char color)
   {
      char cl = 'a';
      int fl = 0;
      switch (c)
      {
         case 0:
            cl = 'a';
            break;
         case 1:
            cl = 'b';
            break;
         case 2:
            cl = 'c';
            break;
         case 3:
            cl = 'd';
            break;
         case 4:
            cl = 'e';
            break;
         case 5:
            cl = 'f';
            break;
         case 6:
            cl = 'g';
            break;
         case 7:
            cl = 'h';
            break;
      }
      switch (f)
      {
         case 0:
            fl = 8;
            break;
         case 1:
            fl = 7;
            break;
         case 2:
            fl = 6;
            break;
         case 3:
            fl = 5;
            break;
         case 4:
            fl = 4;
            break;
         case 5:
            fl = 3;
            break;
         case 6:
            fl = 2;
            break;
         case 7:
            fl = 1;
            break;
      }
      if ((f >= 0 && f <= 7) && (c >= 0 && c <= 7))
      {
         if (piezasTab[f, c] != null)
         {
            if (piezasTab[f, c].Color != color)
            {

               Console.WriteLine($"{cl}{fl}, Disponible");
            }
            if (piezasTab[f, c].Color == color)
            {
               Console.WriteLine($"{cl}{fl}, {piezasTab[f, c].Tipo}(No Disponible)");
            }
         }
         if (piezasTab[f, c] == null)
         {
            Console.WriteLine($"{cl}{fl}, Disponible");
         }
      }
   }

   public void MovimientosDama()
   {

      for (int f = 0; f < piezasTab.GetLength(0); f++)
      {
         for (int c = 0; c < piezasTab.GetLength(1); c++)
         {
            if ((f >= 0 && f <= 7) && (c >= 0 && c <= 7))
            {
               if (piezasTab[f, c] != null && piezasTab[f, c].Tipo != null)
               {
                  char color = 'A';
                  color = piezasTab[f, c].Color; //Obtención del color de la pieza para compararlo con el color de la dama.
                  if (piezasTab[f, c].Tipo == "Dama")
                  {
                     int f1 = f; //asignación de paramatros para resetear posiciones.
                     int c1 = c;
                     //Izquierda
                     do
                     {
                        c--;
                        ImprMovs(f, c, color);
                     }while (c >= 1 && f <= 6 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //derecha
                     do
                     {
                        c++;
                        ImprMovs(f, c, color);
                     }while (c <= 6 && f >= 0 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //arriba
                     do
                     {
                        f--;
                        ImprMovs(f, c, color);
                     }while (f >= 0 && c <= 6 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //abajo
                     do
                     {
                        f++;
                        ImprMovs(f, c, color);
                     }while (f <= 6 && c >= 0 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //arriba Derecha
                     do
                     {
                        f--;
                        c++;
                        ImprMovs(f, c, color);
                     }while (f >= 0 && c <= 6 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //arriba izquierda
                     do
                     {
                        f--;
                        c--;
                        ImprMovs(f, c, color);
                     }while (f >= 0 && c >= 0 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //abajo Derecha
                     do
                     {
                        f++;
                        c++;
                        ImprMovs(f, c, color);
                     }while (f <= 6 && c <= 6 && piezasTab[f,c]==null);
                     f = f1;
                     c = c1;
                     //abajo izquierda
                     do
                     {
                        f++;
                        c--;
                        ImprMovs(f, c, color);
                     }while (f <= 6 && c >= 0 && piezasTab[f,c]==null);
                  }
               }

            }
         }
      }
   }
}


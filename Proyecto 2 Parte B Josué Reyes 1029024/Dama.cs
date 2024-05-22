namespace Proyecto_2_Parte_B_Josué_Reyes_1029024;
public class Dama : Piezas //creamos la clase dama siendo herencia de la clase piezas.
{
   //heredamos las propiedades de la clase piezas a la clase dama.
   //asignamos el tipo de pieza a dama por defecto.
   public Dama(char Color, string Tipo = "Dama") : base(Tipo, Color) 
   { }                                 



}
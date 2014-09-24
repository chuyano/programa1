/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 23/09/2014
 * Time: 07:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace programa1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int Entero1, Entero2, Entero3; //Declaramos enteros
            string Numero1, Numero2; //Declaramos Strings;
            // Ingresamos el valor 1
            Console.Write("Ingrese un Numero: "); 
            Numero1 = Console.ReadLine();
            // Ingresamos el valor 2
            Console.Write("Ingrese otro: "); 
            Numero2 = Console.ReadLine();
            //Convertimos String a Decimal
            Entero1 = Int32.Parse(Numero1); 
            Entero2 = Int32.Parse(Numero2);
            //Sumamos
            Entero3 = Entero1 + Entero2;
            Console.Write("El resultado de la suma es: {0}", Entero3);
            
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
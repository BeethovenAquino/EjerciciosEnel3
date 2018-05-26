using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosEnel3.Capitulo_12
{
   public class Ejercicios1_2_3_4_5
    {
        public void capitulo12_2()
        {

            int op = 0, n = 0, cant = 0, sum = 0, num = 0;

            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n\n1-Numero par e impar.\n2-Promedio.\n3-Salir.");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ha entrado a la funcion de numeros pares e impares.");
                        Console.WriteLine("Ingrese un numero: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n % 2 == 0)
                        {
                            Console.WriteLine("El numero es par.");
                        }
                        else
                        {
                            Console.WriteLine("El numero es impar");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Ha salido se la funcion de numeros pares e impares");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad de numeros: ");
                        cant = Convert.ToInt16(Console.ReadLine());

                        for (int i = 0; i < cant; ++i)
                        {
                            Console.WriteLine("Ingrese el numero: " + i);
                            num = Convert.ToInt16(Console.ReadLine());
                            sum += num;
                        }
                        Console.WriteLine("El promedio es: " + sum / cant);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Ha salido de la funcion del promedio.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void capitulo12_3()
        {
            Console.WriteLine("Excepciones de arreglos:\n1-IndexOutOfRangeException.\n3-ArgumentException.\n4-ArgumentOutOfRangeException.5-ArrayTypeMismatchException");
        }
    }
}

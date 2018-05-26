using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosEnel3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string n;
            for (; ; )
            {
                Console.WriteLine("Entrega DE EJERCICIOS: ");
                Console.WriteLine("eliga que capitulo usted desea ver: ");
                Console.WriteLine("1- Capitulo 9 ");
                Console.WriteLine("2- Capitulo 12 ");

                n = Console.ReadLine();
                Console.Clear();
                switch (n)
                {
                    case "1":
                        Console.WriteLine("1- Ejercicio 1");
                        Console.WriteLine("2- Ejercicio 3 ");
                        Console.WriteLine("2- Ejercicio 4 ");
                        n = Console.ReadLine();
                        Console.Clear();
                        if (n == "1")
                        {
                            EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4 E = new EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4();
                            E.Capitulo9_1();

                        }
                        else
                            if (n == "2")
                        {
                            EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4 E = new EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4();
                            E.Capitulo9_3();
                        }
                        else
                            if (n == "3")
                        {
                            EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4 E = new EjerciciosEnel3.Capitulo_9.Ejercicios1_3y4();
                            E.Capitulo9_4();
                        }
                        Console.Clear();

                        break;

                    case "2":
                        Console.WriteLine("1- Ejercicio 2");
                        Console.WriteLine("2- Ejercicio 3 ");

                        n = Console.ReadLine();
                        Console.Clear();
                        if (n == "1")
                        {
                            EjerciciosEnel3.Capitulo_12.Ejercicios1_2_3_4_5 E = new EjerciciosEnel3.Capitulo_12.Ejercicios1_2_3_4_5();
                            E.capitulo12_2();

                        }
                        else
                            if (n == "2")
                        {
                            EjerciciosEnel3.Capitulo_12.Ejercicios1_2_3_4_5 E = new EjerciciosEnel3.Capitulo_12.Ejercicios1_2_3_4_5();
                            E.capitulo12_3();
                        }

                        Console.Clear();

                        break;





                }
            }
        }
    }
}

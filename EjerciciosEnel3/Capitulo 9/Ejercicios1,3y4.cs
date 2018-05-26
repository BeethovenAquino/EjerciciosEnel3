using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosEnel3.Capitulo_9
{
    public class Ejercicios1_3y4
    {

        public struct Tienda
        {
            public String NombreProducto;
            public int Codigo;
            public int valor;


        }

        public void Capitulo9_1()
        {
            string codigos, valores, salir;
            ArrayList tienda = new ArrayList();
            Tienda a = new Tienda();
            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite nombre del articulo {0}", x);
                a.NombreProducto = Console.ReadLine();
                Console.WriteLine("Digite valor del articulo {0}", x);
                valores = Console.ReadLine();
                a.valor = Convert.ToInt32(valores);
                Console.WriteLine("Digite Codigo del articulo {0}", x);
                codigos = Console.ReadLine();
                a.Codigo = Convert.ToInt32(codigos);
                tienda.Add(a);
                Console.WriteLine("Si desea salir digite 'salir'");
                salir = Console.ReadLine();
                if (salir == "salir" || salir == "Salir")
                    break;



            }
            foreach (Tienda datos in tienda)
            {
                Console.WriteLine("Nombre: {0} valor: {1} Codigo: {2}", datos.NombreProducto, datos.valor, datos.Codigo);
            }

        }

        public struct CuentaBancaria
        {
            public String TitularDeLaCuenta;
            public int NumeroDeLaCuenta;
            public String NombreDelBanco;
            public String DireccionDelBanco;
            public String CorreoDelTitular;
            public String DireccionTitular;

        }
        public struct Mascota
        {
            public String nombre;
            public String TipoMascota;
            public String FechaDeNacimiento;
            public String color;

        }

        public struct Propietario
        {
            public String Nombre;
            public String Direccion;
            public String telefono;
            public Mascota mascota;
        }

        public void Capitulo9_3()
        {
            Propietario dueno = new Propietario();

            Console.WriteLine("Digite el nombre del propietario ");
            dueno.Nombre = Console.ReadLine();

            Console.WriteLine("Digite la direccion del propietario ");
            dueno.Direccion = Console.ReadLine();

            Console.WriteLine("Digite el telefono del propietario ");
            dueno.telefono = Console.ReadLine();

            Console.WriteLine("Digite el nombre de la mascota ");
            dueno.mascota.nombre = Console.ReadLine();

            Console.WriteLine("Digite el tipo de la mascota ");
            dueno.mascota.TipoMascota = Console.ReadLine();

            Console.WriteLine("Digite la fecha de nacimiento de la mascota ");
            dueno.mascota.FechaDeNacimiento = Console.ReadLine();

            Console.WriteLine("Digite el color de la mascota ");
            dueno.mascota.color = Console.ReadLine();


            Console.WriteLine("Nombre del propietario: {0}\nDireccion del propietario: {1}\nTelefono Del propietario: {2}\nNombre de la mascota: {3}\n" +
                "Tipo de mascota: {4}\nFecha de nacimiento de la mascota: {5}\nColor de la mascota: {6} ", dueno.Nombre, dueno.Direccion, dueno.telefono, dueno.mascota.nombre
                , dueno.mascota.TipoMascota, dueno.mascota.FechaDeNacimiento, dueno.mascota.color);


        }

        enum Neumaticos { TodoTerreno = 1, DeInvierno, DeVerano, DeAllSeason, De4x4, DePerfilAncho, DePerfilBajo };

        private void Capitulo9Programa4()
        {
            string opcion;
            int opciones;
            Neumaticos goma;
            do
            {
                Console.WriteLine("Los tipos van del 1 al 7\nDigite 0 para salir");
                Console.WriteLine("Digite el tipo a saber");
                opcion = Console.ReadLine();
                opciones = Convert.ToInt32(opcion);

                switch (opciones)
                {
                    case 1:
                        {
                            goma = Neumaticos.TodoTerreno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 2:
                        {
                            goma = Neumaticos.DeInvierno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 3:
                        {
                            goma = Neumaticos.DeVerano;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 4:
                        {
                            goma = Neumaticos.DeAllSeason;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 5:
                        {
                            goma = Neumaticos.De4x4;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 6:
                        {
                            goma = Neumaticos.DePerfilAncho;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 7:
                        {
                            goma = Neumaticos.DePerfilBajo;
                            Console.WriteLine("{0}", goma); break;
                        }






                }
            } while (opciones != 0);






        }

        public void Capitulo9_4()
        {
            string opcion;
            int opciones;
            Neumaticos goma;
            do
            {
                Console.WriteLine("Los tipos van del 1 al 7\nDigite 0 para salir");
                Console.WriteLine("Digite el tipo a saber");
                opcion = Console.ReadLine();
                opciones = Convert.ToInt32(opcion);

                switch (opciones)
                {
                    case 1:
                        {
                            goma = Neumaticos.TodoTerreno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 2:
                        {
                            goma = Neumaticos.DeInvierno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 3:
                        {
                            goma = Neumaticos.DeVerano;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 4:
                        {
                            goma = Neumaticos.DeAllSeason;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 5:
                        {
                            goma = Neumaticos.De4x4;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 6:
                        {
                            goma = Neumaticos.DePerfilAncho;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 7:
                        {
                            goma = Neumaticos.DePerfilBajo;
                            Console.WriteLine("{0}", goma); break;
                        }






                }
            } while (opciones != 0);


        }

        enum Estrellas { Aries = 1, Geminis, Tauro, cancer, leo, virgo, libra, escorpion, sagitario, capricornio, acuario, piscis };
    }
}

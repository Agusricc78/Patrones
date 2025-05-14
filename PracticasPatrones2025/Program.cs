using PracticasPatrones2025.Abstract_Factory;
using PracticasPatrones2025.Archivos;
using PracticasPatrones2025.Composite;
using PracticasPatrones2025.FactoryMethod;
using PracticasPatrones2025.Observador;
using PracticasPatrones2025.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComponent = PracticasPatrones2025.Archivos.IComponent;

namespace PracticasPatrones2025
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ConfigurationManager cfer = new ConfigurationManager();

                cfer.Set("nombre", "Juan");
                cfer.keyValuePairs.Add("apellido", "Pérez");

                Singleton.SessionManager.CrearInstancia(cfer);
                Console.WriteLine("Nombre: " + Singleton.SessionManager.GetInstance.cf.get("nombre"));
                Singleton.SessionManager.logout();
            */



            /*   int resultado = 0;




               Console.WriteLine("Seleccionar el patron que desea crear");
               Console.WriteLine("1. Word");
               Console.WriteLine("2. PDF");
               Console.WriteLine("3. Excel");
               Console.WriteLine("4. Salir");
               int input = Convert.ToInt32(Console.ReadLine());

               if (input == 1)
               {
                   IDocument dc;
                   Factory factory = new CreadorDocumento();
                   factory.CrearDocumento("Word");


               }
               else if (input == 2)
               {
                   IDocument df;
                   Factory factory = new CreadorDocumento();
                   factory.CrearDocumento("PDF");

               }
               else if (input == 3)
               {
                   IDocument dg;
                   Factory fc = new CreadorDocumento();
                   fc.CrearDocumento("Excel");

               }


               else
               {
                   Console.WriteLine("Opción no válida");
               }
            */

            /*

              Console.WriteLine("Seleccionar el kit que desee adquirir");
              Console.WriteLine("1. Kit de Oficina");
              Console.WriteLine("2. Kit de Jugador");
              int input = Convert.ToInt32(Console.ReadLine());

              IKit kit;
              IMonitor mon;
              ITeclado tec;

              if (input == 1)
              {
                kit = new KitGamer();

                  mon = kit.CrearMonitor();
                  mon.tipo();
                  tec = kit.CrearTeclado();
                  tec.tipo();
                  kit.render();

              }
              else if(input == 2)
              {
                  kit = new KitOficina();
                  mon = kit.CrearMonitor();
                  mon.tipo();
                  tec = kit.CrearTeclado();
                  tec.tipo();
                  kit.render();

              }
              */
            /*
                IEmpleado root = new Jefe("Root");

                IEmpleado empleado1 = new Empleado("Empleado 1");
                IEmpleado empleado2 = new Empleado("Empleado 2");
                IEmpleado empleado3 = new Empleado("Empleado 3");
                IEmpleado empleado4 = new Empleado("Empleado 4");

                IEmpleado GerenteSistemas = new Jefe("Gerente Sistemas");
                IEmpleado GerenteGeneral = new Jefe("Gerente General");
                IEmpleado GerenteVentas = new Jefe("Gerente Ventas");

                GerenteSistemas.AgregarHijo(empleado1);
                GerenteSistemas.AgregarHijo(empleado2);
                GerenteVentas.AgregarHijo(empleado3);
                GerenteVentas.AgregarHijo(empleado4);
                GerenteGeneral.AgregarHijo(GerenteSistemas);
                GerenteGeneral.AgregarHijo(GerenteVentas);

                root.AgregarHijo(GerenteGeneral);


                Console.WriteLine("Estructura de empleados:" + root.ObtenerCantidadHijos());
                Console.WriteLine("Cantidad de empleados de el gerente general:" + GerenteGeneral.ObtenerCantidadHijos());
                Console.WriteLine("Cantidad de empleados de el gerente de sistemas:" + GerenteSistemas.ObtenerCantidadHijos());

                root.MostrarJerarquia();

                */
            /*
                        IComponent root = new Directorio("Root");

                        IComponent archivo1 = new Directorio("archivo1");
                        IComponent archivo2= new Directorio("archivo2");
                        IComponent archivo3= new Directorio("archivo3");

                        IComponent archivo4 = new Directorio("archivo4");


                        IComponent carpeta1 = new Directorio("carpeta1");
                        IComponent carpeta2 = new Directorio("carpeta2");
                        IComponent carpeta3 = new Directorio("carpeta3");

                        carpeta3.AgregarHijos(archivo1);
                        carpeta2.AgregarHijos(archivo2);
                        carpeta1.AgregarHijos(carpeta2);
                        carpeta1.AgregarHijos(carpeta3);

                       Console.WriteLine("la cantidad de hijos de la carpeta1:"+ carpeta1.ObtenerCantidadHijos());
                        Console.WriteLine("La cantidad de hijos de la carpeta 2 es de :" + carpeta2.ObtenerCantidadHijos());



                        */
            

            Usuario user1 = new Usuario("agustin");
            Usuario user2 = new Usuario("nicolas");
            Usuario user3 = new Usuario("agostina");

            Subasta subaste = new Subasta();

            subaste.agregar(user1);
            subaste.agregar(user2);
            subaste.agregar(user3);


            subaste.Realizaroferta(200, user1);
            subaste.Realizaroferta(300, user2);
            subaste.Realizaroferta(259, user3);

           









            Console.ReadKey();


        }
    }
}

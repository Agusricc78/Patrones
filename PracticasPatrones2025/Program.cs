using PracticasPatrones2025.Abstract_Factory;
using PracticasPatrones2025.Composite;
using PracticasPatrones2025.FactoryMethod;
using PracticasPatrones2025.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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








            Console.ReadKey();


        }
    }
}

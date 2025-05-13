using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Singleton
{
    public class SessionManager
    {

        public static SessionManager instance;

        public ConfigurationManager cf { get; set; }

        public DateTime fechainicio { get; set; }


        public static SessionManager GetInstance {
            get
            {
                if (instance == null) instance = new SessionManager();
                return instance;
            }

        }


        public static void CrearInstancia(ConfigurationManager cfer)
        {
            if(instance == null)
            {
                instance = new SessionManager();
                instance.cf = cfer;
                instance.fechainicio = DateTime.Now;
                Console.WriteLine("Se ha creado una nueva instancia de SessionManager");

            }
            else
            {
                Console.WriteLine("Ya existe una instancia de SessionManager");
            }
        }
        public static void logout()
        {
            if(instance != null)
            {
                instance = null;
                Console.WriteLine("Se ha cerrado la sesión de SessionManager");
            }
            else
            {
                Console.WriteLine("No existe una instancia de SessionManager");
            }
        }



}   }

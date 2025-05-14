using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Observador
{
    public class Usuario : IUsuario
    {

       

        public override string Nombre { get; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public override void actualizar(string nombre, int monto, string item)
        {
            
            Console.WriteLine("El usuario " + nombre + " ha sido notificado de la compra de " + item + " por un monto de " + monto);
        }
    }
}

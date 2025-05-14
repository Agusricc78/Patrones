using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Observador
{
   public abstract class IUsuario
    {
        public abstract string Nombre { get; }
        public abstract void actualizar(string nombre, int monto, string item);



    }
}

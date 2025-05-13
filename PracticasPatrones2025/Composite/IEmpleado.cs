using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Composite
{
   public abstract class IEmpleado
    {
        string nombre;

        public IEmpleado(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
           
        }

        public abstract void AgregarHijo(IEmpleado c);

        public abstract void EliminarHijo(IEmpleado c);

        public abstract IList<IEmpleado> ObtenerHijos();

        public abstract int ObtenerCantidadHijos(); 

        public abstract void MostrarJerarquia(int nivel = 0);   





    }
}

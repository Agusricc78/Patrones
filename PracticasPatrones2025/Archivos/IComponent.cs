using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Archivos
{
    public abstract class IComponent
    {
        List<IComponent> Lista = new List<IComponent>();

        string Nombre;

        public IComponent(string nombre)
        {
            Nombre = nombre;
        }


        public string nombre
        {
            get
            {
                return Nombre;
            }
        }

        public abstract void AgregarHijos(IComponent I);


        public abstract int ObtenerCantidadHijos();

        public abstract IList<IComponent> ObtenerHijos();

        



    }
}

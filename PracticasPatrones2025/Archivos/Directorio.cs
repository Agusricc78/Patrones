using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Archivos
{
    public class Directorio : IComponent
    {
        private List<IComponent> _hijos;
        public Directorio(string nombre) : base(nombre)
        {
           _hijos = new List<IComponent>();

        }

        public override void AgregarHijos(IComponent ic)
        {
            _hijos.Add(ic);
        }

        public override int ObtenerCantidadHijos()
        {
            int res = new int();

            foreach(var hijo in _hijos)
            {
                res++;
            }
            return res;

        }

        public override IList<IComponent> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

       
    }
}

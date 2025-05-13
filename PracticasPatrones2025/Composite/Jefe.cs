using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Composite
{
    public class Jefe : IEmpleado
    {
        private List<IEmpleado> _hijos;


        public Jefe(string nombre) : base(nombre)
        {
            _hijos = new List<IEmpleado>();
        }

        public override void AgregarHijo(IEmpleado c)
        {
           _hijos.Add(c);
        }

        public override void EliminarHijo(IEmpleado c)
        {
            throw new NotImplementedException();
        }

        public override int ObtenerCantidadHijos()
        {
            int res = 0;
            foreach(var hijos in _hijos)
            {
                res++;
            }
            return res;
        }

        public override IList<IEmpleado> ObtenerHijos()
        {
            return _hijos.ToArray();
        }



        public override void MostrarJerarquia(int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + "" + Nombre);
            foreach (var hijo in _hijos)
            {
                hijo.MostrarJerarquia(nivel + 1);
            }
        }




    }
}

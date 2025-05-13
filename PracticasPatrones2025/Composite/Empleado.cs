using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Composite
{
    public class Empleado : IEmpleado
    {
        string _Nombre;
        public Empleado(string nombre) : base(nombre)
        {
            _Nombre = nombre;
        }
        public override void AgregarHijo(IEmpleado c)
        {
            
        }
        public override void EliminarHijo(IEmpleado c)
        {
           
        }

        public override void MostrarJerarquia(int nivel = 0)
        {
           
        }

        public override int ObtenerCantidadHijos()
        {
            return 0;
        }
        public override IList<IEmpleado> ObtenerHijos()
        {
            return null;
        }
    }
}

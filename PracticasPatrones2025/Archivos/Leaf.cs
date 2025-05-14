using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Archivos
{
    public class Leaf : IComponent
    {
        string Nombre;

       public Leaf (string nom) : base(nom)
        {
            Nombre = nom;
        }


        public override void AgregarHijos(IComponent I)
        {
            throw new NotImplementedException();
        }

        public override int ObtenerCantidadHijos()
        {
            throw new NotImplementedException();
        }

        public override IList<IComponent> ObtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}

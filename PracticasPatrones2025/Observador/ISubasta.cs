using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Observador
{
    public abstract class ISubasta
    {

        public abstract void agregar(IUsuario us);
        public abstract void eliminar(IUsuario us);

        public abstract void notificar();
    }
}

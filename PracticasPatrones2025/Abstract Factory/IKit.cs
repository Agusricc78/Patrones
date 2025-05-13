using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Abstract_Factory
{
    public interface IKit 
    {
        IMonitor CrearMonitor();

        ITeclado CrearTeclado();

        string render();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Abstract_Factory
{
    public class KitOficina : IKit
    {
        public IMonitor CrearMonitor()
        {
           return new MonitorOfi();
        }

        public ITeclado CrearTeclado()
        {
            return new TecladoOfi();
        }

        public string render()
        {
            return string.Format("Creando un kit de oficina");
        }
    }
}

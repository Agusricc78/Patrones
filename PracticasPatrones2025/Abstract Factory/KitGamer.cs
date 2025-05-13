using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Abstract_Factory
{
    public class KitGamer : IKit
    {

        public IMonitor CrearMonitor()
        {
            
             MonitorGamer mg =   new MonitorGamer();
             return mg;
        }

        public ITeclado CrearTeclado()
        {
            TecladoGamer tg = new TecladoGamer();
            return tg;
        }

        public string render()
        {
            return string.Format("Creando un kit gamer");
        }


    }
}

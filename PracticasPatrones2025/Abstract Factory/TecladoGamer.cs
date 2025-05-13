using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Abstract_Factory
{
    public class TecladoGamer : ITeclado
    {
        public void tipo()
        {
            Console.WriteLine("Teclado Gamer");
        }
    }
}

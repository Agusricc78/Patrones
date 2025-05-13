using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.FactoryMethod
{
    public class Excel : IDocument
    {
        public void TipoArchivo()
        {
            Console.WriteLine("Excel");
        }
    
    
    }
}

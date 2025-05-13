using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.FactoryMethod
{
    public class PDF : IDocument
    {
        public void TipoArchivo()
        {
            Console.WriteLine("PDF");
        }
    }
    
}

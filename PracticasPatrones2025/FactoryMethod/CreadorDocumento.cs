using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.FactoryMethod
{
    public class CreadorDocumento : Factory
    {

        public override IDocument CrearDocumento(string tipo)
        {
            if (tipo == "Word")
            {
                Word word = new Word();
                word.TipoArchivo();
            }
            else if (tipo == "PDF")
            {
                PDF pdf = new PDF();
                pdf.TipoArchivo();
            }
            else if (tipo == "Excel")
            {
                Excel excel = new Excel();
                excel.TipoArchivo();
            }
            else
            {
                Console.WriteLine("Tipo de documento no soportado");
                
            }
            return null;
        }
    }
}
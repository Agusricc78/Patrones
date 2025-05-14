using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Observador
{
    public class Subasta : ISubasta
    {

        private List<IUsuario> Observadores;



        public Subasta()
        {
            Observadores = new List<IUsuario>();
        }

        public string item { get; set; }

        private int OfertaActual;

        public string ultimofertante { get; set; }



        public int ofertaactual
        {
            get { return OfertaActual; }
            set { OfertaActual = value;
                this.notificar();
            }
        }


        public override void agregar(IUsuario us)
        {
            if (!Observadores.Contains(us))
            {
                Observadores.Add(us);
            }
            else
            {
                Console.WriteLine("El usuario ya se encuentra registrado");
            }
        }

        public override void eliminar(IUsuario us)
        {
            if (Observadores.Contains(us))
            {
                Observadores.Remove(us);
            }
            else
            {
                Console.WriteLine("El usuario no se encuentra registrado");
            }
        }

        public override void notificar()
        {
            foreach(var us in Observadores)
            {
                if(us.Nombre != ultimofertante)
                {
                    us.actualizar(ultimofertante, OfertaActual, item);
                }
                else
                {
                    Console.WriteLine("El usuario " + ultimofertante + " no puede ofertar por el mismo item");
                }
            }
        }

        public void Realizaroferta(int monto, Usuario ofertante)
        {
            if (monto > ofertaactual)
            {
                if (Observadores.Contains(ofertante))
                {
                    ultimofertante = ofertante.Nombre;
                    ofertaactual = monto;
                    Console.WriteLine("El usuario " + ofertante + " ha realizado una oferta de " + monto + " por el item " + item);
                }
                else
                {
                    Console.WriteLine("La oferta es menor a la oferta actual");
                }


            }
        }
    }
}

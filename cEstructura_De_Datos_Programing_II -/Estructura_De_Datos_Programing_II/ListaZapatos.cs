using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos_Programing_II
{
    public class ListaZapatos
    {

        NodoZpatos Head;

        public void Insertar(AñadirZapato AñadirCita)
        {

            NodoZpatos NuevoNodoCita = new NodoZpatos();

            NuevoNodoCita.AñadirZapato = AñadirCita;

            if (Head == null)
            {

                Head = NuevoNodoCita;

            }
            else
            {

                NodoZpatos last = Head;
                while(last.Next != null)
                {

                    last = last.Next;

                }

                last.Next = NuevoNodoCita;

            }
        }

        public void Imprimir()
        {
            NodoZpatos tmp = Head;

            while(tmp != null)
            {

                Console.WriteLine("Los zapatos son de genero " + tmp.AñadirZapato.Genero + "  Su marca es: " + tmp.AñadirZapato.Marca + "  Tienen un precio de: " + tmp.AñadirZapato.Precio + "$" + "Vienen en talla de" + tmp.AñadirZapato.Talla);

                tmp = tmp.Next;

            }


        }

    }
}

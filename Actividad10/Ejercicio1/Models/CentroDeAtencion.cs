using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes=new LinkedList<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();//Salteo la primera linea(cabecera)
            while(!sr.EndOfStream)
            { 
                string linea=sr.ReadLine();
                Solicitud soli=new Solicitud();
                soli.Importar(linea);

                solicitudesEntrantes.AddLast(soli);
            }
            sr.Close();
        }

        public LinkedListNode<Solicitud> GetSolicitudPendiente()
        {
            return solicitudesEntrantes.First;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1.Models
{
    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();//Salteo la primera linea(cabecera)
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Solicitud soli = new Solicitud();
                soli.Importar(linea);

                solicitudesEntrantes.AddLast(soli);
            }
            sr.Close();
        }

        public LinkedListNode<Solicitud> GetSolicitudPendiente()
        {
            return solicitudesEntrantes.First;
        }
        public void Atender(Solicitud solicitud)
        {
            if (solicitudesEntrantes.Remove(solicitud) == true)
            {
                colaDeAtencion.Enqueue(solicitud);
            }
        }

        public string[] VerDescripcionColaAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud sol in colaDeAtencion) 
            {
                descripciones[n++] =sol.ToString();
            }
            return descripciones;
        }
    }
}

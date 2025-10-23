using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Solicitud:IExportable
    {
        public int Numero { get; set; }
        public string Motivo { get; set; }

        public Solicitud()
        {
        }

        public override string ToString()
        {
            return $"{Numero}{Motivo}";
        }
        /// <summary>
        /// Metodo que permite importar datos desde un formato separado con punto y coma
        /// </summary>
        /// <param name="dato">linea a importar</param>
        public void Importar(string dato)
        {
            string[] campos=dato.Split(';');
            Numero=Convert.ToInt32(campos[0]);
            Motivo=campos[1];
        }

        public string Exportar()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public interface IExportable
    {
        public void Importar(string dato);
        public string Exportar();
    }
}

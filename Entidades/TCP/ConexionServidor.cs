﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionServidor<T>
    {
        public string Metodo { get; set; }

        /// <summary>
        /// Propiedad utilizada para enviar la entidad que se debe procesar en el método solicitado por el cliente
        /// La entidad puede ser de cualquier tipo, se debe indicar al momento de crear la instancia de la clase
        /// </summary>
        public T Entidad { get; set; }
    }
}

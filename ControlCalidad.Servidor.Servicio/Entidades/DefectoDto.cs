﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Entidades
{
    public class DefectoDto
    {
        [DataMember]

        public int IdDefecto { get; set; }
        [DataMember]
        public string TipoDefecto { get; set; }
        [DataMember]
        public string Detalle { get; set; }
    }
}

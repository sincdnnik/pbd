using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class HISTORIAL_DE_AVANCE
    {
        public int ID_OS { get; set; }
        public int ID_REGISTRO { get; set; }
        public int ID_ESTADO { get; set; }
        public System.DateTime FECHA_DE_AVANCE { get; set; }
        public virtual ORDEN_DE_SERVICIO ORDEN_DE_SERVICIO { get; set; }
    }
}

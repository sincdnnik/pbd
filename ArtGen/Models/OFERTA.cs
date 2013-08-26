using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class OFERTA
    {
        public int ID_MATERIAL { get; set; }
        public int RUT { get; set; }
        public string UNIDAD_OFERTA { get; set; }
        public int PRECIO_UNIDAD { get; set; }
        public virtual MATERIAL MATERIAL { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}

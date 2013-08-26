using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class PERSONA
    {
        public int RUT { get; set; }
        public string NOMBRE { get; set; }
        public string REGION { get; set; }
        public string CIUDAD { get; set; }
        public string DIRECCION { get; set; }
        public string MAIL { get; set; }
        public int TELEFONO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}

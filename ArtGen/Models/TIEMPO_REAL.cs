using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class TIEMPO_REAL
    {
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public System.DateTime TIEMPO_LLEGADA { get; set; }
        public System.DateTime TIEMPO_SALIDA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class USO_REAL
    {
        public int ID_PRODUCTO { get; set; }
        public int ID_MATERIAL { get; set; }
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int CANTIDAD_CONSUMIDA { get; set; }
        public string UNIDAD { get; set; }
    }
}

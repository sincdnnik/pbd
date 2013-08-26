using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class MATERIAL
    {
        public MATERIAL()
        {
            this.OFERTAs = new List<OFERTA>();
        }

        public int ID_MATERIAL { get; set; }
        public string NOMBRE_MATERIAL { get; set; }
        public string ESPECIFICACION { get; set; }
        public virtual ICollection<OFERTA> OFERTAs { get; set; }
    }
}

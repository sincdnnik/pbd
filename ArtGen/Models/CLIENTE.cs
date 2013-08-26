using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class CLIENTE
    {
        public int RUT { get; set; }
        public string ORGANIZACION { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}

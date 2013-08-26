using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class USUARIO
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string NOMBRE { get; set; }
        public string MAIL { get; set; }
        public string FONO { get; set; }
        public int CARGO { get; set; }
        public bool Recordar { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class AUDITORIA
    {
        public int ID_ENTRADA { get; set; }
        public string NOMBRE_TABLA { get; set; }
        public string OPERACION { get; set; }
        public string INSTRUCCION_SQL { get; set; }
        public System.DateTime FECHA_Y_HORA { get; set; }
        public string DATOS_ANTES { get; set; }
        public string DATOS_DESPUES { get; set; }
        public string USUARIO { get; set; }
    }
}

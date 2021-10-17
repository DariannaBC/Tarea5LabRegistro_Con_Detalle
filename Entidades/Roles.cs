using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5LabRegistro_Con_Detalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public string DescripcionRol { get; set; }
        public bool EsActivo { get; set; }

        [ForeignKey("RolID")]
        public virtual List<RolesDetalle> Detalle { get; set; }

        public Roles()
        {
            RolId = 0;
            DescripcionRol = string.Empty;
            EsActivo = false;

            Detalle = new List<RolesDetalle>();
        }
    }
}


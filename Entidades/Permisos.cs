using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5LabRegistro_Con_Detalle.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisosId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Permisos()
        {
            PermisosId = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
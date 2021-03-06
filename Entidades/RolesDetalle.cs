using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5LabRegistro_Con_Detalle.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisosId { get; set; }
        public bool EsAsignado { get; set; }
        public string Descripcion { get; set; }

        public RolesDetalle()
        {
            Id = 0;
            RolId = 0;
            PermisosId = 0;
            EsAsignado = false;
            Descripcion = "";
        }

        public RolesDetalle(int id, int rolId, int permisoId, bool esAsignado)
        {
            Id = id;
            RolId = rolId;
            PermisosId = permisoId;
            EsAsignado = esAsignado;
        }

        public RolesDetalle(int rolId, int permisoId, bool esAsignado)
        {
            RolId = rolId;
            PermisosId = permisoId;
            EsAsignado = esAsignado;
        }

        public RolesDetalle(int rolId, int permisoId, bool esAsignado, string descripcion)
        {
            RolId = rolId;
            PermisosId = permisoId;
            EsAsignado = esAsignado;
            Descripcion = descripcion;
        }

        public RolesDetalle(int id, int rolId, int permisoId, bool esAsignado, string descripcion)
        {
            Id = id;
            RolId = rolId;
            PermisosId = permisoId;
            EsAsignado = esAsignado;
            Descripcion = descripcion;
        }
    }
}

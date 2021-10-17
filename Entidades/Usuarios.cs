﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5LabRegistro_Con_Detalle.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string DescripcionRol { get; set; }
        public string Alias { get; set; }
        public bool Activo { get; set; }
        public Usuarios()
        {
            RolId = 0;
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Clave = "";
            Nombres = string.Empty;
            Email = string.Empty;
            Activo = false;
        }

        public Usuarios(int rolId, int usuarioId, DateTime fechaIngreso, string alias, string nombres, string email, string clave, bool activo)
        {
            RolId = rolId;
            UsuarioId = usuarioId;
            FechaIngreso = fechaIngreso;
            Alias = alias;
            Nombres = nombres;
            Email = email;
            Clave = clave;
            Activo = activo;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tarea5LabRegistro_Con_Detalle.DAL;
using Tarea5LabRegistro_Con_Detalle.Entidades;

namespace Tarea5LabRegistro_Con_Detalle.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios Usuario)
        {
            if (!Existe(Usuario.UsuarioId))
                return Insertar(Usuario);
            else
                return Modificar(Usuario);
        }
        private static bool Insertar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Add(Usuario) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(Usuario).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Usuarios Usuario = db.Usuarios.Find(id);

                if (Existe(id))
                {
                    db.Usuarios.Remove(Usuario);
                    paso = db.SaveChanges() > 0;
                }

            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios Usuario = new Usuarios();
            try
            {
                Usuario = db.Usuarios.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Usuario;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> Usuario = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                Usuario = db.Usuarios.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Usuario;
        }
        private static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();
            try
            {
                encontrado = db.Usuarios.Any(x => x.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }
    }
}

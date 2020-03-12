using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegundoParcial2.Data;
using SegundoParcial2.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace SegundoParcial2.Controllers
{
    public class TelefonoControllers
    {
        public static bool Guardar (Telefonos telefonos)
        {
            ContextoTelefono contexto = new ContextoTelefono();
            bool paso = false;

            try
            {
                if(contexto.telefonos.Any(A => A.Id == telefonos.Id))
                {
                    paso = Modificar(telefonos);
                }
                else
                {
                    paso = Insertar(telefonos);
                }
                      
            }
            catch( Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

            }

        private static bool Modificar(Telefonos entyti)
        {
            ContextoTelefono contexto = new ContextoTelefono(); 
                bool paso = false;

            try
            {
                contexto.Entry(entyti).State = EntityState.Modified;
                
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Insertar(Telefonos entity)
        {
            ContextoTelefono contexto = new ContextoTelefono();
            bool paso = false;

            try
            {
                contexto.telefonos.Add(entity);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int Id)
        {
            ContextoTelefono contexto = new ContextoTelefono();
            bool paso = false;

            try
            {
                Telefonos telefonos = contexto.telefonos.Find(Id);
                if (telefonos != null)
                {
                    contexto.Entry(telefonos).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }


        public static Telefonos Buscar(int Id)
        {
            ContextoTelefono contexto = new ContextoTelefono();
            Telefonos telefonos;

            try
            {
                telefonos = contexto.telefonos.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return telefonos;
        }

        public static List<Telefonos> GetList(Expression<Func<Telefonos, bool>> expression)
        {
            List<Telefonos> lista = new List<Telefonos>();
            ContextoTelefono   contexto= new ContextoTelefono();

            try
            {
                lista = contexto.telefonos.Where(expression).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegundoParcial2.Data;
using SegundoParcial2.Models;
using System.Linq.Expressions;
using SegundoParcial2.Controllers;

namespace SegundoParcial2.Controllers
{
    public class DetalleControll
    {
        public static List<Telefonos> GetList(Expression<Func<Telefonos, bool>> expression)
        {
            List<Telefonos> lista = new List<Telefonos>();
            ContextoTelefono contexto = new ContextoTelefono();

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


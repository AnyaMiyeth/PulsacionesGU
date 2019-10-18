using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public static class PersonaService
    {
       private static PersonaRepository repositorio  = new PersonaRepository();
       
        public static string Guardar(Persona persona)
        {
            try
            {
                if (repositorio.Buscar(persona.Identificacion) == null)
                {
                    repositorio.Guardar(persona);
                    return ($"Los Datos de la {persona.Nombre} se han guardado Satisfactoriamente");
                }
                else
                {
                    return ($"Lo sentimos, {persona.Nombre} ya se encuentra registrada");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }

        }
        public static string Eliminar(Persona persona)
        {
            try
            {
                if (repositorio.Buscar(persona.Identificacion) == null)
                {
                    repositorio.Guardar(persona);
                    return ($"Los Datos de la {persona.Nombre} se han guardado Satisfactoriamente");
                }
                else
                {
                    return ($"Lo sentimos, {persona.Nombre} ya se encuentra registrada");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }

        }
        public static Persona BuscarxId(string identificacion)
        {

            return repositorio.Buscar(identificacion);
        }
        public static List<Persona> Consultar()
        {
            return repositorio.ConsultarTodos();
        }

        public static Int64 Totalizar()
        {
           return  repositorio.Totalizar();
        }

        public static Int64 TotalizarMujeres()
        {
            return repositorio.TotalizarMujeres();
        }

        public static Int64 TotalizarHombres()
        {
            return repositorio.TotalizarHombres();
        }
    }
}

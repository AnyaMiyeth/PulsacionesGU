using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PersonaRepository
    {
        List<Persona> Personas;
            public  PersonaRepository()
        {
             Personas = new List<Persona>();

        }
          

        public void Guardar(Persona persona)
        {

            Personas.Add(persona);
        }

        public void Eliminar(Persona persona)
        {

            Personas.Remove(persona);
        }

        public List<Persona> ConsultarTodos ()
        {

           return Personas;
        }

        public Persona Buscar(string identificacion )
        {

            return Personas.Find(p => p.Identificacion.Equals(identificacion));
        }

        public Int64 Totalizar() 
        {
            return Personas.Count();
        }

        public Int64 TotalizarMujeres()
        {
            return Personas.Where(p => p.Sexo.Equals( "F")).Count();
        }

        public Int64 TotalizarHombres()
        {
            return Personas.Where(p => p.Sexo.Equals("M")).Count();
        }

    }
}

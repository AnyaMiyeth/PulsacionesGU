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

            foreach (var item in Personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }

            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;

namespace PulsacionesConsolaCapas
{

    class Program
    {

      

        static void Main(string[] args)
        {
            
            ConsoleKeyInfo continuar;
            PersonaService PersonaServicio = new PersonaService();
            do
            {
                Console.Clear();
               
                Persona persona = new Persona();

                
                Console.WriteLine("Digite su Identificacion");
                persona.Identificacion = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite su Nombre");
                persona.Nombre = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite su edad");
                persona.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite su sexo");
                persona.Sexo = Console.ReadLine().ToUpper();

                Console.WriteLine($"su pulsaciones {persona.Pulsaciones}");


                string Mensaje=PersonaServicio.Guardar(persona);

                Console.WriteLine(Mensaje);

                Console.WriteLine("Desea Continuar S/N");
               continuar= Console.ReadKey();


            } while (continuar.KeyChar==('s')|| continuar.KeyChar==('s'));
        }
    }
}

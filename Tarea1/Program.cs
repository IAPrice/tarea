using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Tarea1.Classes;
namespace tarea
{
    class program
    {
        static void Main(string[] args)
        {
            string cont;
            int cont0, cont1, cont2;
            cont0 = cont1 = cont2 = 0;
            bool continuar = true;

            var lista13 = new List<Persona>();
            var lista27 = new List<Persona>();
            var lista100 = new List<Persona>();
            while (continuar)
            {

                var usuario = new Persona();

                System.Console.WriteLine("Ingrese el nombre de la persona: \n");
                usuario.nombre = System.Console.ReadLine();

                System.Console.WriteLine("Ingrese el segundo nombre de la persona: \n");
                usuario.segundo_nombre = System.Console.ReadLine();

                System.Console.WriteLine("Ingrese el apellido de la persona: \n");
                usuario.apellido_paterno = System.Console.ReadLine();

                System.Console.WriteLine("Ingrese el segundo apellido de la persona: \n");
                usuario.apellido_materno = System.Console.ReadLine();

                System.Console.WriteLine("Ingrese la fecha de nacimiento de la persona: \n");
                usuario.fecha_nacimiento = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy", CultureInfo.InvariantCulture);

                System.Console.WriteLine("Ingrese la direccion de la persona: \n");
                usuario.direccion = System.Console.ReadLine();

                System.Console.WriteLine("¿Desea ingresar otro usuario?: Y/N");
                cont = System.Console.ReadLine();

                if (cont == "Y" || cont == "y")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }

                if (usuario.GetEdad() <= 13)
                {

                    lista13.Add(usuario);
                    cont0 += 1;
                }
                if (usuario.GetEdad() > 13 && usuario.GetEdad() <= 27)
                {

                    lista27.Add(usuario);

                    cont1 += 1;

                }
                if (usuario.GetEdad() > 27)
                {

                    lista100.Add(usuario);

                    cont2 += 1;

                }
            }
            using (StreamWriter personas = new StreamWriter("personas.txt"))
            {
                for (int j = 0; j < cont0; j++)
                {

                    if (j == 0)
                    {

                        personas.WriteLine("Personas menores a 13 años: " + lista13[j].nombre + " " + lista13[j].segundo_nombre + " " + lista13[j].apellido_paterno + " " + lista13[j].apellido_materno + " " + lista13[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista13[j].direccion + "\n");
                    }

                    else
                    {
                        personas.WriteLine(lista13[j].nombre + " " + lista13[j].segundo_nombre + " " + lista13[j].apellido_paterno + " " + lista13[j].apellido_materno + " " + lista13[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista13[j].direccion + "\n");
                    }

                }
                for (int j = 0; j < cont1; j++)
                {

                    if (j == 0)
                    {

                        personas.WriteLine("Personas mayores a 13 años: " + lista27[j].nombre + " " + lista27[j].segundo_nombre + " " + lista27[j].apellido_paterno + " " + lista27[j].apellido_materno + " " + lista27[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista27[j].direccion + "\n");
                    }

                    else
                    {
                        personas.WriteLine(lista27[j].nombre + " " + lista27[j].segundo_nombre + " " + lista27[j].apellido_paterno + " " + lista27[j].apellido_materno + " " + lista27[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista27[j].direccion + "\n");
                    }
                }
                for (int j = 0; j < cont2; j++)
                {

                    if (j == 0)
                    {

                        personas.WriteLine("Personas mayores de 27 años: " + lista100[j].nombre + " " + lista100[j].segundo_nombre + " " + lista100[j].apellido_paterno + " " + lista100[j].apellido_materno + " " + lista100[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista100[j].direccion + "\n");
                    }

                    else
                    {
                        personas.WriteLine(lista100[j].nombre + " " + lista100[j].segundo_nombre + " " + lista100[j].apellido_paterno + " " + lista100[j].apellido_materno + " " + lista100[j].fecha_nacimiento.ToString("dd/mm/yyyy") + " " + lista100[j].direccion + "\n");
                    }

                }

            }
        }
    }
    
}

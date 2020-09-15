using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.Classes
{
    public class Persona
    {   
        public string nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public int edad { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string direccion { get; set; }

        public int GetEdad() {
            return (DateTime.Now.Year - this.fecha_nacimiento.Year);
        }
    }
}

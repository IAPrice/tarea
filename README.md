//tarea
//tarea ingreso de personas y clasificación por edad

using System;
using System.IO;
namespace tarea
{
    class program
    {
        static void Main(string[] args)
        {
            string cont;
            int cont0 , cont1 , cont2;
            cont0 = cont1 = cont2 = 0;
            bool continuar = true;

            persona[] lista13 = new persona[1000], lista27 = new persona[1000], lista100 = new persona[1000];
            while (continuar) { 

                persona usuario = new persona();

                System.Console.WriteLine("Ingrese el nombre de la persona: \n");
                usuario.setNombre(System.Console.ReadLine());

                System.Console.WriteLine("Ingrese el segundo nombre de la persona: \n");
                usuario.setS_nombre(System.Console.ReadLine());

                System.Console.WriteLine("Ingrese el apellido de la persona: \n");
                usuario.setApellido(System.Console.ReadLine());

                System.Console.WriteLine("Ingrese el segundo apellido de la persona: \n");
                usuario.setS_apellido(System.Console.ReadLine());

                System.Console.WriteLine("Ingrese la fecha de nacimiento de la persona: \n");
                usuario.setFecha_nacimiento(System.Console.ReadLine());

                System.Console.WriteLine("Ingrese la direccion de la persona: \n");
                usuario.setDireccion(System.Console.ReadLine());

                System.Console.WriteLine("¿Desea ingresar otro usuario?: Y/N");
                cont = System.Console.ReadLine();

                if (cont == "Y" || cont == "y"){
                    continuar = true;
                }
                else{
                    continuar = false;
                }

                if(usuario.getEdad()<=(13*365)){

                    lista13[cont0] = usuario;
                    cont0 = cont0 + 1;
                }
                if(usuario.getEdad()>(13*365) && usuario.getEdad()<=(27*365)){

                    lista27[cont1] = usuario;

                    cont1 = cont1 + 1;

                }
                if(usuario.getEdad()>(27*365)){

                    lista100[cont2] = usuario;

                    cont2 = cont2 + 1;

                }
            }
                using(StreamWriter personas = new StreamWriter("personas.txt"))
                {
                    for(int j = 0 ;j<cont0 ;j++)
                    {

                        if (j == 0){

                            personas.WriteLine("Personas menores a 13 años: " + lista13[j].getNombre() + " " + lista13[j].getS_nombre() + " " + lista13[j].getApellido() + " " + lista13[j].getS_apellido() + " " + lista13[j].getEdad() + " " + lista13[j].getDireccion() + "\n");
                        }

                        else{
                            personas.WriteLine(lista13[j].getNombre() + " " + lista13[j].getS_nombre() + " " + lista13[j].getApellido() + " " + lista13[j].getS_apellido() + " " + lista13[j].getEdad() + " " + lista13[j].getDireccion() + "\n");
                        }

                    }
                    for(int j = 0 ;j<cont1 ;j++)
                    {

                        if (j == 0){

                            personas.WriteLine("Personas mayores a 13 años: " + lista27[j].getNombre() + " " + lista27[j].getS_nombre() + " " + lista27[j].getApellido() + " " + lista27[j].getS_apellido() + " " + lista27[j].getEdad() + " " + lista27[j].getDireccion() + "\n");
                        }

                        else{
                            personas.WriteLine(lista27[j].getNombre() + " " + lista27[j].getS_nombre() + " " + lista27[j].getApellido() + " " + lista27[j].getS_apellido() + " " + lista27[j].getEdad() + " " + lista27[j].getDireccion() + "\n");
                        }
                    }
                    for(int j = 0 ;j<cont2 ;j++)
                    {

                        if (j == 0){

                            personas.WriteLine("Personas mayores a 27 años: " + lista100[j].getNombre() + " " + lista100[j].getS_nombre() + " " + lista100[j].getApellido() + " " + lista100[j].getS_apellido() + " " + lista100[j].getEdad() + " " + lista100[j].getDireccion() + "\n");
                        }

                        else{
                            personas.WriteLine(lista100[j].getNombre() + " " + lista100[j].getS_nombre() + " " + lista100[j].getApellido() + " " + lista100[j].getS_apellido() + " " + lista100[j].getEdad() + " " + lista100[j].getDireccion() + "\n");
                        }

                    }

                 }
        }
    }
    class persona
    {
        public String nombre, s_nombre, apellido, s_apellido, fecha_nacimiento, direccion;
        public int edad;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {

            return this.nombre;
        }
        public void setS_nombre(String s_nombre)
        {
            this.s_nombre = s_nombre;
        }
        public String getS_nombre()
        {
            return this.s_nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public String getApellido()
        {
            return this.apellido;
        }
        public void setS_apellido(String s_apellido)
        {
            this.s_apellido = s_apellido;
        }
        public String getS_apellido()
        {
            return this.s_apellido;
        }
        public void setFecha_nacimiento(String fecha_nacimiento)
        {
            this.fecha_nacimiento = fecha_nacimiento;
            DateTime birth = DateTime.Parse(fecha_nacimiento);
            DateTime actual = new DateTime(2020, 09, 10);
            edad = actual.Subtract(birth).Days;
        }
        public Int32 getEdad()
        {
            return this.edad;
        }
        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return this.direccion;
        }


    }
}

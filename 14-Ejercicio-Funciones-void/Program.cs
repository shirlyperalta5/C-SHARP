using System;

namespace propiedades
{
    class Program
    {

        static void Maid (string[] args)
        {
            Alumno  a = new Alumno("Juan", "Perez");
            Alumno  b = new Alumno("Maria", "Martinez");

            a. inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a. activarAlumno();
            Console.WriteLine("");

       
            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

        }



    }


}
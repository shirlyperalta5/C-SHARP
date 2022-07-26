<<<<<<< HEAD
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


=======
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


>>>>>>> 7dab0a8954bbbba4e09d1a4b5c67048d6f7a5fc0
}
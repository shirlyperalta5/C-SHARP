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


>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1
}
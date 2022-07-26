<<<<<<< HEAD
using System;

namespace propiedades
{
    class Program
    {

        static void Maid (string[] args)
        {
            Alumno  a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno  b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Alumno  c = new Alumno(3);
            c.Id = 3;
            c.PrimerNombre = "Pedro";
            c.SegundoNombre = "Peralta";

            Alumno d = new Alumno("Juan", "Jimenez"); 

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d PrimerNombre + " " + d. SegundoNombre);
            

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
            Alumno  a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno  b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Alumno  c = new Alumno(3);
            c.Id = 3;
            c.PrimerNombre = "Pedro";
            c.SegundoNombre = "Peralta";

            Alumno d = new Alumno("Juan", "Jimenez"); 

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d PrimerNombre + " " + d. SegundoNombre);
            

        }



    }



>>>>>>> 7dab0a8954bbbba4e09d1a4b5c67048d6f7a5fc0
}
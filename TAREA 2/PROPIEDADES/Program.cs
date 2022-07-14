using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "shirly";
            a.SegundoNombre = "camila";
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "emily";
            b.SegundoNombre = "sarai";
            
            Alumno c = new Alumno(3);
            c.PrimerNombre = "rosa";

            Alumno d = new Alumno("Billy", "Feranadez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}

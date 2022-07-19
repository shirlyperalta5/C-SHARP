using System;

namespace propidades
{
 class Program
 {
    static void Main (string[] args)
    {
        alumno a = new alumno();
        a. Id = 1;
        a.PrimerNombre ="Juan";
        a.SegundoNombre ="Perez";

        Alumno b = new alumno(); 
        b. Id = 2;
        b.PrimerNombre ="Maria";
        b.SegundoNombre ="Martinez";

        Alumno c = new alumno(); 
        b. Id = 3;
        b.PrimerNombre ="Pedro";
        b.SegundoNombre ="Peralta";

o
        Console.WriteLine(a.Id);
        Console.WriteLine(b.Id);
        Console.WriteLine(c.Id);

    }
    
 }   

}
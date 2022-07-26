<<<<<<< HEAD
public class Alumno
{
    public  int Id { get; set;}\
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set;}

    public bool Activo { get; set;}

    public Alumno (string primerNombre, string segundoNombre)
    {
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;  
        Activo = true;         
    }

    public string nombreCompleto(){
        if (Activo == true){
        }
            return PrimerNombre + " " + SegundoNombre;
}

    return"Alumno inactivo";
    
public voidd InactivarAlumno(){
    Activo = False;
}
public voidd ActivarAlumno(){
    Activo = true;
}

=======
public class Alumno
{
    public  int Id { get; set;}\
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set;}

    public bool Activo { get; set;}

    public Alumno (string primerNombre, string segundoNombre)
    {
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;  
        Activo = true;         
    }

    public string nombreCompleto(){
        if (Activo == true){
        }
            return PrimerNombre + " " + SegundoNombre;
}

    return"Alumno inactivo";
    
public voidd InactivarAlumno(){
    Activo = False;
}
public voidd ActivarAlumno(){
    Activo = true;
}

>>>>>>> 7dab0a8954bbbba4e09d1a4b5c67048d6f7a5fc0
}
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

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1
}
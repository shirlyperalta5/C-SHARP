public class Cliente: Persona
{
    public int Codigo { get; set;}

    public string Nombre { get; set; }

    public string Telefono {get; set; }

    public Cliente(int codigo, string nombre, strong telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
    }
}
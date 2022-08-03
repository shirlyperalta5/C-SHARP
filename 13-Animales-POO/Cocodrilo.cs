using System;

public class Cocodrilo: Reptil // <- Herencia

{

    public bool EsDomestico { get; set; }



    public Cocodrilo() // <- Polimorfismo

    {

        EsDomestico = false;

    }



    public Cocodrilo(bool esDomestico) // <- Polimorfismo

    {

        EsDomestico = esDomestico;

    }



    public void Gruñir() // <- Abstraccion

    {

        Console.WriteLine("roar roa roar");

    }



    public void Tamano()

    {

        DescribirTamano();

        OtroMetodo();

    }



    private void DescribirTamano() // <- Encapsulamiento

    {

        Console.WriteLine("su tamaño medio es de unos 5 metros");

    }



    private void OtroMetodo() // <- Encapsulamiento

    {



    }

}
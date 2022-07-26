using System;

using System.Collections.Generic;

public class DatosdePrueba

{

    public List<Producto> ListadeProductos { get; set; }

    public List<Cliente> ListadeClientes { get; set; }

    public List<Vendedor> ListadeVendedores { get; set; }

    public List<Orden> ListaOrdenes { get; set; }



    public DatosdePrueba()

    {

        ListadeProductos = new List<Producto>();

        cargarProductos();



        ListadeClientes = new List<Cliente>();

        cargarClientes();



        ListadeVendedores = new List<Vendedor>();

        cargarVendedores();



        ListaOrdenes = new List<Orden>();

    }



    private void cargarProductos()

    {

        Producto p1 = new Producto(1, "Mouse", 250);

        ListadeProductos.Add(p1);



        Producto p2 = new Producto(2, "Teclado", 350);

        ListadeProductos.Add(p2);



        Producto p3 = new Producto(3, "Monitor", 4000);

        ListadeProductos.Add(p3);

<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
        Producto p4 = new Producto(4, "Laptop msi", 17000);
=======


        Producto p4 = new Producto(4, "Laptop msi", 17000);

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
        ListadeProductos.Add(p4);

    }



    private void cargarClientes()

    {

        Cliente c1 = new Cliente(1, "Juan", "77777");

        ListadeClientes.Add(c1);



        Cliente c2 = new Cliente(2, "Pedro", "99999");

        ListadeClientes.Add(c2);

    }



    private void cargarVendedores()

    {

        Vendedor v1 = new Vendedor(1, "Jose", "V001");

        ListadeVendedores.Add(v1);



        Vendedor v2 = new Vendedor(2, "Pablo", "V002");

        ListadeVendedores.Add(v2);

    }


<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
=======

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
    public void ListarProductos()

    {

        Console.Clear();

        Console.WriteLine("Lista de Productos");

        Console.WriteLine("==================");

        Console.WriteLine("");
<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
        Console.WriteLine(" Codigo | Nombre | Precio");
        Console.WriteLine("==========================");
=======

        Console.WriteLine(" Codigo | Nombre | Precio");

        Console.WriteLine("==========================");

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
        Console.WriteLine("");

        

        foreach (var producto in ListadeProductos)

        {

            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);

        }

        Console.WriteLine("");

        Console.Write("Presione la tecla enter para salir.");

        

        Console.ReadLine();

    }



    public void ListarClientes()

    {

        Console.Clear();

        Console.WriteLine("Lista de Clientes");

        Console.WriteLine("=================");

        Console.WriteLine("");
<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
        Console.WriteLine(" Codigo | Nombre | Telefono");
        Console.WriteLine("============================");
=======

        Console.WriteLine(" Codigo | Nombre | Telefono");

        Console.WriteLine("============================");

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
        Console.WriteLine("");

        

        foreach (var cliente in ListadeClientes)

        {

            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);

        }

        Console.WriteLine("");

        Console.Write("Presione la tecla enter para salir.");

        

        Console.ReadLine();

    }



    public void ListarVendedores()

    {

        Console.Clear();

        Console.WriteLine("Lista de Vendedores");

        Console.WriteLine("===================");

        Console.WriteLine("");
<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
        Console.WriteLine(" Codigo | Nombre | Codigo Vendedor");
        Console.WriteLine("============================");
=======

        Console.WriteLine(" Codigo | Nombre | Codigo Vendedor");

        Console.WriteLine("============================");

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
        Console.WriteLine("");

        

        foreach (var vendedor in ListadeVendedores)

        {

            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);

        }

        Console.WriteLine("");

        Console.Write("Presione la tecla enter para salir.");

        

        Console.ReadLine();

    }



    public void CrearOrden()

    {   

        Console.Clear();
<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
=======

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
        Console.WriteLine("Creando Orden");

        Console.WriteLine("=============");

        Console.WriteLine("");



        Console.WriteLine("Ingrese el codigo del cliente: ");

        string codigoCliente = Console.ReadLine();



        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        

        if (cliente == null)

        {

            Console.WriteLine("Cliente no encontrado");

            Console.ReadLine();

            return;

        } else {

            Console.WriteLine("Cliente: " + cliente.Nombre);

            Console.WriteLine("");

        }



        Console.WriteLine("Ingrese el codigo del vendedor: ");

        string codigoVendedor = Console.ReadLine();



        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);

        if (vendedor == null) 

        {

            Console.WriteLine("Vendedor no encontrado");

            Console.ReadLine();

            return;

        } else {

            Console.WriteLine("Vendedor: " + vendedor.Nombre);

            Console.WriteLine("");

        }



        int nuevoCodigo = ListaOrdenes.Count + 1;



        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);

        ListaOrdenes.Add(nuevaOrden);



        while(true)

        {

            Console.WriteLine("Ingrese el producto: ");

            string codigoProducto = Console.ReadLine();

            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        

            if (producto == null)

            {

                Console.WriteLine("Producto no encontrado");

                Console.ReadLine();

            } else {

                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);

                nuevaOrden.AgregarProducto(producto);

            }

<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs


            Console.WriteLine();

            Console.WriteLine("Desea continuar? s/n");

            string continuar = Console.ReadLine();

            if (continuar.ToLower() == "n") {

                break;

            }

        }



        Console.WriteLine("");
        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.SubTotal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.OrdenImpuesto);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();

    }



    public void ListarOrdenes()

    {

        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine(" Codigo | Fecha | | SubTotal | Impuestos | Total");
        Console.WriteLine("=================================================");
        Console.WriteLine("");  



        foreach (var orden in ListaOrdenes)

        {

            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.SubTotal + " | " + orden.OrdenImpuesto + " | " + orden.Total);
            Console.WriteLine();
            Console.WriteLine("Cliente | Vendedor");
            Console.WriteLine("==================");
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            Console.WriteLine("");  

            

            foreach (var detalle in orden.ListaOrdenDetalle)

            {

                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);

            }
=======

>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs

        

            Console.WriteLine();

<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
            

        } 
=======
            Console.WriteLine("Desea continuar? s/n");

            string continuar = Console.ReadLine();

            if (continuar.ToLower() == "n") {

                break;

            }

        }



        Console.WriteLine("");

        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.SubTotal);

        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.OrdenImpuesto);

        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);

        Console.WriteLine("");

        Console.Write("Presione la tecla enter para salir.");
>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs



        Console.Write("Presione la tecla enter para salir.");

        Console.ReadLine();

    }

<<<<<<< HEAD:10-Ordenes/DatosdePrueba.cs
}
Footer
=======


    public void ListarOrdenes()

    {

        Console.Clear();

        Console.WriteLine("Lista de Ordenes");

        Console.WriteLine("================");

        Console.WriteLine("");  

        Console.WriteLine(" Codigo | Fecha | | SubTotal | Impuestos | Total");

        Console.WriteLine("=================================================");

        Console.WriteLine("");  



        foreach (var orden in ListaOrdenes)

        {

            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.SubTotal + " | " + orden.OrdenImpuesto + " | " + orden.Total);

            Console.WriteLine();

            Console.WriteLine("Cliente | Vendedor");

            Console.WriteLine("==================");

            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);

            Console.WriteLine("");  

            

            foreach (var detalle in orden.ListaOrdenDetalle)

            {

                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);

            }

        

            Console.WriteLine();

            

        } 



        Console.Write("Presione la tecla enter para salir.");

        Console.ReadLine();

    }

}
>>>>>>> 3834615de50cd7e0c2ee2f83a42d292d8014e8c1:10-Ordenes/ordenes-tarea/DatosdePrueba.cs
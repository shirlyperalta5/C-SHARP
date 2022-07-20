using System;
using System.Collections.Generic;

public class Inventario
{
      public List<Producto> ListadeProductos { get, set,} 
       
      public inventario()
        {
          ListadeProductos = new List<Producto>();
          Producto a = new Producto ("001","iPhoneX", "0");
          Producto b = new Producto ("002", "Laptop Dell", "5");
          Producto c = new Producto ("003", "Monitor Samsung", "2");
          Producto d = new Producto ("004", "Mouse", "100");
          Producto e = new Producto ("005", "Headset", "25" );

          ListadeProductos.Add (a);
          ListadeProductos.Add (b);
          ListadeProductos.Add (c);
          ListadeProductos.Add (d);
          ListadeProductos.Add (e);
          
        }
	      
    	  0 references
        public void listarProductos(){
          	Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**********************");
            Console.WriteLine("Listado de Productos");
	     	    Console.WriteLine("*********************");
	        	Console.WriteLine("Codigo, Descripcion y Existencia");
        }

            foreach (var producto in ListadeProductos)
            {
                Console.WriteLine(productos.Codigo + " | " + producto.Descripcion + " | " + productos.Existencia.ToString());
 
            }
        
          	Console.ReadLine();

        	0 reference
	       	private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) 
           	 for (int i = 0; i < 5; i++)
          	 {
               if (productos[i, 0] == codigo)
                {
                if (tipoMovimiento == "+") {
                productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                 } else {
                  productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                }
             }

            foreach( producto in ListadeProductos)
         {
              if (productos.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                producto.Existencia = producto.Existencia + cantidad;
                 } else {
                  producto.Existencia = producto.Existencia + cantidad;
                 }
            }
      }


        public void ingresoDeInventario() {
           	string codigo = "";
            string cantidad = "";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ingreso de Productos al Inventario");
           	Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

          }


        static void SalidaDeInventario() {
           	string codigo = "";
            string cantidad = "";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Salida de Productos al Inventario");
           	Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            }

            private void movimientoInventario(codigo, Int32.Parse(cantidad), "+");

    	0 references
         	static void main (string[] arg)
        	{
           	string opción = 0;

          }
}

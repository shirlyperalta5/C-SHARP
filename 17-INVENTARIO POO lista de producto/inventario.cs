<<<<<<< HEAD
using System;

public class Inventario
{
       public List<Producto> ListadeProductos { get, set,} 
       
         {
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
	       		
   	    };
        public inventario()
        {
        }
    	    0 references
            public void listarProductos() {
          	Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**********************");
            Console.WriteLine("Listado de Productos");
	     	Console.WriteLine("*********************");
	     	Console.WriteLine("Codigo, Descripcion y Existencia)";

    for (int i = o; i < 5; i ++)
            Console.WriteLine(productos[i,0] + " | " + productos[i,i] + " | " + productos);[i,2]);
   	        }
        	Console.ReadLine();
        }
         	0 reference
	       	static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
         	 for (int i = 0; i < 5; i++)
          	 {
               if (productos[i, 0] == codigo) {
                if (tipoMovimiento == "+") {
                productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                 } else {
                  productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
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





=======
using System;

public class Inventario
{
       public List<Producto> ListadeProductos { get, set,} 
       
         {
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
	       		
   	    };
        public inventario()
        {
        }
    	    0 references
            public void listarProductos() {
          	Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**********************");
            Console.WriteLine("Listado de Productos");
	     	Console.WriteLine("*********************");
	     	Console.WriteLine("Codigo, Descripcion y Existencia)";

    for (int i = o; i < 5; i ++)
            Console.WriteLine(productos[i,0] + " | " + productos[i,i] + " | " + productos);[i,2]);
   	        }
        	Console.ReadLine();
        }
         	0 reference
	       	static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
         	 for (int i = 0; i < 5; i++)
          	 {
               if (productos[i, 0] == codigo) {
                if (tipoMovimiento == "+") {
                productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                 } else {
                  productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
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





>>>>>>> 7dab0a8954bbbba4e09d1a4b5c67048d6f7a5fc0
}
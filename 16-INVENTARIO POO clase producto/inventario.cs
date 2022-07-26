<<<<<<< HEAD
using System;

public class Inventario
{
        string[,]productos = new string [5,3];
	    {
   		{ "001","iPhoneX", "0" },                            
   		{ "002", "Laptop Dell", "5" },	
       	{" 003", "Monitor Samsung", "2" },	
      	{" 004", "Mouse", "100" },
   		{" 005", "Headset", "25" },	
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
        string[,]productos = new string [5,3];
	    {
   		{ "001","iPhoneX", "0" },                            
   		{ "002", "Laptop Dell", "5" },	
       	{" 003", "Monitor Samsung", "2" },	
      	{" 004", "Mouse", "100" },
   		{" 005", "Headset", "25" },	
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
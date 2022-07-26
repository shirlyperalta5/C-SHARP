<<<<<<< HEAD
﻿using System;
	namespace inventario
{
  	    0 references
	  	class Program

		static void Main (string[]args)
		{
			string opcion = "";
			Inventario inventario = new Inventario();

           	while(true)
	{
            Console.Clear();
            Console.WriteLine("Sistema de Inventario");
            Console.WriteLine("**********************");
            Console.WriteLine("");
	        Console.WriteLine("1") ("Productos");
	        Console.WriteLine("2") ("Ingreso de Inventario");
	        Console.WriteLine("3") ("Salida de Inventario");
	        Console.WriteLine("0") ("Salir");
	        Opción = Console.ReadLine();

	    switch (option)
              {
	 Case "1": {
		inventario.listarProduductos();
        Console.ReadLine();
		break;
   }
	Case "2":
		inventario.ingresoDeInventario();
        break;
		default:
		break;
            		 }
    Case "3":
		SalidaDeInventario();
        break;
		default:
		break;
            		 }

	
        Console.Readline();

	  if (opcion == "0") {
	      break;
    		    }
	            
            }            
        }
    }
}
			
=======
﻿using System;
	namespace inventario
{
  	    0 references
	  	class Program

		static void Main (string[]args)
		{
			string opcion = "";
			Inventario inventario = new Inventario();

           	while(true)
	{
            Console.Clear();
            Console.WriteLine("Sistema de Inventario");
            Console.WriteLine("**********************");
            Console.WriteLine("");
	        Console.WriteLine("1") ("Productos");
	        Console.WriteLine("2") ("Ingreso de Inventario");
	        Console.WriteLine("3") ("Salida de Inventario");
	        Console.WriteLine("0") ("Salir");
	        Opción = Console.ReadLine();

	    switch (option)
              {
	 Case "1": {
		inventario.listarProduductos();
        Console.ReadLine();
		break;
   }
	Case "2":
		inventario.ingresoDeInventario();
        break;
		default:
		break;
            		 }
    Case "3":
		SalidaDeInventario();
        break;
		default:
		break;
            		 }

	
        Console.Readline();

	  if (opcion == "0") {
	      break;
    		    }
	            
            }            
        }
    }
}
			
>>>>>>> 7dab0a8954bbbba4e09d1a4b5c67048d6f7a5fc0

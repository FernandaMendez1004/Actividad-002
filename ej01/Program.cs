Console.WriteLine("Sistema de Gestion de Productos");
List <string> productos = new List<string>();
int opcion;
bool correcto = false;

do
{
    Console.WriteLine(@"1. Agregar un producto
2. Mostrar todos los productos registrados
3. Buscar un producto por su nombre
4. Modificar el nombre de un producto existente
5. Elminar un producto
6. Mostrar la cantidad total de productos registrados
7. Salir del programa
    Ingrese una opcion");

    correcto = int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine(@"Agregar estudiante
Ingrese el nombre del producto");
            string nproducto = Console.ReadLine();
            productos.Add(nproducto);
            Console.WriteLine("Producto agregado");
            Console.WriteLine("ENTER para continuar...");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine(@"Mostrar todos los productos registrados
Productos registrados");
            if (productos.Count == 0)
            {
                Console.WriteLine("Aun no se han registrado productos");
            }
            else
            { int contador = 1;
                foreach (string prodducto in productos)
                {
                    Console.WriteLine($"{contador}- {productos}");
                }
            }        
            break;
        case 3:
            Console.WriteLine(@"Buscar un producto por su nombre
Ingrese el nombre del producto");
            string buscar = Console.ReadLine();
            if (productos.Contains(buscar))
            {
                Console.WriteLine(@$"Producto en existenciA
                se encuentra en la posicion {productos.IndexOf(buscar)}");
            }
            else { Console.WriteLine("Producto no encontrado"); }
            break;
        case 4:
            Console.WriteLine(@"Modificar el nombre de un producto existente
Ingrese el nombre a modificar");
            string modificar = Console.ReadLine();
            if (productos.Contains(modificar))
            { int posicion = productos.IndexOf(modificar);
                Console.WriteLine("Ingrese el nuevo nombre");
                productos[posicion] = Console.ReadLine();
                Console.WriteLine("Actualizado");
            }
            else { Console.WriteLine("Producto no encontrado"); }
            break;
        case 5:
            Console.WriteLine(@"");
            break;
        case 6:
           
            break;
        case 7:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion no encontrada ingrese un numero del 1 al 7");
            break;
    }

}
while (opcion != 7);
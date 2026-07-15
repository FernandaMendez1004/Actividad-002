Console.WriteLine("Hello, World!");
List <string> ciudades = new List<string>();
int opcion;
bool correcto = false;
do
{
    Console.WriteLine("Ingrese una opcion correcta");
    correcto = int.TryParse(Console.ReadLine(), out opcion);
    
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre de una ciudad");
            string nciudad = Console.ReadLine();
            ciudades.Add(nciudad);
            Console.WriteLine("Nombre de la ciudad agregada");
            break;

        case 2:
            Console.WriteLine("Mostrar ciudades agregadas");
            if (ciudades.Count == 0)
            { Console.WriteLine("No hay ciudades agregadas"); }
            else
            { int contador = 1;
                foreach (string ciudad in ciudades)
                {
                    Console.WriteLine($"{contador}- {ciudad}");
                    contador++;
                }
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el nombre de la ciudad a buscar");
            string buscar = Console.ReadLine();
            if (ciudades.Contains(buscar))
            { Console.WriteLine("la ciudad existe");
                Console.WriteLine($"Possicion {ciudades.IndexOf(buscar)}");
            }
            else
            { Console.WriteLine("La ciudad no existe"); }
            break;
} while (opcion != 7); 
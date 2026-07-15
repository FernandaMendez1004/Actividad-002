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
            Console.WriteLine(@"Ingrese el nombre de una ciudad");
            string nciudad = Console.ReadLine();
            ciudades.Add(nciudad);
            Console.WriteLine("Nombre de la ciudad agregada");


} while (opcion != 7); 
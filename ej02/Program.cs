Console.WriteLine("Ejercicio 2 Sistema de gestion de cursos");
List<string> cursos = new List<string>();
int opcion;
bool correcto = false;
do
{
    Console.Clear();
    Console.WriteLine(@"1.Registrar un curso.
2.Mostrar todos los cursos registrados.
3.Buscar un curso por su nombre.
4.Cambiar el nombre de un curso.
5.Eliminar un curso.
6.Mostrar el total de cursos registrados.
7.Salir del programa.
        Ingrese una opcion");
    correcto = int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine(@"Registrar un curso 
Ingrese el nombre del curso ");
            string ncurso = Console.ReadLine();
            cursos.Add(ncurso);
            Console.WriteLine("Curso agregado correctamente");
            break;

        case 2:
            Console.WriteLine(@"Mostrar todos los cursos registrados
Cursos registrados");
            if (cursos.Count == 0)
            {  Console.WriteLine( "No existe el curso");
             }
            else { int contador = 1;
            foreach (string curso in cursos)
                { Console.WriteLine($"{contador}- {curso}");
                    contador++;
                }
            }break;
        case 3:
            Console.WriteLine(@"Buscar un curso por su nombre
Ingrese el nombre a buscar");
            string buscar = Console.ReadLine();
            if (cursos.Contains(buscar))
            {
                Console.WriteLine(@$"Curso en existencia
                se encuentra en la posicion {cursos.IndexOf(buscar)}");
            }
            else { Console.WriteLine("Curso no encontrado"); }
            break;
        case 4:
            Console.WriteLine(@"Cambiar el nombre de un curso
Ingrese el nombre a modificar");
            string modificar = Console.ReadLine();
            if (cursos.Contains(modificar))
            {
                int posicion = cursos.IndexOf(modificar);
                Console.WriteLine("Ingrese el nuevo nombre del curso");
                string nuevoNombre = Console.ReadLine();
                cursos[posicion] = nuevoNombre;
                Console.WriteLine("Curso modificado correctamente");
            }
            else { Console.WriteLine("Curso no encontrado"); }
            break;
        case 5:
            Console.WriteLine(@"Eliminar un curso
ingrese el nombre del curso a eliminar");
            string eliminar = Console.ReadLine();
            if (cursos.Contains(eliminar))
            {
                cursos.Remove(eliminar);
                Console.WriteLine("Curso eliminado correctamente");
            }
            else { Console.WriteLine("Curso no encontrado"); }
            break;
        case 6:
            Console.WriteLine($"Total de cursos registrados: {cursos.Count}");
            break;
        case 7:
            Console.WriteLine("Saliendo del programa");
            break;
        default:
            Console.WriteLine("Opcion invalida");
            break;
    }

}while (opcion != 7);
Console.WriteLine("bye");
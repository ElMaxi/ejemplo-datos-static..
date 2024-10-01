
namespace ListaDeTareas;

public class Program()
{
    static void Main()
    {
        int opcion;


        


        do
        {
            Console.WriteLine($"1. Agregar Usuario\n");
            Console.WriteLine($"2. Agregar Tarea a Usuario\n");
            Console.WriteLine($"3. Cambiar Estado de Tarea\n");
            Console.WriteLine($"4. Mostrar Tareas de un Usuario\n");
            Console.WriteLine($"5. Guardar y Salir\n");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Sistema.AgregarUsuario();
                    Console.WriteLine($"\n");
                    break;
                case 2:
                    Sistema.AgregarTareaUsuario();
                    Console.WriteLine($"\n");
                    break;
                case 3:
                    Sistema.CambiarTareaUsuario();
                    Console.WriteLine($"\n");
                    break;
                case 4:
                    Sistema.MostrarTareas();
                    Console.WriteLine($"\n");
                    break;
                default:
                    Console.WriteLine($"eh");
                    break;

            }

        }
        while (opcion != 5)
            {

            Sistema.GuardarArchivos();

        }

    } }
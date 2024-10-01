using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> Usuarios = new();
        static readonly string archivo = "Usuarios.txt";
        static readonly string separaUsuarios= "-";



        public static void AgregarUsuario()
        {
            Console.WriteLine($"\nIngrese el nombre del usuario");
            string NombreUsuario = Console.ReadLine();

            if (!Usuarios.ContainsKey(NombreUsuario)){
                Usuarios[NombreUsuario] = new Usuario(NombreUsuario);
                Console.WriteLine($"\nUsuario {NombreUsuario} agregado.\n");
            }
            else { Console.WriteLine($"\nEse usuario ya existe.\n");
            }

        }
        public static void AgregarTareaUsuario()
        {
            Console.WriteLine($"\nIngrese el nombre del usuario: ");
            string NombreUsuario = Console.ReadLine();

            if (Usuarios.ContainsKey(NombreUsuario))
            {
                Console.WriteLine($"\nIngrese la descripcion de la tarea: ");
                string Descripcion = Console.ReadLine();

                Tarea tarea = new Tarea(Descripcion);

                Usuarios[NombreUsuario].AgregarTarea(tarea);
                Console.WriteLine($"\njoyaaa");
            }
            else
            {
                Console.WriteLine($"\nEse usuario no existe.\n");
            }


        }

        public static void CambiarTareaUsuario()
        {
            Console.WriteLine($"\nIngrese el nombre del usuario: ");
            string NombreUsuario = Console.ReadLine();

            if (Usuarios.ContainsKey(NombreUsuario))
            {
                Console.WriteLine($"Ingrese el numero de la tarea a cambiar (empieza en 0)");
                int indice = int.Parse(Console.ReadLine());

                Usuarios[NombreUsuario].CompletarTarea(indice);
            }
            else
            {
                Console.WriteLine($"\nEse usuario no existe.\n");
            }

        }
        public static void MostrarTareas()
        {
            Console.WriteLine($"\nIngrese el nombre del usuario: ");
            string NombreUsuario = Console.ReadLine();

            if (Usuarios.ContainsKey(NombreUsuario))
            {
                Usuarios[NombreUsuario].MostrarTarea();

            }
            else
            {
                Console.WriteLine($"\nEse usuario no existe.\n");
            }
        }
        
        public static void GuardarArchivos()
        {
            using StreamWriter writer = new StreamWriter(archivo);
            string linea;

            foreach (var usuario in Usuarios)
            {
                writer.WriteLine(usuario.Key);

                foreach (var tarea in usuario.Value.Tareas)
                {
                    writer.WriteLine($"{tarea.Descripcion} | {tarea.Completado}\n");

                }
                writer.WriteLine(separaUsuarios);
            }
            Console.WriteLine($"\ntodo guardado joya pibeeeeeeeeeeee");
        }



    }
}

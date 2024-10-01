using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public List<Tarea> Tareas { get; set; }


        public Usuario(string nombreUsuario)
        {
            Tareas = new List<Tarea>();
        }


        public void AgregarTarea(Tarea area) => Tareas.Add(area);

        public void MostrarTarea()
        {
            Console.WriteLine($"\n Tareas de {NombreUsuario}:");
            foreach (var tarea in Tareas)
            {
                Console.WriteLine(tarea.ToString());
            }
        }
        public void CompletarTarea(int indice)
        {
            if (Tareas.Count > indice && indice >= 0)
            {

                Tareas[indice].Completado = !Tareas[indice].Completado;

            }
            if (Tareas.Count == 0)
            {
                Console.WriteLine($"no hay tareas todavía 👍");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completado { get; set; }

        public Tarea(string descripcion, bool completado = false)
        {
            Descripcion = descripcion;
            Completado = completado;
        }
        public override string ToString()
        {
            return $"{Descripcion} - {(Completado ? "Completado" : "Pendiente")}";
            //return $"{Descripcion} - {Completado.TryFormat}";
        }


    }
}

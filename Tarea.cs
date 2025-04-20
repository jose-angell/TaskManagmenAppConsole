using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerAppConsole
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Tarea(string decripcion)
        {
            Descripcion = decripcion;
            FechaCreacion = DateTime.Now;   
        }
        public override string ToString()
        {
            return $"{Descripcion} (Creada el {FechaCreacion})";
        }
    }
}

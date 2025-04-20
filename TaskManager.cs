using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerAppConsole
{
    public class TaskManager
    {
        Queue<Tarea> tareasPendientes = new Queue<Tarea>();   
        Stack<string> historial = new Stack<string>();
        
        public void AgregarTarea(string descripcion)
        {
            var tarea = new Tarea(descripcion);
            tareasPendientes.Enqueue(tarea);
            historial.Push($"Agregada: {descripcion}");
        }
        public void CompletarTarea()
        {
            if(tareasPendientes.Count == 0)
            {
                Console.WriteLine("No hay tareas para completar");
                return;
            }
            var tarea = tareasPendientes.Dequeue();
            historial.Push($"Completada: {tarea.Descripcion}");
            Console.WriteLine($"Tarea completada: {tarea.Descripcion}");
        }
        public void verTareas()
        {
            if(tareasPendientes.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes para mostrar");
                return;
            }
            Console.WriteLine("Tareas pendientes");
            foreach(var tarea in tareasPendientes)
            {
                Console.WriteLine($"- {tarea}");
            }
        }
        public void verHistorial()
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("No hay historial de acciones para mostrar");
                return;
            }
            Console.WriteLine("Hitorial de acciones:");
            foreach (var accion in historial)
            {
                Console.WriteLine($"- {accion}");
            }
        }
    }
}

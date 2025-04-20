

using TaskManagerAppConsole;

TaskManager gestor = new TaskManager();
string opcion = "";

do {
    Console.WriteLine("\n-- Gestion de tareas ---");
    Console.WriteLine("1. Agregar tarea");
    Console.WriteLine("2. Completar tarea");
    Console.WriteLine("3. Ver tareas pendientes");
    Console.WriteLine("4. Ver historial");
    Console.WriteLine("0. Salir");
    Console.Write("Elige la opcion: ");
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Descripcion de la tarea: ");
            string descripcion = Console.ReadLine();
            gestor.AgregarTarea(descripcion);
            break;
        case "2":
            gestor.CompletarTarea();
            break;
        case "3":
            gestor.verTareas();
            break;
        case "4":
            gestor.verHistorial();
            break;
    }
}  while (opcion != "0");
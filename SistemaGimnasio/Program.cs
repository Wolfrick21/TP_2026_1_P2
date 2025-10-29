using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

Console.WriteLine("Sistema de Gestión de Gimnasio");

//Crear usuario

Console.WriteLine("Ingrese el nombre del usuario:");
string nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (Fuerza, Resistencia, Musculo, ets):");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear entrenador
Console.WriteLine("Ingrese el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese la especialidad del entrenador:");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear rutina
Console.WriteLine("Ingrese el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese la duración de la rutina:");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina
Console.WriteLine("¿Cuántos ejercicios desea agregar a la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");
int contadorEjercicios = 1;

while (numEjercicios > 0)
{
    Console.WriteLine($"Ejercicio #{contadorEjercicios}");
    Console.WriteLine("Ingrese el nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Ingrese el numero de repeticiones del ejercicio:");
    int repeticionesEjercicio = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Numero de series del ejercicio:");
    int seriesEjercicio = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Tiempo de descanso entre series (en segundos):");
    int descansoEjercicio = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticionesEjercicio, seriesEjercicio, descansoEjercicio);
    rutina.AgregarEjercicio(ejercicio);

    numEjercicios--;
    contadorEjercicios++;
}

//Asignar rutina a usuario y usuario a entrenador
AsignadorRutinas asignador = new AsignadorRutinas();

asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen
Console.WriteLine($"Resumen de la asignación: {usuario.Nombre}");
Console.WriteLine($"Objetivo: {usuario.Objetivo}, Rutina: {usuario.RutinaAsignada.Nombre}, Duración: {usuario.RutinaAsignada.Duracion}");

Console.WriteLine("Ejercicios en la rutina:");
foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre}| {e.Series} X {e.Repeticiones} | Descanso: {e.Descanso}");
}
Console.WriteLine($"Entrenador asignado: {entrenador.Nombre}, Especialidad: {entrenador.Especialidad}");
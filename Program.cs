using ParcialPoo_Vásquez.Clases; // Namespace de las clases

// Programa principal
public class Program
{
    public static void Main()
    {
        // Crear materias
        var m1 = new Materia("Programación", "INF101", 3, 30, 25);
        var m2 = new Materia("Base de Datos", "INF202", 4, 30, 28);
        var m3 = new Materia("Matemáticas", "MAT105", 2, 25, 20);

        // Crear estudiantes
        var e1 = new Estudiante("Luis Pérez", "E001", "Ingeniería");
        var e2 = new Estudiante("Ana Gómez", "E002", "Informática");
        var e3 = new EstudianteBecado("Carlos Ruiz", "E003", "Sistemas", 50);

        // Crear calificaciones 
        var c1 = new Calificacion(e1, m1, 85);
        var c2 = new Calificacion(e1, m2, 90);
        var c3 = new Calificacion(e3, m3, 95);

        // Agregar calificaciones a estudiantes
        e1.Calificaciones.Add(c1);
        e1.Calificaciones.Add(c2);
        e3.Calificaciones.Add(c3);
    }
}

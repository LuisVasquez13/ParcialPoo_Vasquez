using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialPoo_Vásquez.Clases;

namespace ParcialPoo_Vásquez.Clases
{
    public class Estudiante : IMostrable
    {
        private string nombre;
        private string id;
        private string carrera;
        private List<Calificacion> calificaciones = new List<Calificacion>();

        public string Nombre
        {
            get => nombre;
            set => nombre = value ?? throw new ArgumentException("El nombre no puede ser nulo");
        }

        public string Id
        {
            get => id;
            set => id = value ?? throw new ArgumentException("El ID no puede ser nulo");
        }

        public string Carrera
        {
            get => carrera;
            set => carrera = value ?? throw new ArgumentException("La carrera no puede ser nula");
        }


        public List<Calificacion> Calificaciones => calificaciones;

        public Estudiante(string nombre, string id, string carrera)
        {
            Nombre = nombre;
            Id = id;
            Carrera = carrera;
        }

        // Método aritmético para calcular el promedio ponderado
        public virtual double CalcularPromedio()
        {
            if (Calificaciones.Count == 0) return 0; // Si no hay calificaciones, el promedio es 0

            double sumaPonderada = 0;
            int totalCreditos = 0;

            foreach (var c in Calificaciones) // Iterar sobre las calificaciones
            {
                sumaPonderada += c.Nota * c.Materia.Creditos; // Sumar la nota ponderada por créditos
                totalCreditos += c.Materia.Creditos; // Sumar los créditos
            }

            return totalCreditos == 0 ? 0 : sumaPonderada / totalCreditos; // Promedio ponderado
        }

        // Método MostrarDatos para implementar la interfaz IMostrable
        public virtual void MostrarDatos()
        {
            // Mostrar información del estudiante y su promedio
            Console.WriteLine($"Estudiante: {Nombre} | ID: {Id} | Carrera: {Carrera} | Promedio: {CalcularPromedio():F2}");
        }
    }
}
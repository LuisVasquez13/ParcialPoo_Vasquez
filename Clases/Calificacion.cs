using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo_Vásquez.Clases
{
    // Clase Calificacion que implementa la interfaz IMostrable
    public class Calificacion : IMostrable
    {
        private Estudiante estudiante;
        private Materia materia;
        private double nota;

        public Estudiante Estudiante // Propiedad Estudiante con validación
        {
            get => estudiante;
            // Validar que el estudiante no sea nulo
            set => estudiante = value ?? throw new ArgumentException("El estudiante no puede ser nulo");
        }

        public Materia Materia // Propiedad Materia con validación
        {
            get => materia;
            // Validar que la materia no sea nula
            set => materia = value ?? throw new ArgumentException("La materia no puede ser nula");
        }

        public double Nota // Propiedad Nota con validación
        {
            get => nota;
            set
            {
                if (value < 0 || value > 100) // Validación de nota entre 0 y 100
                    throw new ArgumentException("La nota debe estar entre 0 y 100");
                nota = value;
            }
        }

        // Constructor
        public Calificacion(Estudiante estudiante, Materia materia, double nota)
        {
            Estudiante = estudiante;
            Materia = materia;
            Nota = nota;
        }

    }
}
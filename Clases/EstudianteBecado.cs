using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo_Vásquez.Clases
{
    // Clase EstudianteBecado que hereda de Estudiante
    public class EstudianteBecado : Estudiante
    {
        private double porcentajeBeca; 

        public double PorcentajeBeca // Propiedad con validación
        {
            get => porcentajeBeca;
            set
            {
                if (value < 0 || value > 100) // Validación del porcentaje de beca entre 0 y 100
                    throw new ArgumentException("El porcentaje de beca debe estar entre 0 y 100");
                porcentajeBeca = value; // Asignar el valor si es válido
            }
        }
        // Constructor
        public EstudianteBecado(string nombre, string id, string carrera, double porcentajeBeca)
            : base(nombre, id, carrera)
        {
            PorcentajeBeca = porcentajeBeca;
        }

        // Método aritmético para calcular la matrícula con descuento
        public double CalcularMatriculaConDescuento(double matriculaBase)
        {
            return matriculaBase * (1 - (PorcentajeBeca / 100.0));
        }

        // Sobrescribir el método MostrarDatos para incluir el porcentaje de beca
        public override void MostrarDatos()
        {
            // Mostrar información del estudiante becado
            Console.WriteLine($"Estudiante Becado: {Nombre} | Carrera: {Carrera} | Porcentaje Beca: {PorcentajeBeca}% | Promedio: {CalcularPromedio():F2}");
        }
    }
}
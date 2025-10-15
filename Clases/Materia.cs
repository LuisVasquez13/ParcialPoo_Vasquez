using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo_Vásquez.Clases
{
    // Clase Materia que implementa la interfaz IMostrable
    public class Materia : IMostrable
    {
        // Atributos privados
        private string nombre;
        private string codigo;
        private int creditos;
        private int cupos;
        private int inscritos;

        // Propiedades con validación
        public string Nombre
        {
            get => nombre;
            // Validar que el nombre no sea nulo
            set => nombre = value ?? throw new ArgumentException("El nombre no puede ser nulo");
        }

        public string Codigo // Propiedad Código con validación
        {
            get => codigo;
            // Validar que el código no sea nulo
            set => codigo = value ?? throw new ArgumentException("El código no puede ser nulo");
        }

        public int Creditos // Propiedad Créditos con validación
        {
            get => creditos;
            set
            { // Validar que los créditos sean mayores que 0
                if (value <= 0) throw new ArgumentException("Los créditos deben ser mayores que 0");
                creditos = value;
            }
        }

        public int Cupos // Propiedad Cupos con validación
        {
            get => cupos;
            set
            { // Validar que los cupos sean mayores o iguales a 0
                if (value < 0) throw new ArgumentException("Los cupos deben ser mayores o iguales a 0");
                cupos = value;
            }
        }

        public int Inscritos
        {
            get => inscritos;
            set
            {
                if (value < 0 || value > Cupos) // Validar que los inscritos estén entre 0 y el número de cupos
                    throw new ArgumentException("Los inscritos deben estar entre 0 y el número de cupos");
                inscritos = value;
            }
        }

        // Constructores con y sin parámetros
        public Materia(string nombre, string codigo, int creditos, int cupos = 0, int inscritos = 0)
        {
            Nombre = nombre;
            Codigo = codigo;
            Creditos = creditos;
            Cupos = cupos;
            Inscritos = inscritos;
        }

        public Materia() { }

        // Método aritmético para calcular la carga semanal
        public int CalcularCargaSemanal(int horasPorCredito)
        {
            return Creditos * horasPorCredito;
        }

        // Método MostrarDatos para implementar la interfaz IMostrable
        public void MostrarDatos()
        {
            // Mostrar información de la materia
            Console.WriteLine($"Materia: {Nombre} | Código: {Codigo} | Créditos: {Creditos} | Cupos/Inscritos: {Cupos}/{Inscritos}");
        }
    }
}
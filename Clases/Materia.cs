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
            set => nombre = value ?? throw new ArgumentException("El nombre no puede ser nulo");
        }

        public string Codigo
        {
            get => codigo;
            set => codigo = value ?? throw new ArgumentException("El código no puede ser nulo");
        }

        public int Creditos
        {
            get => creditos;
            set
            {
                if (value <= 0) throw new ArgumentException("Los créditos deben ser mayores que 0");
                creditos = value;
            }
        }

        public int Cupos
        {
            get => cupos;
            set
            {
                if (value < 0) throw new ArgumentException("Los cupos deben ser mayores o iguales a 0");
                cupos = value;
            }
        }

        public int Inscritos
        {
            get => inscritos;
            set
            {
                if (value < 0 || value > Cupos)
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
            Console.WriteLine($"Materia: {Nombre} | Código: {Codigo} | Créditos: {Creditos} | Cupos/Inscritos: {Cupos}/{Inscritos}");
        }
    }
}
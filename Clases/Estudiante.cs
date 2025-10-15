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

    }
}
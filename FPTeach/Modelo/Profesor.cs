using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTeach
{
    public class Profesor
    {
        public static List<Profesor> listaProfesores;
        private string idProfesor;
        private string nombre;
        private string contraseña;
        private string dni;
        private string numseg;
        private string asignatura;
        private List<string> listaAlumnos;

        public Profesor(string idProfesor, string nombre, string contraseña, string dni, string numseg, string asignatura, List<string> listaAlumnos)
        {
            this.idProfesor = idProfesor;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.dni = dni;
            this.numseg = numseg;
            this.asignatura = asignatura;
            this.listaAlumnos = listaAlumnos;
        }

        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Numseg { get => numseg; set => numseg = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
        public List<string> ListaAlumnos { get => listaAlumnos; set => listaAlumnos = value; }

    }
}

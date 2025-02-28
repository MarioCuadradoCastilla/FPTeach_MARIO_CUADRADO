using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTeach
{
    public class Alumno
    {
        public static List<Alumno> listaAlumnos = new List<Alumno>();
        private string usuario;
        private string correo;
        private string dni;
        private string contraseña;
        private string[]profesores = new string[7];//un profesor por asignatura 
        private int[]nota=new int[7];//una nota por cada asignatura

        public Alumno(string usuario, string correo, string dni, string contraseña, string[] profesores, int[]nota)
        {
            this.Usuario = usuario;
            this.Correo = correo;
            this.Dni = dni;
            this.Contraseña = contraseña;
            this.Profesores = profesores;//posiciones-> 0=Acceso a Datos, 1=Procesos, 2=Interfaces, 3=SGE, 4=Aplicaciones Moviles, 5=Ingles, 6=Empresa.               
            this.Nota = nota;//corresponden al mismo orden que los profesores
        }
        public Alumno() { }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string[] Profesores { get => profesores; set => profesores = value; }
        public int[] Nota { get => nota; set => nota = value; }
    }
}

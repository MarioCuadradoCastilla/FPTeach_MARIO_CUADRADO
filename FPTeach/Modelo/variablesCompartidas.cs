using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTeach
{
    public static class variablesCompartidas
    {
        //las variables de alumno y profesor son para que a la hora de iniciar seision guarde el usuario o profesor que entra y asi poder recoger sus datos en cualquier formulario correspondiente.
        private static Alumno a;
        private static Profesor p;
        public static Alumno A { get => a; set => a = value; }
        public static Profesor P { get => p; set => p = value; }
    }
}

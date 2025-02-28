using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace FPTeach
{
    public static class ControladorAlumnos
    {
        public static void leerAlumnos()
        {
            try
            {
                string xml = File.ReadAllText("alumnos.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new
                    XmlSerializer(Alumno.listaAlumnos.GetType());
                    Alumno.listaAlumnos = (List<Alumno>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }

        }
        public static void escribirAlumnos()
        {
            try
            {
                using (var writer = new StreamWriter("alumnos.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new
                    XmlSerializer(Alumno.listaAlumnos.GetType());
                    serializer.Serialize(writer, Alumno.listaAlumnos, namespaces);
                }
            }
            catch (Exception e) {
                Console.WriteLine("No se pudo escribir " + e.Message);
            }
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows.Forms;

namespace FPTeach
{
    public static class ControladorProfesor{
        public static List<Profesor> leerProfesores()
        {
            try
            {
                if (File.Exists("profesores.json"))
                {
                    string jsonString = File.ReadAllText("profesores.json");

                    Profesor.listaProfesores = JsonSerializer.Deserialize<List<Profesor>>(jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return Profesor.listaProfesores;
        }

        public static void escribirProfesores()
        {
            try
            {
                if (File.Exists("profesores.json"))//crearlo en bin debug a mano
                {
                    string jsonString = JsonSerializer.Serialize(Profesor.listaProfesores);
                    File.WriteAllText("profesores.json", jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class manejoArchivo
    {
        public string AbrirArchivoTexto(string nombreArchivo)
        {
            string documento;
              using (var archivoOpen = new FileStream(nombreArchivo, FileMode.Open))
            {
                using (var strReader = new StreamReader(archivoOpen))
                {
                    documento = strReader.ReadToEnd();
                    archivoOpen.Close();
                }
            }
            return documento;
        }


        public static void GuardarArchivoTexto(string nombreArchivo, List<alumno> lista )
        {
             using(var archivo = new FileStream(nombreArchivo, FileMode.Create))
            {
                using (var strWriter = new StreamWriter(archivo))
                {
                    strWriter.WriteLine("ID,Apellido,Nombre,DNI,Curso");
                    foreach(var l in lista){
                        strWriter.WriteLine(l.Id+ ',' +l.Apellido+ ','+ l.Nombre +','+l.Dni);
                    }
                    strWriter.Close();
                }
            }
        }

    }
}

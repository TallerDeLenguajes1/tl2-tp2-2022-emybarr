using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class alumno
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private int curso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Curso { get => curso; set => curso = value; }
        public int Id { get => id; set => id = value; }

        public alumno(int i, string ape, string n, int dni, int curso){
            this.Apellido=ape;
            this.Nombre=n;
            this.Dni=dni;
            this.Curso=curso;
            this.Id=i;
        }
    }
}
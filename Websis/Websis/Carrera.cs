using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Carrera
    {
        private string nombre;
        private int codigo = 0;
        List<Materia> materias = new List<Materia>();
        List<Docente> docentes = new List<Docente>();
        List<Alumno> alumnos = new List<Alumno>();

        public Carrera(string nombre) 
        {
            this.nombre = nombre;
            
        }

        public string getNombre() 
        {
            return nombre;
        }
    }
}

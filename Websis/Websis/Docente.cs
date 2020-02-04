using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Docente
    {
        private string nombre;
        private int codigo = 0;
        List<Carrera> carreras = new List<Carrera>();
        List<Materia> materias = new List<Materia>();
        List<Alumno > alumnos  = new List<Alumno >();

        public Docente(string nombreD) 
        {
            this.nombre = nombreD;
        }

        public string getNombre() 
        {
            return nombre;
        }

    }
}

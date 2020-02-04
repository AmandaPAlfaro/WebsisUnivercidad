using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Alumno 
    {
        private string nobre;
        private int codigo = 0;
        List<Carrera> carreras = new List<Carrera>();
        List<Materia> materias = new List<Materia>();
        List<Docente> docentes = new List<Docente>();

        public Alumno(string nombreA) 
        {
            this.nobre = nombreA;
        }

    }
}

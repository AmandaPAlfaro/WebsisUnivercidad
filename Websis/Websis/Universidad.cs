using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Universidad
    {
        string nombre;
        List<Alumno > alumnos  = new List<Alumno >();
        List<Carrera> carreras = new List<Carrera>();
        List<Materia> materias = new List<Materia>();
        List<Docente> docentes = new List<Docente>();

        public Universidad(string nombre) 
        {
            this.nombre = nombre;
        }

        public void ingresaCarrera(Carrera carrera) 
        {
            this.carreras.Add(carrera);
        }

        public void ingresaMateria(Materia materia) 
        {
            this.materias.Add(materia);
        }

        public void ingreseDocente(Docente docente) 
        {
            this.docentes.Add(docente);
        }

        public void imprimirDocente() 
        {
            foreach (Docente docente in docentes)
            {
                Console.WriteLine(docente.getNombre());
            }
        }

        public void imprimirMateria ()
        {
            foreach (Materia materia in materias)
            {
                Console.WriteLine(materia.getNombre());
            }
        }

        public void imprimirCarrera() 
        {
            foreach (Carrera carrera in carreras)
            {
                Console.WriteLine(carrera.getNombre());
            }
        }

        public void eliminarCarrera(string nombreCarrera) 
        {
            for (int i = 0; i < carreras.Count(); i++)
            {
                if (carreras[i].getNombre() == nombreCarrera)
                {
                    carreras.Remove(carreras[i]);
                }
            }
        }

        public void eliminarMateria(string nombreMateria) 
        {
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].getNombre() == nombreMateria)
                {
                    materias.Remove(materias[i]);
                }
            }
        }
        public void eliminarDocente(string nombreDocente) 
        {
            for (int i = 0; i < docentes.Count; i++)
            {
                if (docentes[i].getNombre() == nombreDocente)
                {
                    docentes.Remove(docentes[i]);
                }
            }
        }
    }
}

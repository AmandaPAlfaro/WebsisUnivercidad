using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Materia
    {
        private string nombre;
        private int nota;
        private string temario;

        public Materia(string nombre)
        {
            this.nombre = nombre;
        }

        public void ingresarNota(int notas)
        {
            this.nota = notas;
        }

        public void ingreseTemario(string temarios)
        {
            this.temario = temarios;
        }


        public string getNombre() 
        {
            return nombre;
        }

       
    }
}

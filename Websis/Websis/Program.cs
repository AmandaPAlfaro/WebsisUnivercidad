using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ***UNIVERSIDAD***");
            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre de la Universidad");           
            string nombreuniversidad = Console.ReadLine();
            Universidad universidad1 = new Universidad(nombreuniversidad);
            Console.WriteLine();

            Console.WriteLine("---Alumno---");
            Console.WriteLine();
            Console.WriteLine("Nombre del Alumno");
            string alumno = Console.ReadLine();
            Alumno alumno1 = new Alumno(alumno);
            Console.WriteLine();

            Console.WriteLine("---Carrera---");

            Console.WriteLine();
            Console.WriteLine("Estas son las carreras que hay en la universidad");
            Console.WriteLine();
            Carrera Sistemas = new Carrera("Sistemas");
            Carrera Informatica = new Carrera("Informatica");
            Carrera Electromecanica = new Carrera("Electromecanica");
            universidad1.ingresaCarrera(Sistemas);
            universidad1.ingresaCarrera(Informatica);
            universidad1.ingresaCarrera(Electromecanica);
            universidad1.imprimirCarrera();

            Console.WriteLine();
            Console.WriteLine("Escriba la carrera que decea eliminar");
            Console.WriteLine();
            string eliminarCarrera= Console.ReadLine();
            universidad1.eliminarCarrera(eliminarCarrera);
            Console.WriteLine();
            Console.WriteLine("Las carreras son : ");
            Console.WriteLine();
            universidad1.imprimirCarrera();
            Console.WriteLine();
            Console.WriteLine("Nombre de la carrera que decea ingresar");
            string carrera = Console.ReadLine();
            Carrera carrera1 = new Carrera(carrera);
            Console.WriteLine();

            Console.WriteLine("---Materia---");
            Console.WriteLine();
            Console.WriteLine("Estas son las materias que hay en la carrera");
            Console.WriteLine();
            Materia Quimica = new Materia("Quimica");
            Materia Fisica = new Materia("Fisica");
            Materia Calculo = new Materia("Calculo");
            universidad1.ingresaMateria(Quimica);
            universidad1.ingresaMateria(Fisica);
            universidad1.ingresaMateria(Calculo);
            universidad1.imprimirMateria();
            Console.WriteLine("Escriba la amteria que decea eliminar");
            Console.WriteLine();
            string eliminarMateria = Console.ReadLine();
            universidad1.eliminarMateria(eliminarMateria);
            Console.WriteLine("Las materias son :");
            Console.WriteLine();
            universidad1.imprimirMateria();

            Console.WriteLine();
            Console.WriteLine("Nombre de la materia que quiera pasar");
            Console.WriteLine();
            string materia = Console.ReadLine();
            Materia materia1 = new Materia(materia);
            Console.WriteLine();

            Console.WriteLine("---Docente---");
            Console.WriteLine();
            Console.WriteLine("Estos son los docentes");
            Console.WriteLine();
            Docente David = new Docente("David");
            Docente Maria = new Docente("Maria");
            Docente Jose = new Docente("Jose");
            universidad1.ingreseDocente(David);
            universidad1.ingreseDocente(Maria);
            universidad1.ingreseDocente(Jose );
            universidad1.imprimirDocente();
            Console.WriteLine();
            Console.WriteLine("Que docente decea eliminar");
            Console.WriteLine();
            string eliminarDocentes = Console.ReadLine();
            universidad1.eliminarDocente(eliminarDocentes);
            Console.WriteLine();
            Console.WriteLine("Los docentes son :");
            Console.WriteLine();
            universidad1.imprimirDocente();

            Console.WriteLine("Nombre con el docente que quiera pasar las clases");
            Console.WriteLine();
            string docente = Console.ReadLine();
            Docente docente1 = new Docente(docente);
            Console.WriteLine();

            Console.WriteLine("El estudiante regustrado es " + alumno + " \n Su carrera es: " + carrera + "\n La Materia: " + materia + "\n El o la docente con la cual pasara clases es: " + docente);
          

            Console.ReadLine();
        }
    }
}

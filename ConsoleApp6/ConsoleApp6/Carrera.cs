using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Carrera
    {
        private string nombre;
        private int codigo=0;
        List<Materia> RegistrarMateria=new List<Materia>();
        List<Universitario>alumnoRegistrado=new List<Universitario>();
        List<Docente> RegistrarDocente=new List<Docente>();
        List<Carrera> RegistrarCarrera = new List<Carrera>();
        

        public Carrera(string nombre)
        {
            this.nombre = nombre;
            this.codigo++;
        }

        public void ingreseMateria(Materia materia)
        {
            this.RegistrarMateria.Add(materia);
        }

        public void ingreseNombreCarrera(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombreCarrera()
        {
            return this.nombre;
        }

        public void ingreseUniversitario(Universitario alumnoRegistrado)
        {
             this.alumnoRegistrado.Add(alumnoRegistrado);
        }

        public void ingreseDocente(Docente RegistrarDocente)
        {
            this.RegistrarDocente.Add(RegistrarDocente);
        }

        public string getnombreCarrera()
        {
            return nombre;
        }

        public string getnombreMateria()
        {
            return nombre;
        }

        public void imprimirCarreras()
        {
            foreach (Carrera carrera in this.RegistrarCarrera)
            {
                Console.WriteLine(carrera.getnombreCarrera());
            }
        }

        public void imprimirMateria()
        {
            foreach (Materia materia in this.RegistrarMateria)
            {
                Console.WriteLine(materia.getnombreMateria());
            }
        }
       public void deseleccionarMateria()
        {
            foreach (Materia materia in this.RegistrarMateria)
            {
                Console.WriteLine(materia.getnombreMateria());
            }
        }
        public void eliminarMateria(string nombreMateria)
        {
            List<Materia> materiaAUX = new List<Materia>();
            foreach (Materia materia in RegistrarMateria)
            {
                materiaAUX.Add(materia);
            }
            foreach (Materia materia in materiaAUX)
            {
                if (materia.getnombreMateria() == nombreMateria)
                {
                    RegistrarMateria.Remove(materia);
                }

            }


        }


    }
 }

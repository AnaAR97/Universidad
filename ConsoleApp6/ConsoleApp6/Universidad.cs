using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Universidad
    {
        private string nombre;
        List<Docente> RegistrarDocente = new List<Docente>();
        List<Universitario> universitarios = new List<Universitario>();
        List<Carrera> RegistrarCarreras = new List<Carrera>();
        Dictionary<string, string> estudiantes = new Dictionary<string, string>();
       

        public Universidad(string universidad)
        {
            this.nombre = universidad;           
        }

        public void mostrarDocentes()//muestra la lista de docentes
        {
            foreach (var item in RegistrarDocente)
            {
                Console.WriteLine(item.getNombredDocente());
            }
        }

        public void ingreseDocente(Docente RegistrarDocente)
        {
            this.RegistrarDocente.Add(RegistrarDocente);
        }

        public void ingresarUniversitario(Universitario Registraruniversitarios)
        {
            this.universitarios.Add(Registraruniversitarios);
        }

        public void ingreseCarrera(Carrera Registrarcarreras)
        {
            this.RegistrarCarreras.Add(Registrarcarreras);
        }

        public string getnombreUniversidad()
        {
            return nombre;
        }
       
        public void imprimirCarreras()
        {
            foreach(Carrera carrera in this.RegistrarCarreras)
            {
                Console.WriteLine(carrera.getNombreCarrera());
            }
        }

        public void imprimirUniversitarios()
        {
            foreach (Universitario universitario in this.universitarios)
            {
                Console.WriteLine(universitario.getNombre());
            }
        }

        public void registrarEstudiante(string nombreUniversitario, string nombreCarrera)
        {
            estudiantes.Add(nombreUniversitario, nombreCarrera);
        }

        public void eliminarUniversitario(string nombreUniversitario )

        {
            List<Universitario> universitariosAUX = new List<Universitario>();
            foreach (Universitario universitario in universitarios)
            {
                universitariosAUX.Add(universitario);
            }
                foreach (Universitario universitario in universitariosAUX)
            {
                if (universitario.getNombre() == nombreUniversitario)
                {
                    universitarios.Remove(universitario);
                }
            }          
        }

        public void imprimirCarrera()
        {
             foreach (Carrera carrera in this.RegistrarCarreras)
             {
                  Console.WriteLine(carrera.getnombreCarrera());
             }
        }

        public void eliminarCarrera(string nombreCarrera)
        {
             List<Carrera> carreraAUX = new List<Carrera>();
               foreach (Carrera carrera in RegistrarCarreras)
               {
                   carreraAUX.Add(carrera);
               }
               foreach (Carrera carrera in carreraAUX)
               {
                   if (carrera.getnombreCarrera() == nombreCarrera)
                   {
                    RegistrarCarreras.Remove(carrera);
                   }

               }


           }

        public Carrera getCarrera(string nombreCarrera)
        {
            foreach (var item in this.RegistrarCarreras)
            {
                if(item.getNombreCarrera ()== nombreCarrera)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}

using System.Collections.Generic;

namespace ConsoleApp6
{
    class Universitario
    {
        private string nombre;
        private static int codigo = 0;
        private string profecion;
        List<Materia> materias = new List<Materia>();
        List<Carrera> carrera = new List<Carrera>();


        public Universitario(string nombre)
        {
            this.nombre = nombre;
            Universitario.codigo++;
        }

        public void ingreseProfecion(string profecion)
        {
            this.profecion = profecion;
        }

        public void ingreseMateria(Materia materias)
        {
            this.materias.Add(materias);
        }

        public void ingreseCarrera(Carrera carrera)
        {
            this.carrera.Add(carrera);
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getNombreCarrera()
        {
            return this.nombre;
        }

        public void abandorarMateria(string nombreMateria)
        {
            List<Materia> materiaAUX = new List<Materia>();
            foreach (Materia materia in materias)
            {
                materiaAUX.Add(materia);
            }
            foreach (Materia materia in materiaAUX)
            {
                if (materia.getnombreMateria() == nombreMateria)
                {
                    materias.Remove(materia);
                }

            }


        }

    }
}

using System.Collections.Generic;

namespace ConsoleApp6
{
    class Docente
    {
        List<Materia> materias = new List<Materia>();
        private string nombre;
        private int codigo;
        private string profesion;

        public Docente(string nombre)
        {
            this.nombre = nombre;
        }

        public void ingreseMateria(Materia materias)
        {
            this.materias.Add(materias);
        }

        public void ingreseProfesion(string profesion)
        {
            this.profesion = profesion;
        }

        public string getNombredDocente()
        {
            return nombre;
        }
    }
}

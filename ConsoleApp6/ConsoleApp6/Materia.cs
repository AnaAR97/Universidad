using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp6

{
    class Materia
    {
       
        private string nombre;
        private int notas;
        private static int codigo=0;
        private string temario;
        List<Horario> horarios = new List<Horario>();


        public Materia(string materia)
        {
            this.nombre = materia;
            Materia.codigo++;
        }

        public void nombreMateria(string nombre)
        {
            this.nombre = nombre;
        }

        public void ingreseMateria(string materia)
        {
            this.nombre = materia;
        }

        public void ingreseNotas(int notas)
        {
            this.notas=notas;
        }

        public void ingreseTemario(string temario)
        {
            this.temario = temario;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getnombreMateria()
        {
            return nombre;
        }
        
        public void ingreseHorario(Horario horario)
        {
            this.horarios.Add(horario);
        }
        public void imprimirHorario()
        {
            foreach (Horario horario in this.horarios)
            {
                Console.WriteLine(horario.getHorario());
            }
        }

        public Horario getHorario(string horario)
        {
            foreach (var item in this.horarios)
            {
                if (item.getHorario() == horario)
                {
                    return item;
                }
            }
            return null;
        }



    }
}

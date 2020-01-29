using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Horario
    {
        private string horario;
        private string mañana;
        private string tarde;
        private string noche;
        
        public Horario(string mañana)
        {
            this.mañana = mañana;
            
        }

        public void turnoMañana(string mañana)
        {
            this.mañana = mañana;
        }

        public void turnoTarde(string tarde)
        {
            this.tarde = tarde;
        }

        public void turnoNoche(string noche)
        {
            this.noche = noche;
        }

        public string getTurnoMañana()
        {
            return this.mañana;
        }

        public string getTurnoTarde()
        {
            return this.tarde;
        }

        public string getTurnoNoche()
        {
            return this.noche;
        }

        public string getHorario()
        {
            return horario;
        }


    }
}

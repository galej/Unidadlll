using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Campeonato_de_futbol
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;

        //Constructor default
        public Campeonato()
        {
            this._nombre = ("Campeonato de la segunda division de Dolores");
            this._id = 1;
            for (int i=1; i<=20; i++)
            {
                Jornada j = new Jornada();
                _jornada.Add(j); 
            }
        }
        private List<Jornada> _jornada = new List<Jornada>();
         public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}

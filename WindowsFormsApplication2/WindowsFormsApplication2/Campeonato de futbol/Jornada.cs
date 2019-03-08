using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Campeonato_de_futbol
{
    class Jornada
    {
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private bool _isConcluida;

        //Constructor
        public Jornada()
        {
            this._fechaInicio = DateTime.Today;
            this._isConcluida = false;
        }
        public Jornada(int id)
        {
            this._id = id;
        }
        public int Id { get; set; }
        public DateTime FechaInicio { get
            {
                return this._fechaInicio;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    this._fechaInicio = value;
                }
            }
        }
        public DateTime FechaFin { get
            {
                return this._fechaFin;
            }
            set
            {
                DateTime fin = new DateTime(2019,4,8);
                if(value < fin)
                {
                    this._fechaFin = value;
                }
            }
        }
        public bool IsConcluida { get; set; }
    }
}

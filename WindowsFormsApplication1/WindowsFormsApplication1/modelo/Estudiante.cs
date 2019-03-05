using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.modelo
{
    class Estudiante
    {
        private long _numerocontrol;
        private string _nombre;
        private byte _edad;
        private char _genero;
        public byte edad {
            get
            {
                return this._numerocontrol;
            }
            set
            {
                if (value > 0)
                {
                    this._numerocontrol = value;
                }
            }
        }
        public char genero { get; set; }
        public string nombre { get; set; }
        public long NumeroControl { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.modelo.Cinema
{
    class Resevacion : Cliente
    {
        private int _numTarjeta;
        DateTime _fecha = DateTime.Now;



        public void Cliente(int numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }

        public int NumTarjeta
        {
            get
            {
                return _numTarjeta;
            }
            set
            {
                if (value == 16)
                {
                    _numTarjeta = value;
                }
            }
        }
    }
}

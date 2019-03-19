using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.modelo.Cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;

        public Sala()
        {

        }
        public Sala(int capacidad)
        {
            _capacidad = capacidad;
        }
        public Sala(int capacidad, string nombre)
        {
            _capacidad = capacidad;
            _nombre = nombre;

        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre;} set { _nombre = value; } }
        public int Capacidad { get { return _capacidad; } set { _capacidad = value; } }
        public override string ToString()
        {
            return "Id:" + _id + "Nombre:" + _nombre + "Capacidad:" + _capacidad;
        }
    }
}

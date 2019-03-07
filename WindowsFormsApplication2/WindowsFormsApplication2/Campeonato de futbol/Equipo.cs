using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Campeonato_de_futbol
{
    class Equipo
    {
        private int _id;
        private string _nombre;
        private string _comunidad;
        private string _entrenador;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if(value >= 0)
                {
                    this._id = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || value.Length >= 0 && value.Length <= 30)
                {
                    this._nombre = value;
                }
            }
        }
        public string Comunidad
        {
            get
            {
                return this._comunidad;
            }
            set
            { 
                if (value != null || value.Length >=0 && value.Length <= 30)
                {
                    this._comunidad = value;
                }
            }
        }
        public string Entrenador
        {
            get
            {
                return this._entrenador;
            }
            set
            {
                if (value != null || value.Length>=0 && value.Length <= 30)
                {
                    this._entrenador = value; 
                }
            }
        }
    }
}

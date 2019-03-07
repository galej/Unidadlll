using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Campeonato_de_futbol
{
    class Jugador
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private byte _numero;
        private Equipo _idEquipo;

        public Jugador()
        {
            this._nombre = "Papulince";
            this._apellidos = "Del campo";
            this._fechaNacimiento = DateTime.Today;
        }
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value >= 0)
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
        public string Apellidos
        {
            get
            {
                return this._apellidos;
            }
            set
            {
                if (value != null || value.Length >= 0 && value.Length <= 30)
                {
                    this._apellidos = value;
                }
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return this._fechaNacimiento;
            }
            set
            {
                if (value != null)
                {
                    this._fechaNacimiento = value;
                }
            }
        }
        public Equipo IdEquipo {
            get
            {
                return this._idEquipo;
            }
            set {
                if (value != null || ((Equipo)value).Nombre.ToLower().Equals("llanito"))
                {
                    this._idEquipo = value;
                }
            }
        }
    }
}

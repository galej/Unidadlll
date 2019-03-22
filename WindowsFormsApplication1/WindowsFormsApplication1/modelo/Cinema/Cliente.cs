using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.modelo.Cinema
{
    class Cliente : Persona
    {
        private int _celular;
        //Constructor
        public Cliente()/* se coloco el nombre del cliente ya que para poder hacer una reservaciòn tiene que dejarla a nombre de alguien*/
        {
            _nombre = "";
        }
        public void Personar(int celular, string nombre)/*tiene que tener un telefono de contacto en casod e que el horario cambie o haya algun retraso en la funciòn*/
        {
            _celular = celular;
            

        }

        public int Persona
        {
            get
            {
                return _celular;
            }
            set
            {
                if (value >= 10)
                {
                    _celular = value;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Campeonato_de_futbol
{
    class Partido
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private bool _isFinalizado;
        private string _observaciones;
        public Partido()
        {
            this._isFinalizado = false;
            this._id = 1;
            this._fecha = new DateTime(2019, 3, 9, 16, 0, 0);
        }
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this._local = equipo1;
            this._visitante = equipo2;
        }
        //Se asocia con clase cancha
        private Cancha _cancha;
        private Equipo _local;
        private Equipo _visitante;
        public void addCancha(Cancha cancha)
        {
            this._cancha = cancha;
        }
        //Se asocia con arbritro
        private Arbitro _arbitro1;
        private Arbitro _arbitro2;
        private List<Arbitro> _arbitro = new List<Arbitro>();
        /*private Arbitro[] arbitro;
         **/
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool IsFinalizado { get; set; }
        public string Observaciones { get; set; }

    }
}

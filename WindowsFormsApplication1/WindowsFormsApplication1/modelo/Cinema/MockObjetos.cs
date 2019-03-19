using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.modelo.Cinema
{
    class MockObjetos
    {
        public static Sala[] coleccionSalas()
        {
            Sala[] coleccionSalas = new Sala[5]; //Tamaño de la sala
            coleccionSalas[0] = new Sala();
            coleccionSalas[1] = new Sala(200);
            coleccionSalas[2] = new Sala(200, "Sala A");
            coleccionSalas[1] = new Sala(200, "Sala B");
            coleccionSalas[1] = new Sala(200,"Sala C");
            return coleccionSalas;
        }
        public List<Empleado> coleccionEmpleados()
        {
            Persona person1 = new Persona();
            List<Empleado> coleccionEmpleados = new List<Empleado>();
            Empleado emp1 = new Empleado();
            coleccionEmpleados.Add(emp1);
            coleccionEmpleados.Add(new Empleado());
        }
    }
}

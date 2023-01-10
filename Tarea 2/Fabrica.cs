using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Tarea_2
{
    class Fabrica
    {
        public static IEmpleado GetEmpleado(int Eleccion)
        {
            if (Eleccion == 1)
            {
                return new Operativo();
            }
            else if (Eleccion == 2)
            {
                return new Administrativo();
            }
            else if (Eleccion == 3)
            {

                return Gerencial.singleton();
                
            }
            return null;
        }
        

    }
}

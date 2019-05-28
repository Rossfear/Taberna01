using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Deportiva : Materia
    {
        public override decimal Evaluar()
        {
            //Evaluar en base a prueba y asistencia
            //consultar datos en BD para regresar resultado
            decimal calific = 90.0M;
            return calific;
        }
    }
}

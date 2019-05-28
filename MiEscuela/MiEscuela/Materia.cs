using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
     abstract class Materia
    {
        #region Atributos
        string cve;
        string nombre;
        //Profesor coordinador;
        #endregion

        #region Métodos
        public abstract decimal Evaluar();
        #endregion
    }
}

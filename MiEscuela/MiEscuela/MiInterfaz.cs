using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    interface MiInterfaz
    {
        //string miAtributo;
        string MiPropiedad { get; set; }

        string MiMensaje();
    }
}

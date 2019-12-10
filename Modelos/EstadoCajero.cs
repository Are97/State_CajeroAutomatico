using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Modelos
{
    public interface EstadoCajero
    {
        void operacion(int num, Cajero cajero);
    }
}

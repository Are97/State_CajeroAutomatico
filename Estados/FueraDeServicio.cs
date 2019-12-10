using State_CajeroAutomatico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Estados
{
    public class FueraDeServicio : EstadoCajero
    {
        public void operacion(int num, Cajero cajero)
        {
            Console.WriteLine("Favor de terminar programa, FUERA DE SERVICIO");
        }
    }
}

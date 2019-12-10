using State_CajeroAutomatico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Estados
{
    public class TarjetaValidada : EstadoCajero
    {
        public void operacion(int num, Cajero cajero)
        {
            string monto = "";
            if(num < cajero.getCantidad())
            {
                cajero.setCantidad(num);
                cajero.entregaDeDinero();
                cajero.operacion(0, cajero);
            }
            else if(num == cajero.getCantidad())
            {
                cajero.setCantidad(num);
                cajero.entregaDeDinero();
                cajero.operacion(num, cajero);
            }
            else
            {
                Console.WriteLine("Retiro fallido");
                Console.WriteLine("Monto en el banco: " + cajero.getCantidad().ToString());
                cajero.tarjetaValidada();
                Console.WriteLine("Inserte Monto a Retirar");
                monto = Console.ReadLine();
                cajero.operacion(Convert.ToInt32(monto), cajero);
            }
        }
    }
}

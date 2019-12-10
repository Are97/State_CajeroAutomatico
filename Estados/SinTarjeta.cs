using State_CajeroAutomatico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Estados
{
    public class SinTarjeta : EstadoCajero
    {
        public void operacion(int num, Cajero cajero)
        {
            string monto = "";
            string pin = "";
            if(num == 1234 || num == 4321)
            {
                Console.WriteLine("Pin Correcto");
                cajero.tarjetaValidada();
                Console.WriteLine("Inserte Monto a Retirar");
                monto = Console.ReadLine();
                cajero.operacion(Convert.ToInt32(monto), cajero);
            }
            else
            {
                Console.WriteLine("Pin incorrecto");
                cajero.sinTarjeta();
                Console.WriteLine("Inserte Pin");
                pin = Console.ReadLine();
                cajero.operacion(Convert.ToInt32(pin), cajero);
            }
        }
    }
}

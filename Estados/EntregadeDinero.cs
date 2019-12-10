using State_CajeroAutomatico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Estados
{
    public class EntregadeDinero : EstadoCajero
    {
        public void operacion(int num, Cajero cajero)
        {
            string monto = "";
            string pin = "";
            if (num == 0)
            {
                Console.WriteLine("Retiro Exitoso");
                Console.WriteLine("Monto en el banco: " + cajero.getCantidad().ToString());
                cajero.sinTarjeta();
                Console.WriteLine("Inserte Pin");
                pin = Console.ReadLine();
                cajero.operacion(Convert.ToInt32(pin), cajero);
            }
            else
            {
                Console.WriteLine("Retiro Exitoso");
                Console.WriteLine("Monto en el banco: " + cajero.getCantidad().ToString());
                cajero.fueraDeServicio();
                cajero.operacion(num, cajero);
            }
        }
    }
}

using State_CajeroAutomatico.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Modelos
{
    public class OperacionesCajero
    {
        private EstadoCajero estado;

        public OperacionesCajero()
        {
            estado = new SinTarjeta();
            Console.WriteLine("");
            Console.WriteLine("Estado: SinTarjeta");
            Console.WriteLine("");
        }

        public void TarjetaSin()
        {
            estado = new SinTarjeta();
            Console.WriteLine("");
            Console.WriteLine("Estado: SinTarjeta");
            Console.WriteLine("");
        }

        public void ValidarTarjeta()
        {
            estado = new TarjetaValidada();
            Console.WriteLine("");
            Console.WriteLine("Estado: TarjetaValidada");
            Console.WriteLine("");
        }

        public void DineroEntregado()
        {
            estado = new EntregadeDinero();
            Console.WriteLine("");
            Console.WriteLine("Estado: EntregaDeDinero");
            Console.WriteLine("");
        }

        public void ServicioFuera()
        {
            estado = new FueraDeServicio();
            Console.WriteLine("");
            Console.WriteLine("Estado: FueraDeServicio");
            Console.WriteLine("");
        }

        public void operacion(int num, Cajero cajero)
        {
            estado.operacion(num, cajero);
        }
    }
}

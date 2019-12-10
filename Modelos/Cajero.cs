using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico.Modelos
{
    public class Cajero
    {
        private OperacionesCajero operaciones;
        private int cantitdad = 5000;

        public int getCantidad()
        {
            return cantitdad;
        }
        public void setCantidad(int cant)
        {
            cantitdad -= cant;
        }
        public Cajero()
        {
            operaciones = new OperacionesCajero();
        }

        public void operacion(int num, Cajero cajero)
        {
            operaciones.operacion(num, cajero);
        }

        public void sinTarjeta()
        {
            operaciones.TarjetaSin();
        }

        public void tarjetaValidada()
        {
            operaciones.ValidarTarjeta();
        }

        public void entregaDeDinero()
        {
            operaciones.DineroEntregado();
        }

        public void fueraDeServicio()
        {
            operaciones.ServicioFuera();
        }
    }
}

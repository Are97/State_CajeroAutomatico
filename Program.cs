using State_CajeroAutomatico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "";
            Cajero cajero = new Cajero();
            Console.WriteLine("Inserte Pin");
            pin = Console.ReadLine();
            cajero.operacion(Convert.ToInt32(pin), cajero);
            System.Threading.Thread.Sleep(50000);
        }
    }
}

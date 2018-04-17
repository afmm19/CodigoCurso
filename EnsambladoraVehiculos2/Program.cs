using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsambladoraVehiculos2.Molde;
using EnsambladoraVehiculos2.Ayudas;
namespace EnsambladoraVehiculos2
{
    class Program
    {
        static void Main(string[] args)
        {
            MoldeVehiculoPadre vehiculo1 = new MoldeVehiculoPadre();
            
            MoldeVehiculoHijo vehiculo2 = new MoldeVehiculoHijo();
           
            //vehiculo1.

            MoldeCarro CarroUno = new MoldeCarro(4,4,Colores.Amarillo.ToString(), MarcasCarros.Audi.ToString());
            
            MoldeAvion AvionUno = new MoldeAvion(4, 4, Colores.Amarillo.ToString(), MarcasAviones.Airbuss.ToString());

            AvionUno.

        }
    }
}

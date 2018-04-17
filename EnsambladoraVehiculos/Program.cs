using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsambladoraVehiculos.Ayudas;
using EnsambladoraVehiculos.Molde;

namespace EnsambladoraVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoldeDeCarro elPrimerCarro = new MoldeDeCarro();
            //elPrimerCarro.Color = "rojo";
            //elPrimerCarro.Marca = "chevrolet";
            //elPrimerCarro.NumLlantas = 4;
            //elPrimerCarro.NumPuertas = 2;


            //MoldeDeCarro elSegundoCarro = new MoldeDeCarro();
            //elSegundoCarro.Color = "verde";           
            //elSegundoCarro.NumPuertas = 4;

            //string marca = Ayudas.Marcas.Mazda.ToString();
            //string marca2 = Convert.ToString(Ayudas.Marcas.Mazda);
            //string marca3 = (String)Ayudas.Marcas.Mazda;

            

            MoldeDeCarro elTercerCarro = new MoldeDeCarro(4,4,Colores.Amarillo.ToString(), Marcas.Mazda.ToString());
            
            MoldeDeCarro elCuartoCarro = new MoldeDeCarro(2,4, Marcas.Mazda.ToString());
            elCuartoCarro.Color = "que cambia con la luz";

            MoldeDeCarro elQuintoCarro = new MoldeDeCarro(4, 4, Colores.Azul.ToString(), Marcas.Mazda.ToString());
        }       
    }
}


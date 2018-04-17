using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeAvion : MoldeVehiculoHijo
    {

        public MoldeAvion(int _numPuertas, int _numllantas, string _color, string _marca)
            : base(_numPuertas, _numllantas, _color, _marca)
        {
        }

        public MoldeAvion(int _numPuertas, int _numllantas, string _marca)
            : base(_numPuertas, _numllantas, _marca)
        {

        }

        #region Propiedades

        public int Altura { get; set; }

        #endregion


        #region Metodos

        /// <summary>
        /// este metodo me controla la velocidad cuando acelera
        /// </summary>
        /// <param name="_presionPedalAcelerar"></param>
        public void AumentarAltura(int _presionPedalAltura)
        {
            if (_presionPedalAltura > 0)
                Altura = _presionPedalAltura * 2;

            Altura = 0;
        }

        #endregion

    }
}

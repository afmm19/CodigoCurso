using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeBicicleta : MoldeVehiculoHijo
    {

        public MoldeBicicleta(int _numllantas, string _color, string _marca)
            : base(_numllantas, _color, _marca)
        {

        }

        #region Propiedades


        #endregion

        #region Metodos
        /// <summary>
        /// esta función permite que la bicicleta se mueva
        /// </summary>
        /// <param name="_accionDePedalear"></param>
        public void Pedalear(int _accionDePedalear)
        {
            if (_accionDePedalear > 0)
                Velocidad = _accionDePedalear * 2;

            Velocidad = 0;
        }


        #endregion


    }
}

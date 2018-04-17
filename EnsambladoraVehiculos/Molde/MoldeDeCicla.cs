using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos.Molde
{
    /// <summary>
    /// este es un molde para crear carros
    /// </summary>
    public class MoldeDeCicla
    {
        public MoldeDeCicla(int _numllantas, string _color, string _marca)
        {           
            NumLlantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        public MoldeDeCicla(int _numllantas, string _marca)
        {
            
            NumLlantas = _numllantas;           
            Marca = _marca;
        }


        #region Propiedades
       

        /// <summary>
        /// esta propiedad me guarda el numero de llantas que va tener el carro
        /// </summary>
        public int NumLlantas { get; set; }

        /// <summary>
        /// esta propiedad me va a guardar el color ddel carro
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// esta propiedad me guarda la velociadad actual del carro
        /// </summary>
        public int Velocidad { get; set; }

        /// <summary>
        /// esta propiedad me guarda la marca del carro
        /// </summary>
        public string Marca { get; set; }

        #endregion

        #region Metodos
       

        /// <summary>
        ///  este metodo me controla la velocidad cuando frena
        /// </summary>
        /// <param name="_presionPedalFreno"></param>
        public void Frenar(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0)
                Velocidad = _presionPedalFreno / 2;
        }
              
        #endregion

    }
        
}

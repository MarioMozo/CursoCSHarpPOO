using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesAppp.Models
{

    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;  //Tipo de dato enum

        //Constructor de la clase
        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }

}

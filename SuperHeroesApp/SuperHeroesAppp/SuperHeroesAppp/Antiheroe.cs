using SuperHeroesAppp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesAppp
{
    internal class Antiheroe : SuperHeroe
    {
        public string AccionAntiheroe(string accion)
        {   
            return $"El antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}

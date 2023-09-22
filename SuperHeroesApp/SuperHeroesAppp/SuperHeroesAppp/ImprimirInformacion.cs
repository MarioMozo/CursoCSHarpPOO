using SuperHeroesAppp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesAppps
{
    internal class ImprimirInformacion
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe) {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"IdentidadSecreta: {superHeroe.IdentidadSecreta}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
        }
    }
}

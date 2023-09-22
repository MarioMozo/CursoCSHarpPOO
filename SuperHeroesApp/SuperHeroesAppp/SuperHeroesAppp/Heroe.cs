﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesAppp
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarMundo();
        public virtual string SalvarTierra()
        {
            return $"{Nombre} ha salvado la tierra";
        }
    }
}

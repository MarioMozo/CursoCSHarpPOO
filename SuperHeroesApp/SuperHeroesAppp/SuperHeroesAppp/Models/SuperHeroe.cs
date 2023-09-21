using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesAppp.Models
{
    class SuperHeroe : Heroe
    {
        private string _Nombre;
        public int Id = 1;
        public override  string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value.Trim(); }     //Esto hace que limpie espacios en blanco de una cadena  
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }



        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;  //TIPO DE DATO LIST<>
        public bool PuedeVolar;

        //Este es el constructor de la clase. 
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
        //Creación del metodo() dentro de la clase SuperHeroe{}
        public string UsarSuperPoderes()
        {
            StringBuilder concatenarStrings = new StringBuilder(); //Metodo de C# para concatenar cadenas 
            foreach (var item in SuperPoderes)
            {
                //FORMA 1: Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre}");
                concatenarStrings.AppendLine($"{IdentidadSecreta} esta usando el super poder {item.Nombre}"); //AppendLine = Va concatenando el objeto  Signo $, string interpolation
            }
            return concatenarStrings.ToString();
        }

        public override string SalvarMundo()
        {
            return $"{Nombre} ha salvado el mundo";
        }

        public override string SalvarTierra()
        {
            //return base.SalvarTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }

}

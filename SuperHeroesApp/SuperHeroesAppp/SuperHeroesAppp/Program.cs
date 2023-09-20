// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Puede volar y plaenar en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;


var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();



superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark";
superman.Ciudad = "Metropolis";
superman.Vuela = true;
superman.SuperPoderes = new[] { "Rayos equis", "Volar", "Fuerza", "Rayos lazer" }; 

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool Vuela;
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;  //Tipo de dato enum
}

//Enum: Enumeración de datos

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}

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
superman.PuedeVolar = true;
//Se crea un tipo de dato List en vez de un Array.
List<SuperPoder> poderSuperman = new List<SuperPoder>(); //ESTO ES UN TIPO DE OBJETO LISTA (COLEECIÓN DE ELEMENTOS)
poderSuperman.Add(poderVolar);
poderSuperman.Add(superFuerza);
superman.SuperPoderes = poderSuperman;
superman.UsarSuperPoderes();            //Aqui se esta llamando al metodo.


//superman.SuperPoderes = new[] { "Rayos equis", "Volar", "Fuerza", "Rayos lazer" }; 

class SuperHeroe
{
    public int Id;
    public string Nombre;
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
    public void UsarSuperPoderes()
    {
        foreach (var item in SuperPoderes)
        {
            Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre}");                 //Signo $, string interpolation

        }
    }
}





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

//Enum: Enumeración de datos

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}
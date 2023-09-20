
using SuperHeroesAppp.Models;
using System.Text; 

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Puede volar y plaenar en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;


var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "  Superman";
superman.IdentidadSecreta = "Clark";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;


//Console.WriteLine(superman == superman2);   // Aqui compara externamente si son iguales, pero no los valores internos a diferencia de la funcion Record. 
//Es otro metodo de crear propiedades  con la estructura Record
SuperHeroeRecord superHeroeRecord = new SuperHeroeRecord(1, "Superman", "Clark Kent");
//SuperHeroeRecord superHeroeRecord2 = new SuperHeroeRecord(1, "Superman", "Clark Kent");

//Console.WriteLine(superHeroeRecord2 == superHeroeRecord); //Indicará que si son iguales, ya que la estrucutra Record, lo revisa internamente a diferencia de la esctructura clasica 
//Se crea un tipo de dato List en vez de un Array.
//List<SuperPoder> poderSuperman = new List<SuperPoder>(); //ESTO ES UN TIPO DE OBJETO LISTA (COLEECIÓN DE ELEMENTOS)
//poderSuperman.Add(poderVolar);
//poderSuperman.Add(superFuerza);
//superman.SuperPoderes = poderSuperman;
//string resultSuperPoderes =  superman.UsarSuperPoderes();            //Aqui se esta llamando al metodo y se esta guardando en una variable.
//Console.WriteLine(resultSuperPoderes); //Se imprime la variable

//superman.SuperPoderes = new[] { "Rayos equis", "Volar", "Fuerza", "Rayos lazer" }; 



//Enum: Enumeración de datos

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);

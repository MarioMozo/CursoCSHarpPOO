
using SuperHeroesAppp;
using SuperHeroesAppp.Models;
using SuperHeroesAppps;
using System.Text; 

var imprimirInformacion = new ImprimirInformacion();

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Puede volar y plaenar en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;


var superFuerza = new SuperPoder(); 
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInformacion.ImprimirSuperHeroe(superman);


List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string salvarMundo = superman.SalvarMundo();
Console.WriteLine(salvarMundo);
string savlarTierra = superman.SalvarTierra();
Console.WriteLine(savlarTierra);



var wolverine = new Antiheroe();
wolverine.Id = 2;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

imprimirInformacion.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(poderVolar);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultSuperPoder = wolverine.UsarSuperPoderes();
Console.WriteLine(resultSuperPoder);

string accionAntiheroe = wolverine.AccionAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);



//SuperHeroeRecord superHeroeRecord = new SuperHeroeRecord(1, "Superman", "Clark Kent");


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);

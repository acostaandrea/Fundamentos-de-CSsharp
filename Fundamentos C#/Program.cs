using Fundamentos_C_.Models;

/*int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0};
for (int i = 0; i < numeros.Length; i++)
{

}

foreach (int i in numeros)
{
    Console.WriteLine(i);
}

List<int> list = new List<int>();
list.Add(1);
list.Remove(1);

List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10)};
cervezas.Add(new Cerveza(20, "stout"));
Cerveza erdinger = new Cerveza(20, "cerveza de trigo");
cervezas.Add(erdinger);

var bebidaAlcoholica = new Vino(100);
MostrarRecomendación(bebidaAlcoholica);

static void MostrarRecomendación(IBebidaAlcoholica bebida)
{
    bebida.MaxRecomendado();

}*/

CervezaBD cervezaBD = new CervezaBD();
var cervezas = cervezaBD.Get();
foreach(var cerveza in cervezas)
{
    Console.WriteLine(cerveza.Nombre);
}

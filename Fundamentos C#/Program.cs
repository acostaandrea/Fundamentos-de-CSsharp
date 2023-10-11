using Fundamentos_C_.Models;
using Fundamentos_C_;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Fundamentos_C_.Service;
using Fundamentos_C_.Errors;

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

//CervezaBD cervezaBD = new CervezaBD();

//insertamos nueva cerveza
/*{
    Cerveza cerveza = new Cerveza(15, "Pale ale");
    cerveza.Marca = "Minerva";
    cerveza.Alcohol = 6;
    cervezaBD.Add(cerveza);
}*/
//edita datos cerveza
/*{
    Cerveza cerveza = new Cerveza(15, "Pale ale");
    cerveza.Marca = "Minerva";
    cerveza.Alcohol = 5;
    cervezaBD.Edit(cerveza, 4);
}*/

//eliminar registro
/*{   
    cervezaBD.Delete(4);
}*/



//obtener todas las cervezas
/*var cervezas = cervezaBD.Get();
foreach(var cerveza in cervezas)
{
    Console.WriteLine(cerveza.Nombre);
}*/

//Cerveza cerveza = new Cerveza(10, "Cerveza");

//string miJson = JsonSerializer.Serialize(cerveza);
//File.WriteAllText("objeto.txt", miJson);

//string miJson = File.ReadAllText("objeto.txt");

//Cerveza cerveza = JsonSerializer.Deserialize<Cerv//eza>(miJson);

//string url = "https://jsonplaceholder.typicode.com/posts";
//HttpClient client = new HttpClient();

//HTTP GET
/*var htppResponse = await client.GetAsync(url);

if (htppResponse.IsSuccessStatusCode)
{
    var content = await htppResponse.Content.ReadAsStringAsync();
    List<Post> posts = JsonSerializer.Deserialize<List<Post>>(content);
    foreach(var objeto in posts)
    {
        Console.WriteLine(objeto.title);
    }
}*/

// HTTP POST
/*Post post = new Post()
{
    userId = 50,
    body = "Hola como estan",
    title = "pueba"
};

var data = JsonSerializer.Serialize<Post>(post);
HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

var httpResponse = await client.PostAsync(url, content);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    var postResult =JsonSerializer.Deserialize<Post>(result);
   
}*/

//HTTP PUT
//string url2 = "https://jsonplaceholder.typicode.com/posts/1";
/*Post post = new Post()
{
    userId = 50,
    body = "Hola como estan",
    title = "pueba"
};

var data = JsonSerializer.Serialize<Post>(post);
HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

var httpResponse = await client.PutAsync(url2, content);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    var postResult =JsonSerializer.Deserialize<Post>(result);
   
}*/

//HTTP DELETE
/*Post post = new Post()
{
    userId = 50,
    body = "Hola como estan",
    title = "pueba"
};*/

//var data = JsonSerializer.Serialize<Post>(post);
//HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

/*var httpResponse = await client.DeleteAsync(url2);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    //var postResult = JsonSerializer.Deserialize<Post>(result);

}*/

// GENERICS

/*{
    var cerveza = new Cerveza()
    { Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticus" };

    var post = new Post() { body = "soy un body", title = "hola", userId = 50 };

    Fundamentos_C_.Service.SendRequest<Post> service = new Fundamentos_C_.Service.SendRequest<Post>();

    var cervezaRespuesta = await service.Send(post);
}*/


//LINQ

//List<int> numeros = new List<int>() { 1, 5, 7, 89, 6, 8 };

//var numero7 = numeros.Where(d => d == 7).FirstOrDefault();

/*var numerosOrdenados = numeros.OrderBy(d => d);

foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}*/

//var total = numeros.Sum(d => d);

/*List<Bar> bares = new List<Bar>()
{
    new Bar("El bar")
    {
        cervezas = new List<Cerveza>()
        {
             new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
             new Cerveza(){ Alcohol = 8, Cantidad = 10, Nombre = "Ticus", Marca = "Colima"},
             new Cerveza(){ Alcohol = 7, Cantidad = 10, Nombre = "Stout", Marca = "Minerva" },

        }
    },
    new Bar("El bar 2")
    {
        cervezas = new List<Cerveza>()
        {
             new Cerveza(){ Alcohol = 8, Cantidad = 10, Nombre = "Ticus", Marca = "Colima"},
             new Cerveza(){ Alcohol = 6, Cantidad = 10, Nombre = "Piedra Lisa", Marca = "Colima" }

        }
    }
};

List<Cerveza> cervezas = new List<Cerveza>()
{
    new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
    new Cerveza(){ Alcohol = 8, Cantidad = 10, Nombre = "Ticus", Marca = "Colima"},
    new Cerveza(){ Alcohol = 7, Cantidad = 10, Nombre = "Stout", Marca = "Minerva" },
    new Cerveza(){ Alcohol = 6, Cantidad = 10, Nombre = "Piedra Lisa", Marca = "Colima" }
};

var cervezasOrdenadas = from d in cervezas
                        where d.Nombre == "Pale Ale" && d.Marca == "Minerva"
                        orderby d.Nombre
                        select d;

foreach(var cerveza in cervezas)
{
    Console.WriteLine(cerveza.Nombre + cerveza.Marca);


var bar = (from d in bares
          where d.cervezas.Where(c => c.Nombre == "Ticus").Count() > 0
          select d).ToList();*/


// CONTROL DE SITUACIONES INESPERADAS

try
{
    var SearcherBeer = new SearcherBeer();
    var cantidad = SearcherBeer.GetCantidad("jsdnfjsdh");
    Console.WriteLine("Todo bien");

}
catch (BeerNotFoundException ex)
{
    Console.WriteLine(ex.Message);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
finally
{
    Console.WriteLine("Se termino");
}













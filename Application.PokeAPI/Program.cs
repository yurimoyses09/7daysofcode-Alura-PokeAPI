// See https://aka.ms/new-console-template for more information

#region [ Referencias ]

using Application.PokeAPI.Models;
using Application.PokeAPI.Services;
using Application.PokeAPI.Util;
using Newtonsoft.Json;

#endregion

Console.WriteLine(Constantes.cabecario);

/// Obter especie do pokemon
Console.WriteLine(Constantes.entradaDeDados);
var especie = Convert.ToString(Console.ReadLine());

/// Realizar chamada da api pokepi
HttpResponseMessage responseMessage = ServicesPokeApi.PokeAPIService(especie);

/// retornar informação ao usuario via console
Mascote mascote = JsonConvert.DeserializeObject<Mascote>(responseMessage.Content.ReadAsStringAsync().Result);

Console.WriteLine(string.Format(Constantes.cabecarioRetorno, especie.ToUpper()));

Console.WriteLine($"Nome especie: {mascote.name}");
Console.WriteLine($"Altura: {mascote.height}");
Console.WriteLine($"Peso: {mascote.weight}");
Console.WriteLine($"Habilidades: ");
mascote.abilities.ForEach(delegate (Habilidade habilidade) { Console.WriteLine($"{habilidade.ability.name}"); });

Console.WriteLine(Constantes.rodape);

Console.ReadKey();
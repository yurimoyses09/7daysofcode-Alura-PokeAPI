namespace Application.PokeAPI.Services
{
    public class ServicesPokeApi
    {
        public static HttpResponseMessage PokeAPIService(string especie)
        {
            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{especie}";
                HttpResponseMessage responseMessage = new HttpClient().GetAsync(url).Result;

                return responseMessage;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

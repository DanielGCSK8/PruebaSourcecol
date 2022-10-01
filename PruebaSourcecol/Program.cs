using Newtonsoft.Json;
using PruebaSourcecol;
using System.Net.Http.Headers;

class program
{

    private static readonly HttpClient client = new HttpClient();

    static void Main(string[] args)
    {
        ProcessApi();
    }
    private static void ProcessApi()
    {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        var streamTask = client.GetAsync("https://rickandmortyapi.com/api/character").Result;
        var result = streamTask.Content.ReadAsStringAsync().Result;
        var res = JsonConvert.DeserializeObject<RickMorty>(result);
        foreach (var rm in res.Results)
            Console.WriteLine(rm.Name);

    }
}
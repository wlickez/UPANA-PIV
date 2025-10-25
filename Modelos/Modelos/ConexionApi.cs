
namespace Modelos
{
    public class ConexionApi : IConexionApi
    {
        private string uri = "https://localhost:7210/api/";
        public async Task<string> Peticion(string complemento, int tipo)
        {
            HttpMethod method;
            var client = new HttpClient();
            switch (tipo)
            {
                case 1:
                    method = HttpMethod.Get;
                    break;
                case 2:
                    method = HttpMethod.Post;
                    break;
                case 3:
                    method = HttpMethod.Put;
                    break;
                default:
                    method = HttpMethod.Get;
                    break;
            }

            var request = new HttpRequestMessage(method, uri + complemento);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

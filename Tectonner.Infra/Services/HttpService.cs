using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tectonner.Infra.Services;

public class HttpService
{
    private readonly HttpClient _httpClient;

    public HttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable> DataBase()
    {
        using (var connection = new MySqlConnection(_options.Value.ConnectionString))
        {
            try
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<OfferDbResponse>(OffersCtaSimulationQueries.GetOffersByType, param);
            }
            catch (Exception ex)
            {
                _logger.LogWarning("Erro ao conectar ao banco, GetOffersByType: {msg}", ex.ToString());
                return Enumerable.Empty<OfferDbResponse>();
            }
        }
    }
}

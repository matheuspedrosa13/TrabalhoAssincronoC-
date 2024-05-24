using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tectonner.Domain.Entities;
using Tectonner.Repo.Interfaces;
using Npgsql;
using Microsoft.Extensions.Options;
using Tectonner.Domain;

namespace Tectonner.Repo.Implementations;

public class RepoCliente : IRepoCliente
{

    private readonly IOptions<PostgreConfiguration> _options;

    public RepoCliente(IOptions<PostgreConfiguration> options) 
    {
        _options = options;
    }

    public async Task<Cliente> GetCliente(int id)
    {
        Cliente cliente = null;
        using (var connection = new NpgsqlConnection(_options.Value.ConnectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Cliente WHERE Id = {id}";

            using (var command = new NpgsqlCommand(query, connection))
            {

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            CodigoCliente = reader.GetString(reader.GetOrdinal("CodigoCliente")),
                            NomeCliente = reader.GetString(reader.GetOrdinal("NomeCliente")),
                            EnderecoCliente = reader.GetString(reader.GetOrdinal("EnderecoCliente"))
                        };
                    }
                }
            }
        }
        return cliente;
    }
}

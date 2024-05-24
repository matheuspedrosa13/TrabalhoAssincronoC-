using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tectonner.Domain.Entities;
using Tectonner.Repo.Interfaces;
using Tectonner.Service.Implementations;

namespace Tectonner.Service.Interface;

public class ServiceCliente : IServiceCliente
{
    private readonly IRepoCliente _repoCliente;

    public ServiceCliente (IRepoCliente repoCliente)
    {
        _repoCliente = repoCliente;
    }

    public async Task<Cliente> GetCliente(int id)
    {
        return await _repoCliente.GetCliente(id);
    }

}

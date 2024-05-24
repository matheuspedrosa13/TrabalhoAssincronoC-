using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tectonner.Domain.Entities;

namespace Tectonner.Repo.Interfaces;

public interface IRepoCliente
{
    Task<Cliente> GetCliente(int id);
}

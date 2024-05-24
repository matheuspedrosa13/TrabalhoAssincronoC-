using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tectonner.Domain.Entities;

namespace Tectonner.Service.Implementations;

public interface IServiceCliente
{
    Task<Cliente> GetCliente(int id);
}

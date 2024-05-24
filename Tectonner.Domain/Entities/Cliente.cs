using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tectonner.Domain.Entities;

public class Cliente
{
    public string CodigoCliente { get; set; }
    public string NomeCliente { get; set; }
    public string EnderecoCliente { get; set; }

    public static implicit operator string(Cliente v)
    {
        throw new NotImplementedException();
    }
}
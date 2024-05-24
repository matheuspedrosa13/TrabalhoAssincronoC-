namespace Tectonner.Domain.Entities;

public class Pedido
{
    public string CodigoPedido { get; set; }
    public string CodigoCliente { get; set; }
    public decimal ValorPedido { get; set; }
    public string CodigoFornecedor { get; set; }
    public decimal? Custo { get; set; }
    public DateTime? DataPedido { get; set; }
    public string Itens { get; set; }
    public string CodigoVendedor { get; set; }

}

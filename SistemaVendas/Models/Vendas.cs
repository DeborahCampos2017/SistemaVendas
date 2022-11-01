using Microsoft.Data.SqlClient.Server;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVenda { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string ValorProduto { get; set; }
        public string NomeVendedor { get; set; }
        public string CpfVendedor { get; set; }
        public string EmailVendedor { get; set; }
        public EnumStatus Status { get; set; }
    }
}

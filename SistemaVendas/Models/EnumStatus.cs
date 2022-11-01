using System.Drawing;

namespace SistemaVendas.Models
{
    public enum EnumStatus
    {
        PagamentoPendente,
        PagamentoAutorizado,
        EnviadoTransportadora,
        Entregue,
        Cancelada,
    }

    class Test
    {

        static string AtualizarStatus(EnumStatus c)
        {
            switch (c)
            {
                case EnumStatus.PagamentoPendente:
                    return "Pagamento Autorizado";

                case EnumStatus.PagamentoAutorizado:
                    return "Enviado à Transportadora";

                case EnumStatus.EnviadoTransportadora:
                    return "Entregue";

                default:
                    return "Pagamento Pendente";
            }
        }
    }
}

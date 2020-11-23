using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnumEComp.Entities.Enums
{
    enum PedidoStatus : int
    {
        PagamentoPendente,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
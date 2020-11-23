using ExEnumEComp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExEnumEComp.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, PedidoStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void RemoverItem(PedidoItem item)
        {
            Items.Remove(item);
        }

        public void AddItem(PedidoItem item)
        {
            Items.Add(item);
        }

        private double Total()
        {
            double soma = 0.0;
            foreach (PedidoItem item in Items)
            {
                soma = soma + item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do Pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("items do pedido:");
            foreach (PedidoItem kkk in Items)
            {
                sb.AppendLine(kkk.ToString());
            }
            sb.AppendLine("preco total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
    
using ExEnumEComp.Entities;
using ExEnumEComp.Entities.Enums;
using System;
using System.Collections.Specialized;

namespace ExEnumEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("E-Mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime nasc = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, nasc);

            Console.WriteLine("Informe os dados do pedido");
            Console.Write("Status: ");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens o pedido vai ter?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Informe dados do " + i + "# item: ");
                Console.Write("Produto: ");
                string produtonome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Produto produto = new Produto(produtonome, preco);

                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                PedidoItem Item = new PedidoItem(qtd, preco, produto);

                pedido.AddItem(Item);
            }
            Console.WriteLine();
            Console.WriteLine("::::::::::::I:N:F:O:R:M:A:Ç:O:E:S::D:O::P:E:D:I:D:O:::::::::::::");
            Console.WriteLine(pedido);

        }
    }
}
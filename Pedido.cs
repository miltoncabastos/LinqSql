using System;
using System.Security.Cryptography;

namespace LinqSql
{
    public class Pedido
    {
        public Pedido(string descricao, int quantidadeItens, int quantidadeItensRetirados )
        {
            Descricao = descricao;
            QuantidadeItens = quantidadeItens;
            QuantidadeItensRetirados = quantidadeItensRetirados;
        }

        public string Descricao { get; private set; }

        public int QuantidadeItens { get; private set; }

        public int QuantidadeItensRetirados { get; private set; }

        public bool PedidoFinalizado()
        {
            var finalizado = QuantidadeItensRetirados >= QuantidadeItens;
            Console.WriteLine("O {0} foi verificado: {1}", Descricao, finalizado);
            return finalizado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LinqSql
{
    class Program
    {
        const int quantidadeDeRegistros = 50000;
        private static Random _random;

        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            //Console.WriteLine("---- INÍCIO DA EXECUÇÃO");

            _random = new Random();

            var lista = CriarListaGigante();

            ExecutarExemplos(lista);

            watch.Stop();
            Console.WriteLine("---- FIM DA EXECUÇÃO: {0}", watch.ElapsedMilliseconds);
        }

        private static IList<Pedido> CriarListaGigante()
        {
            IList<Pedido> pedidos = new List<Pedido>();
            for (int i = 1; i < quantidadeDeRegistros; i++)
            {
                string descricao = $"Pedido {i.ToString().PadLeft(2, '0')}";
                int quantidadeItens = _random.Next(1, 30);
                int quantidadeItensRetirados = _random.Next(0, 30);
                
                Pedido pedido = new Pedido(descricao, quantidadeItens, quantidadeItensRetirados);

                pedidos.Add(pedido);
            }
            return pedidos;
        }

        private static void ExecutarExemplos(IList<Pedido> lista)
        {
            //TesteConsulta(lista);
            //TesteComToList(lista);
            //TesteComToArray(lista);
            //TesteComCount(lista);
            //TesteComDoisCounts(lista);
            //TesteComDoisCountsEToList(lista);
            //TesteComFirstOrDefault(lista);
            //TesteComFirstOrDefaultEToList(lista);
            TesteComForEach(lista);
        }

        private static void TesteConsulta(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado());
        }

        private static void TesteComToList(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).ToList();
        }

        private static void TesteComToArray(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).ToArray();
        }

        private static void TesteComCount(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).Count();
        }

        private static void TesteComDoisCounts(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado());
            Console.WriteLine("- Temos {0} registros", consulta.Count());
            Console.WriteLine("********");
            Console.WriteLine("- Temos {0} registros", consulta.Count());
        }

        private static void TesteComDoisCountsEToList(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).ToList();
            Console.WriteLine("- Temos {0} registros", consulta.Count());
            Console.WriteLine("********");
            Console.WriteLine("- Temos {0} registros", consulta.Count());
        }

        private static void TesteComFirstOrDefault(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).FirstOrDefault();
        }

        private static void TesteComFirstOrDefaultEToList(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado()).ToList().FirstOrDefault();
        }

        private static void TesteComForEach(IList<Pedido> lista)
        {
            var consulta = lista.Where(x => x.PedidoFinalizado());

            foreach (var pedido in consulta)
            {
                Console.WriteLine("Iterei no foreach");
            }
        }
    }
}

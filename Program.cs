using System;

namespace ProjetoProprio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produtos consignado = new Produtos();
            //consignado.ProdutoConsignado = new Consignado();
            //Produtos cartao = new Produtos();
            //cartao.ProdutoCartao = new Cartao();
            //Produtos crediario = new Produtos();
            //crediario.ProdutoCrediario = new Crediario();


            //Console.WriteLine("Digite 1 para acessar");
            //string comecar = Console.ReadLine();

            //while (comecar == "1")
            //{


            //    Console.WriteLine("Você deseja incluir produção ou consultar a sua produção?");
            //    Console.WriteLine("1- Para incluir");
            //    Console.WriteLine("2- Para consultar");
            //    string opcao1 = Console.ReadLine();

            //    if (opcao1 == "1")
            //    {

            //        Console.WriteLine("Escolha o produto para inclusão:");
            //        Console.WriteLine("1 - Cartão");
            //        Console.WriteLine("2 - Consignado");
            //        Console.WriteLine("3 - Crediário");
            //        string opcao2 = Console.ReadLine();

            //        switch (opcao2)
            //        {
            //            case "1":
            //                Console.WriteLine("Você escolheu Cartão");
            //                Console.WriteLine("Coloque o valor do Cartão");
            //                double valorCartao = double.Parse(Console.ReadLine());
            //                cartao.ProdutoCartao.ValorCartao = valorCartao;
            //                Console.WriteLine("Coloque o peso do Cartão");
            //                double pesoCartao = double.Parse(Console.ReadLine());
            //                cartao.ProdutoCartao.PesoCartao = pesoCartao;
            //                Console.Write("O valor feito de Cartão foi:");
            //                Console.WriteLine(cartao.ProdutoCartao.CalculoCartao(valorCartao, pesoCartao));

            //                break;

            //            case "2":
            //                Console.WriteLine("Você escolheu Consignado");
            //                Console.WriteLine("Coloque o valor do Consignado");
            //                double valorConsignado = double.Parse(Console.ReadLine());
            //                consignado.ProdutoConsignado.ValorConsignado = valorConsignado;
            //                Console.WriteLine("Coloque o peso do Consignado");
            //                double pesoConsignado = double.Parse(Console.ReadLine());
            //                consignado.ProdutoConsignado.PesoConsignado = pesoConsignado;
            //                Console.Write("O valor feito de Consignado foi: ");
            //                Console.WriteLine(consignado.ProdutoConsignado.CalculoConsignado(valorConsignado, pesoConsignado));
            //                break;

            //            case "3":
            //                Console.WriteLine("Você escolheu Crediário");
            //                Console.WriteLine("Coloque o valor do Crediário");
            //                double valorCrediario = double.Parse(Console.ReadLine());
            //                consignado.ProdutoConsignado.ValorConsignado = valorCrediario;
            //                Console.WriteLine("Coloque o peso do Crediário");
            //                double pesoCrediario = double.Parse(Console.ReadLine());
            //                consignado.ProdutoConsignado.PesoConsignado = pesoCrediario;
            //                Console.WriteLine("Teve seguro prestamista? 1- Sim / 2- Não");
            //                int seguroCrediario = int.Parse(Console.ReadLine());
            //                crediario.ProdutoCrediario.IncluirSeguro(seguroCrediario);
            //                Console.Write("O valor feito de crediário foi: ");
            //                Console.WriteLine(crediario.ProdutoCrediario.CalculoCrediario(valorCrediario, pesoCrediario));
            //                break;

            //            default:
            //                Console.WriteLine("Escolha uma das opções acima");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Escolha o produto para consultar:");
            //        Console.WriteLine("1 - Cartão");
            //        Console.WriteLine("2 - Consignado");
            //        Console.WriteLine("3 - Crediário");
            //        string opcao2 = Console.ReadLine();

            //        switch (opcao2)
            //        {
            //            case "1":
            //                Console.WriteLine("O valor feito foi: " + cartao.ProdutoCartao.ConsultarProducaoCartao());
            //                break;

            //            case "2":
            //                Console.WriteLine("O valor feito foi: " + consignado.ProdutoConsignado.ConsultarProducaoConsignado());
            //                break;

            //            case "3":
            //                Console.WriteLine("O valor feito foi: " + crediario.ProdutoCrediario.ConsultarProducaoCrediario());
            //                break;

            //            default:
            //                Console.WriteLine("Escolha uma das opções acima");
            //                break;
            //        }
            //    }

            //    Console.WriteLine("Para continuar digite 1");
            //    comecar = Console.ReadLine();
            //}

            Renegociacao renegociacao = new Renegociacao();
            renegociacao.valor = 10000;
            PonderadorTeste ponderador = new PonderadorTeste();
            ponderador.Calcular(renegociacao);

            Console.WriteLine(ponderador.Guardar);


            
        }
    }
}

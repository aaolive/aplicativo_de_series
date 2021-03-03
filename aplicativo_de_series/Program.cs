using System;

namespace aplicativo_de_series
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // objeto de serie
            var rodaAppSerie = new Serie();
            // crio exemplos de series internamente
            rodaAppSerie.CriarSeriesDeExemplo();
            
            //rodaAppSerie.AdicionarSerie();

            // opcoes de uso do aplicativo
            int adicionarUmaSerie = 1;
            int mostrarSeries = 2;
            int alterarUmaSerie = 3;
            int excluirUmaSerie = 4;
            bool fecharAplicativo = false;
            // faz a interação pegando as escolhas do usuario
            while (fecharAplicativo == false)
            {
                //limpa tela antes de continuar
                Console.Clear();
                // exibe mensagem do app
                Console.WriteLine("....Aplicativo de series....\n");
                Console.WriteLine("Escolha uma das opcoes para executar: ");
                // recebe a opcao do usuario
                var resposta = Console.ReadLine();
                var opccaoDesejada = Convert.ToInt32(resposta);

                // faz a selecao conforme o desejo do usuario
                switch (opccaoDesejada)
                {
                    case 1:
                        rodaAppSerie.AdicionarSerie();
                        break;
                    case 2:
                        rodaAppSerie.MostrarSeries();
                        break;
                    case 3:
                        rodaAppSerie.AlterarSerie();
                        break;
                    case 4:
                        rodaAppSerie.ExcluirSerie();
                        break;
                    case 5:
                        if (opccaoDesejada == 5)
                        {
                            fecharAplicativo = true;
                        }
                        break;                    
                }

            }
            // pede confirmação para continuar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.Read();
        }
    }
}

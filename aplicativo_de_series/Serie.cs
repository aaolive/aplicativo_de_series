using System;
using System.Collections.Generic;
using System.Text;

namespace aplicativo_de_series
{
    class Serie : ISeries
    {
        // uma lista de series
        private List<Serie> listaDeSeries = new List<Serie>();

        // campos de dados
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Ano { get; set; }
        public Generos Genero { get; set; }

        // enum de generos para listar os mesmos
        public enum Generos
        {
            Ação = 1, Aventura, Comédia, Suspense, Terror
        }

        public void AdicionarSerie()
        {
            
            // limpa tela antes de exibir
            Console.Clear();
            // mensagem
            Console.WriteLine("Adicionando series\n");
            // crio um objeto de serie e preencho os dados            
            Serie novaSerie = new Serie();
            // recebe nome
            Console.WriteLine("Digite os dados para sua série");
            Console.Write("Nome: ");
            novaSerie.Nome = Console.ReadLine();
            // recebe descricao
            Console.Write("Descricao: ");
            novaSerie.Descricao = Console.ReadLine();
            // recebe o ano
            Console.Write("Ano: ");
            novaSerie.Ano = Console.ReadLine();
            // recebe o genero
            Console.WriteLine("Escolha o número do genero para sua série:");
            foreach (int numero in Enum.GetValues(typeof(Generos)) )
            {
                Console.Write($"{numero}: {Enum.GetName(typeof(Generos), numero)} ");
            }
            Console.WriteLine();
            Console.Write("Genero: ");
            novaSerie.Genero = (Generos)int.Parse(Console.ReadLine());
            // salvo a serie na lista
            listaDeSeries.Add(novaSerie);
            // mando uma confimação
            Console.WriteLine("A série foi adicionda.");

            // pede confirmação para continuar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        public void AlterarSerie()
        {
            // limpa tela antes de exibir
            Console.Clear();

            // mostra as series
            Console.WriteLine("Lista de series\n");
            MostrarSeries();

            // exibindo mensagem
            Console.WriteLine("Escolha a serie para alterar pelo nome");
            string nomeDaSerieParaAlterar;
            nomeDaSerieParaAlterar = Console.ReadLine();            

            // procuro a serie para modificar 
            foreach (var serie in listaDeSeries)
            {
                // caso encontre a serie pede os novos dados
                if (serie.Nome == nomeDaSerieParaAlterar)
                {
                    // variaveis para receber novos dados
                    string novoNome;
                    string novaDescricao;
                    string novoAno;
                    Generos novoGenero;

                    //recebe o novo nome
                    Console.WriteLine("Digite o novo nome");
                    Console.Write("Novo nome: ");
                    novoNome = Console.ReadLine();

                    //recebe o nova descricao
                    Console.WriteLine("Digite o nova decricao");
                    Console.Write("Nova descrição: ");
                    novaDescricao = Console.ReadLine();

                    //recebe o novo ano
                    Console.WriteLine("Digite o novo ano");
                    Console.Write("Novo ano: ");
                    novoAno = Console.ReadLine();

                    // recebe o novo genero
                    //Console.WriteLine("Escolha o número do genero para sua série:");
                    //foreach (int numero in Enum.GetValues(typeof(Generos)))
                    //{
                    //    Console.Write($"{numero}: {Enum.GetName(typeof(Generos), numero)} ");
                    //}
                    //Console.WriteLine();
                    //Console.Write("Genero: ");
                    //novoGenero = (Generos)int.Parse(Console.ReadLine());

                    // preenche com os novos dados caso necessario
                    if (novoNome.Length > 0)
                    {
                        serie.Nome = novoNome;
                    }
                    if (novaDescricao.Length > 0)
                    {
                        serie.Descricao = novaDescricao;
                    }
                    if (novoAno.Length > 0)
                    {
                        serie.Ano = novoAno;
                    }

                }
                else
                {
                    Console.WriteLine("A série não foi encontrada.");
                }
            }
            // pede confirmação para continuar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        // exclui uma serie pelo nome
        public void ExcluirSerie()
        {
            // limpa tela antes de exibir
            Console.Clear();
            // mostrando as series primeiro
            MostrarSeries();

            // campo de pesquisa
            string nomeParaPesquisar;
            Console.WriteLine("Digite o nome para pesquisar");
            Console.Write("Nome: ");
            nomeParaPesquisar = Console.ReadLine();
            foreach (var serie in listaDeSeries)
            {
                // se achou pelo nome irá remover
                if (nomeParaPesquisar.ToLower() == serie.Nome.ToLower())
                {
                    // recebe o indice do objeto
                    var indiceDaSerie = listaDeSeries.IndexOf(serie);
                    listaDeSeries.RemoveAt(indiceDaSerie);
                    Console.WriteLine("Série removida");
                }
                else
                {
                    Console.WriteLine("Não foi encontrada uma série com esse nome.");
                }
            }
            // pede confirmação para continuar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        public void MostrarSeries()
        {
            // limpa tela antes de exibir
            Console.Clear();
            Console.WriteLine("Monstrando series\n");
            // mostra as series na lista
            foreach (var serie in listaDeSeries)
            {
                Console.WriteLine($"# Serie: {serie.Nome}\n  Descrição: {serie.Descricao}\n  Genero: {serie.Genero}\n  Ano: {serie.Ano}\n");
            }
            // pede confirmação para continuar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        // metodo para criar series  de exemplo
        public void CriarSeriesDeExemplo()
        {
            // exemplos
            var serie1 = new Serie();
            var serie2 = new Serie();            

            serie1.Nome = "Supernatural";
            serie1.Descricao = "A série segue os irmãos Sam e Dean Winchester enquanto procuram por seu pai, John, que está caçando o demônio...";
            serie1.Ano = "2005";
            serie1.Genero = Generos.Terror;

            serie2.Nome = "Stranger Things";
            serie2.Descricao = "Will, um garoto de 12 anos, desaparece em Montauk, Long Island. Enquanto a polícia, família e amigos procuram respostas,...";
            serie2.Ano = "2016";
            serie2.Genero = Generos.Suspense;

            // põe as series na lista
            listaDeSeries.Add(serie1);
            listaDeSeries.Add(serie2);
        }
    }
}

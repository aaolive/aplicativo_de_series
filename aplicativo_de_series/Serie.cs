using System;
using System.Collections.Generic;
using System.Text;

namespace aplicativo_de_series
{
    class Serie : ISeries
    {
        // uma lista de series
        private List<Serie> minhaListaDeSeries;

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
            // crio um objeto de serie e preencho os dados
            Serie novaSerie = new Serie();
            Console.WriteLine("Digite os dados para sua série");
            Console.Write("Nome: ");
            novaSerie.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Descricao: ");
            novaSerie.Descricao = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ano: ");
            novaSerie.Ano = Console.ReadLine();
            Console.WriteLine("EWscolha um genero para sua série:");
            foreach (var numero in Enum.GetValues(typeof(Generos)) )
            {
                Console.Write($"{Enum.GetName(typeof(Generos), numero)} = {numero}, ");
            }
        }

        public void AlterarSerie()
        {
            throw new NotImplementedException();
        }

        public void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        public void MostrarSeries()
        {
            throw new NotImplementedException();
        }
    }
}

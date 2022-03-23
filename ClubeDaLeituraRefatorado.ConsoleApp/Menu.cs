using System;
namespace ClubeDaLeituraRefatorado.ConsoleApp
{
        public class Menu {

        public string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Digite a resposta de acordo com o comando que deseja executar!");
            Console.WriteLine("1 - Adicionar caixas");
            Console.WriteLine("2 - Adicionar revistas");
            Console.WriteLine("3 - Cadastrar amigos");
            Console.WriteLine("4 - Fazer empréstimos");

            Console.Write("Resposta: ");
            string resposta = Console.ReadLine();
            return resposta;
        }
    }
}
    


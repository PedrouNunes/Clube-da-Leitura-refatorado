using System;

namespace ClubeDaLeituraRefatorado.ConsoleApp
{
    public class TelaCadastroCaixas
    {
        public Caixa[] caixas;
        public int numeroCaixa;

        public string ExibirComandos()
        {
            Console.Clear();

            Console.WriteLine("Cadastrar caixa: ");
            Console.WriteLine("Digite a resposta de acordo com o comando que deseja executar!");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Vizualizar");
            Console.Write("Resposta: ");

            string resposta = Console.ReadLine();
            return resposta;
        }

        public void InserirCaixa()
        {
            Console.Clear();

            Console.Write("Digite a cor da caixa: ");
            string cor = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite a etiqueta da caixa: ");
            string etiqueta = Console.ReadLine();

            Caixa caixa = new Caixa();
            caixa.numero = ++numeroCaixa;
            caixa.etiqueta = etiqueta;
            caixa.cor = cor;


            int posicaoVazia = ObterPosicaoVazia();
            caixas[posicaoVazia] = caixa;

            
        }

        public void ExibirCaixas()
        {
            for (int i = 0; i < caixas.Length; i++) {
                if (caixas[i] == null) {
                    continue;
                }
                Caixa c = caixas[i];


                Console.WriteLine("Número: " + c.numero);
                Console.WriteLine("Cor: " + c.cor);
                Console.WriteLine("Etiqueta: " + c.etiqueta);
            }
        }

        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                    return i;
            }
            return -1;
        }
    

        
    }
}
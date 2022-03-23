using System;

namespace ClubeDaLeituraRefatorado.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            TelaCadastroCaixas telaCadastroCaixa = new TelaCadastroCaixas();
            while (true)
            {        
                string respostaMenu = menu.ExibirMenu();

                if (respostaMenu == "1")
                {
                    string resposta = telaCadastroCaixa.ExibirComandos();
                    switch (resposta)
                    {
                        case "1":
                            #region Inserir Caixa
                            telaCadastroCaixa.InserirCaixa();
                            break;
                        #endregion
                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            telaCadastroCaixa.ExibirCaixas();
                            Console.ReadLine();
                            break;
                            
                    }
                }
                
            }
        }

       
    }
}

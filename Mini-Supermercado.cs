using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Opcao_Caixa { Abrir = 1, Fechar = 0 };
        
        static void Main(string[] args)
        {
        
            
            float soma_total = 0;
            float soma_total_dinheiro=0;
            float soma_total_cartao=0;
            float pag_dinheiro = 0;
            float pag_cartao = 0;
           
            int index;
            
            
        
            do
            {
                Console.WriteLine("Digite  1 para ABRIR  0 para ENCERRAR");
                index = int.Parse(Console.ReadLine());
                Opcao_Caixa opcao_C = (Opcao_Caixa)index; // aqui converto o index para a variavel do tipo enum do tipo opcao caixa
                        switch (opcao_C)
                        {
                            case Opcao_Caixa.Abrir:
                            Console.WriteLine("Seu Caixa foi aberto!");
                                int opcao_abertura_caixa;
                                float soma = 0; // coloquei soma fora do loop para que o valor nao fosse perdido ao fim do loop 
                            do
                            {
                                Console.WriteLine("DIGITE 1 PARA ADICIONAR PRODUTOS 0 PARA ENCERRAR");
                                opcao_abertura_caixa = int.Parse(Console.ReadLine());
                                switch (opcao_abertura_caixa)
                                {
                                case 1:
                                    Console.WriteLine("Digite o nome do produto");
                                    String nome  = Console.ReadLine();
                                    Console.WriteLine("Digite o valor do produto");
                                    int valor = int.Parse(Console.ReadLine());
                                    
                                    soma += valor; // soma o total de compras que o cliente fez 

                                break;


                                case 0:
                                    Console.WriteLine("O valor total da sua compra é:");
                                    Console.WriteLine(soma);
                                    Console.WriteLine("Digite 1 para dinheiro\n 2 Para Cartao");
                                    int opcao_pag = int.Parse(Console.ReadLine());
                                        switch (opcao_pag)
                                        {
                                        case 1:
                                            Console.WriteLine("Voce selecionou Dinheiro!");
                                            pag_dinheiro =  soma * 5 / 100;
                                            Console.WriteLine("Seu desconto é de :");
                                            Console.WriteLine(pag_dinheiro);
                                            soma = soma - pag_dinheiro;
                                            Console.WriteLine("O valor total da sua compra ficou:");
                                            Console.WriteLine(soma);
                                            soma_total_dinheiro += soma;
                                        break;

                                        case 2:
                                            Console.WriteLine("Voce selecionou Cartao!");
                                            Console.WriteLine("O valor total da sua compra ficou:");
                                            Console.WriteLine(soma);
                                            soma_total_cartao += soma;
                                            break;

                                        default: Console.WriteLine("numero errado"); break;

                                        }

                                
                                break;

                                default:
                                Console.WriteLine("numero errrado");
                                break;
                                }    



                                
                            } while (opcao_abertura_caixa != 0);

                   
                            

                        break;


                         case Opcao_Caixa.Fechar:
                         Console.WriteLine("Seu CAIXA FOI FECHADO");
                         Console.WriteLine("O valor total em dinheiro e cartão é:");
                         soma_total = soma_total_dinheiro + soma_total_cartao;
                         Console.WriteLine(soma_total);
                         break;

                         default:
                         Console.WriteLine("numero errado");
                         break;


                        }

                             
            } while(index!=0);



            Console.ReadLine();
            
        }

        
        
    }
}

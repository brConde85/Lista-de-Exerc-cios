using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_DS__Exercicio1_Bruno_TDS_02_
{
    class Program
    {

        static void Main(string[] args)
        {
            // Instanciando a classe
            Class1 clas = new Class1();

            // variavel para utlização na função while
            char sair='n';
            
            while (sair != 's' && sair != 'S')
            {
                clas.Cabecalho1();
                int ex = Convert.ToInt32(Console.ReadLine()); 

                switch (ex)
                {
                    case 1:
                        { 
                            Console.Clear();
                            /*
                             * 1. Procure na internet um conversor de moeda. Escreva um programa que
                             * converta sua mesada de reais para dólar.

                             * 2. Continuando o programa anterior. Se sua mesada em dólares for maior que
                             * US$ 100,00 escreva:Vou comprar bitcoin;. Se for maior que US$ 200,00
                             * escreva: Vou investir no tesouro nacional;. Se for menor que U$100,00 escreva:
                             * Vou comprar bala.
                             */
                                                                                    
                            // chamando a o metodo cabecalho
                            clas.CabecalhoEx1();

                            Console.WriteLine("Informe o valor da sua mesada em R$: ");
                            // convertendo um tipo string para double"Parse"
                            clas.Reais = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a cotação do U$: ");
                            // convertendo um tipo string para double"Parse"
                            clas.Dolar = double.Parse(Console.ReadLine());

                            // exibindo o resultado da operção e ".ToString("F") para limitar em duas, as casas decimais após a virgula"
                            // se fosse ".ToString("C)" exibiria como valor monetário
                            // ou o chamando o método Math.Round (valor,2) da classe Math   
                            Console.WriteLine("Sua converção de mesada ficou U$: " + clas.Conversor(clas.Reais, clas.Dolar).ToString("F"));
                            Console.WriteLine("");

                            clas.Mensagem();


                            if (clas.Conversor(clas.Reais, clas.Dolar) >= 200)
                            {
                                Console.WriteLine("Vou investir no tesouro nacional");
                            }
                            else if (clas.Conversor(clas.Reais, clas.Dolar) < 100)
                            {
                                Console.WriteLine("Vou comprar bala");
                            }
                            else if (clas.Conversor(clas.Reais, clas.Dolar) >= 100)
                            {
                                Console.WriteLine("Vou comprar bitcoin");
                            }
                            // pausa o system
                            Console.ReadKey();
                            break;
                    }
                    case 2:
                        {
                            Console.Clear();
                            /*
                             * 1. Procure na internet um conversor de moeda. Escreva um programa que
                             * converta sua mesada de reais para dólar.

                             * 2. Continuando o programa anterior. Se sua mesada em dólares for maior que
                             * US$ 100,00 escreva:Vou comprar bitcoin;. Se for maior que US$ 200,00
                             * escreva: Vou investir no tesouro nacional;. Se for menor que U$100,00 escreva:
                             * Vou comprar bala.
                             */




                            // chamando a o metodo cabecalho
                            clas.CabecalhoEx1();

                            Console.WriteLine("Informe o valor da sua mesada em R$: ");
                            // convertendo um tipo string para double"Parse"
                            double real = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a cotação do U$: ");
                            // convertendo um tipo string para double"Parse"
                            double dolar = double.Parse(Console.ReadLine());

                            // exibindo o resultado da operção e ".ToString("F") para limitar em duas, as casas decimais após a virgula"
                            // se fosse ".ToString("C)" exibiria como valor monetário
                            // ou o chamando o método Math.Round (valor,2) da classe Math   
                            Console.WriteLine("Sua converção de mesada ficou U$: " + clas.Conversor(real, dolar).ToString("F"));
                            Console.WriteLine("");

                            clas.Mensagem();


                            if (clas.Conversor(real, dolar) >= 200)
                            {
                                Console.WriteLine("Vou investir no tesouro nacional");
                            }
                            else if (clas.Conversor(real, dolar) < 100)
                            {
                                Console.WriteLine("Vou comprar bala");
                            }
                            else if (clas.Conversor(real, dolar) >= 100)
                            {
                                Console.WriteLine("Vou comprar bitcoin");
                            }
                            // pausa o system
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            /*
                             * 3. Faça um programa que converta Fahrenheit em Celsius. Sabendo que a
                             * formula é C = (F – 32) / 1.8 e escreva na tela a temperatura em graus Celsius e
                             * em Fahrenheit.             
                            */
                            clas.CabecalhoEx3();
                            Console.WriteLine("Informe a temperatura em °F: ");
                            double temp = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("A temperatura correspondente em °C: " + clas.ConvertTemp(temp).ToString("F")); ;

                            // pausa o system
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            /*
                             * 4. Escreva um programa para ler o salário mensal atual de um funcionário e o
                             * percentual de reajuste de 6%. Calcular e escrever o valor do novo salário.
                             */
                            clas.CabecalhoEx4();
                            Console.WriteLine("Informe o valor do salário atual R$: ");
                            double salario = double.Parse(Console.ReadLine());
                            Console.WriteLine("O salário com a reajuste de 6%: "+clas.NewSal(salario).ToString("C"));
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            /*
                             *  5. Faça um programa que receba um valor que foi depositado e exiba o valor
                             *  com rendimento após um mês. Considere fixo o juro da poupança em 0,049% a. m.*/
                            clas.CabecalhoEx5();
                            clas.Reais = double.Parse(Console.ReadLine());
                            Console.WriteLine("O seu rendimento após 1 mês será: "+clas.Rendimento(clas.Reais).ToString("C"));
                            break;
                        }
                    case 6:
                        {
                            /* 6. Escreva um programa para ler o nome e a idade de uma pessoa, e exibir
                             * quantos dias de vida ela possui. Considere sempre anos completos, e que um
                             * ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida;
                             * veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.*/
                            Console.Clear();
                            clas.CabecalhoEx6();
                            // capturando o ano de nascimento
                            clas.AnoNasc = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o ano atual:");
                            // capturando o ano atual
                            clas.AnoAtual = int.Parse(Console.ReadLine());
                            
                            // idade do usuário
                            clas.Idade = clas.AnoAtual - clas.AnoNasc;

                            // calculando a tempo de vida de uma pessoa
                            clas.Total = clas.AnosVida(clas.Idade);
                            // resultado          
                            Console.WriteLine("Sua idade atual é: "+ clas.Idade +" Com um total de dias vividos de aproximadamente: " + (clas.Total + (clas.TotalAnos(clas.AnoNasc, clas.AnoAtual))));
                  
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            /*
                             * 7. Escreva um programa para ler o número total de eleitores de um município,
                             * o número de votos brancos, nulos e válidos. Calcular e escrever o percentual
                             * que cada um representa em relação ao total de eleitores.                             
                             */
                            clas.CabecalhoEx7();
                            clas.TotalHab = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o número de votos válidos dos habitantes: ");
                            clas.VotosVal = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o número de votos Nulos dos habitantes: ");
                            clas.VotosNul = int.Parse(Console.ReadLine());

                            if (clas.VotosBr() == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("O número de votos Brancos da cidade: ");
                                Console.WriteLine(clas.VotosBran);
                                Console.WriteLine("Votos são válidos");
                            }

                               else if (clas.VotosBr() == false)
                               { 
                                    Console.WriteLine("Os votos computados ultrapassam o número de habitates, operação inválida! ");
                                    Console.ReadKey();
                                    //Console.WriteLine("Deseja sair do sistema? (S/N):");
                                    //sair = Convert.ToChar(Console.ReadLine());
                               }
                           

                            break;
                        }
                    case 8:
                        {
                            Console.Clear();

                            /*
                             * 8. Escreva um programa para ler o salário mensal atual de um funcionário e
                             * aplicar um percentual de reajuste, calcular e escrever o valor do novo salário.                         
                             */
                            clas.CabecalhoEx8();
                            clas.Salario = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o percentual do reajuste (%): ");
                            clas.Reajuste = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("O salário com o reajuste ficou: " + clas.PercDeReajuste(clas.Salario, clas.Reajuste).ToString("C")); // ToString para mostrar o valor monetario 
                            Console.WriteLine();
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            /*
                             * 9. O custo de um carro novo ao consumidor é a soma do custo de fábrica com
                             * a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica).
                             * Supondo que o percentual do distribuidor seja de 28% e os impostos de 45%,
                             * escrever um programa para ler o custo de fábrica de um carro, calcular e
                             * escrever o custo final ao consumidor.                         
                             */
                            clas.CabecalhoEx9();
                            clas.Valor = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("O valor final do veículo após a a porcentagem do distribuidor e dos impostos: "+clas.valorVeiculo(clas.Valor).ToString("C"));
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();
                            clas.CabecalhoEx10();
                            /*
                             * 10. Uma revendedora de carros usados paga a seus funcionários vendedores
                             * um salário fixo por mês, mais uma comissão também fixa para cada carro
                             * vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um
                             * programa que leia o número de carros por ele vendidos, o valor total de suas
                             * vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e
                             * escreva o salário final do vendedor.                             
                             */

                            // valor carro * qtd (tot venda)
                            // 
                            clas.QtdCarVend = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o(s) valor(es) do(s) veículo(s) R$: ");
                            clas.ValorCarro = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("RESULTADO:");
                            Console.WriteLine("O valor total das vendas: " +clas.ValorTotVend(clas.ValorCarro,clas.QtdCarVend).ToString("C"));
                            Console.WriteLine();
                            Console.WriteLine("O salário fixo do vendedor: "+clas.SalarioVend.ToString("C"));
                            Console.WriteLine();
                            Console.WriteLine("O valor recebido por cada carro: "+clas.ValorPorCarro(clas.SalarioVend,clas.Comissao,clas.ValorCarro).ToString("C"));
                            Console.WriteLine();
                            Console.WriteLine("O salário final do vendedor foi: "+(clas.ValorPorCarro(clas.SalarioVend, clas.Comissao, clas.ValorCarro) * clas.QtdCarVend).ToString("C"));
                            Console.WriteLine();
                            break;
                        }
                    case 11:
                        {
                            Console.Clear();
                            /*
                            * 11. A Loja Mamão com Açúcar está vendendo seus produtos em 5 (cinco)
                            * prestações sem juros. Faça um programa que receba um valor de uma compra
                            * e mostre o valor das prestações.                             
                            */
                            clas.CabecalhoEx11();
                            clas.Valor = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o número de parcelas que deseja dividir(Sugestão '5'): ");
                            clas.Qtd = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("O valor das " + clas.Qtd + " parcelas ficou: "+clas.Parcelas(clas.Valor,clas.Qtd).ToString("C")+" por mês");
                            Console.WriteLine();                           
                            break;
                        }
                    case 12:
                        {
                            /*
                             * 12. Faça um algoritmo que receba o preço de custo de um produto e mostre o
                             * valor de venda. Sabe-se que o preço de custo receberá um acréscimo de
                             * acordo com um percentual informado pelo usuário.
                             */
                            Console.Clear();
                            clas.CabecalhoEx12();
                            clas.Valor = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o percentual de lucro que deseja receber (%):");
                            clas.Reajuste = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("O valor do produto após o reajuste ficou: "+clas.PercDeReajuste(clas.Valor,clas.Reajuste).ToString("C"));
                            Console.WriteLine();
                            break;
                        }
                    case 13:
                        {
                            Console.Clear();
                            /*
                             * 13. A padaria Hotpão vende uma certa quantidade de pães franceses e uma
                             * quantidade de broas a cada dia. Cada pãozinho custa R$ 0,50 e a broa custa
                             * R$ 4,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos
                             * pães e broas (juntos), e quanto deve guardar numa conta de poupança (10%
                             * do total arrecadado). Você foi contratado para fazer os cálculos para o dono.
                             * Com base nestes fatos, faça um programa para ler as quantidades de pães e
                             * de broas, e depois calcular os dados solicitados.
                             */

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            break;
                        }

                }
                
                

                
                Console.WriteLine("Você realmente deseja sair do sistema? (S/N):");
                sair =Convert.ToChar(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Autor: Bruno Luiz Panho Marciano");
                Console.WriteLine("Obrigado por utilizar o sistema!");
                Console.ReadKey();
            }
        }
    }
}

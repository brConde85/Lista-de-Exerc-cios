using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_DS__Exercicio1_Bruno_TDS_02_
{
    class Class1
    {
        // atributos exercicio 1 a 4
        private double reais, dolar;


        // atributos ex 5 e 8
        private double salario;
        private double reajuste;

        // atributos ex 6
        private int idade;
        private int anoAtual;
        private int anoNasc;
        private int total;

        // atributos ex 7
        private int totalHab;
        private int votosVal, votosNul, votosBran;

        // atributos ex 9, 11, 13 e 14
        private double valor;
        private int qtd,qtdBr;

        // atributos ex 10 e 14
        private double salarioVend = 2000;
        private double comissao = 0.05;
        private int qtdCarVend;
        private double valorCarro;
        

        // encapsulamento dos atributos (Getters e Setters)
        public double Reais { get => reais; set => reais = value; }
        public double Dolar { get => dolar; set => dolar = value; }
        public int Idade { get => idade; set => idade = value; }
        public int AnoAtual { get => anoAtual; set => anoAtual = value; }
        public int AnoNasc { get => anoNasc; set => anoNasc = value; }
        public int Total { get => total; set => total = value; }
        public int TotalHab { get => totalHab; set => totalHab = value; }
        public int VotosVal { get => votosVal; set => votosVal = value; }
        public int VotosNul { get => votosNul; set => votosNul = value; }
        public int VotosBran { get => votosBran; set => votosBran = value; }
        public double Salario { get => salario; set => salario = value; }
        public double Reajuste { get => reajuste; set => reajuste = value; }
        public double Valor { get => valor; set => valor = value; }
        public double SalarioVend { get => salarioVend; set => salarioVend = value; }
        public double Comissao { get => comissao; set => comissao = value; }
        public int QtdCarVend { get => qtdCarVend; set => qtdCarVend = value; }
        public double ValorCarro { get => valorCarro; set => valorCarro = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public int QtdBr { get => qtdBr; set => qtdBr = value; }


        // metodos
        public double Conversor(double x, double y)
        {
            double res;
            res = x / y;
            return (res);
        }
        public double ConvertTemp(double x)
        {
            //C = (F – 32) / 1.8
            double y;
            return (y = (x - 32) / 1.8);
        }
        public double NewSal(double x)
        {
            return x + (x * 0.06);
        }
        public double Rendimento(double x)
        {
            return x + (x * (0.049 / 100));
        }
        public int AnosVida(int x)
        {
            return x * 365;
        }
        public int TotalAnos(int x, int y)
        {  //tot para capturar o valor final
            int tot = 0;
            for (int i = x; i < y; i++)
            {   // auxiliar recebe o ano atual
                int aux = i;
                if (aux % 4 == 0)
                {   // total e invrecementado mais um sepre que o ano for bixessto
                    tot++;
                }
            }
            return tot;
        }
        public bool VotosBr()
        {

            if (VotosVal + VotosNul <= TotalHab)
            {
                VotosBran = TotalHab - (VotosVal + VotosNul);
                Console.WriteLine();
                Console.WriteLine("Ao final da eleição a apuração dos votos ficou: ");
                double votVal = (VotosVal * 100) / TotalHab;
                double votBra = (VotosBran * 100) / TotalHab;
                double votNul = (VotosNul * 100) / TotalHab;
                Console.WriteLine("Votos válidos: " + votVal + "%");
                Console.WriteLine("Votos nulos: " + votNul + "%");
                Console.WriteLine("Votos brancos: " + votBra + "%");
                return true;
            }

            return false;
        }
        public double PercDeReajuste(double x, double y)
        {// calculo do novo salario com o reajuste
             return x+(x*(y/100));
        }
        public double valorVeiculo(double x)
        {// cálculo para valor final do veículo
            double y = 0.45,z = 0.28;
            return x = x+(x*y)+(x*z);
        }
        public double ValorTotVend(double valor, int qtd)
        {//total de vendas
            return valor*qtd;
        }
        public double ValorPorCarro(double sal,double coms,double valCar)
        {
            sal = 2000;
            coms = 0.05;
            return sal+(valCar*coms);
        }
        public double Parcelas(double val, int qtd)
        {
            return val/qtd;
        }
        public double totalVendas(double paes,double broa)
        {
            // total de vendas padaria
            double valorP = 0.50, valorB = 4.50;
            return (paes*valorP)+(broa*valorB);
        }
        public double TotalGas (double x,double y)
        {
            return x*y;
        }
        public bool ParPerf(int x,int y)
        {
            if(x == y)
            {
                Console.WriteLine("Esse é seu par perfeito!!!  =D");
                return true;
            }
            else
            {
                Console.WriteLine("Afaste-se do seu inimigo!!! =(");
                return false;
            }
            
        }

        // cabecalhos dos exercicios
        public void CabecalhoEx1()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|           PROGRAMA PARA CONVERTER SUA MESADA DE REAIS PARA DÓLARES                   |");
            Console.WriteLine("========================================================================================");
            
        }
        public void CabecalhoEx3()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|               PROGRAMA PARA CONVERTER GRAUS FAHRENHEIT EM CELSIUS                    |");
            Console.WriteLine("========================================================================================");

        }
        public void CabecalhoEx4()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|       PROGRAMA PARA CALCULAR O SALÁRIO DO FUNCONÁRIO APÓS UM REAJUSTE DE 6%          |");
            Console.WriteLine("========================================================================================");

        }
        public void CabecalhoEx5()
        {
            Console.WriteLine("================================================================================================");
            Console.WriteLine("| PROGRAMA PARA CALCULAR O REDIMENTO DE UM INVESTIMENTO NA POUPANÇA COM UMA TAXA DE 0,049% A.M.| ");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Informe o valor do depósito R$: ");
        }
        public void CabecalhoEx6()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|           PROGRAMA PARA CALCULAR QUANNTOS DIAS DE VIDA UMA PESSOA POSSUI             |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Informe seu ano de nascimento: ");
        }
        public void CabecalhoEx7()
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("| PROGRAMA PARA INFORMAR A POPULAÇÃO DE UMA CIDADE E PORCENTAGEM DE VOTOS DESTA POPULAÇÃO |");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Informe o número de habitantes da cidade: ");
        }
        public void CabecalhoEx8()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|    PROGRAMA PARA CÁLCULAR O SALÁRIO DE ACORDO COM OS DADOS INSERIDOS PELO USUÁRIO    |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Informe o salário do funcionário R$: ");
        }
        public void CabecalhoEx9()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|          PROGRAMA PARA CÁLCULAR O CUSTO DE FÁBRICA DE UM VEÍCULO AO USUÁRIO          |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Informe o custo de fábrica do novo veículo R$: ");
        }
        public void CabecalhoEx10()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|     PROGRAMA PARA CÁLCULAR O SALÁRIO FINAL DO VENDEDOR E O VALOR TOTAL DE VENDAS     |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Informe o número de veículo(s) vendido(s): ");

        }
        public void CabecalhoEx11()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|             PROGRAMA PARA CÁLCULAR AS PARCELAS DA LOJA MAMÃO COM AÇÚCAR              |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Informe o valor da compra R$: ");

        }
        public void CabecalhoEx12()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("| PROGRAMA ONDE PREÇO DO PRODUTO TERÁ UM ACRESCIMO DE ACORDO COM O PERCENTUAL INFORMADO |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Informe o valor de custo do Produto R$: ");

        }
        public void CabecalhoEx13()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|                                   SISTEMA HOT PÃO                                     |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|         Este sistema permite visualizar o total ganho ao fnal do dia e informar       |");
            Console.WriteLine("|                            o valor que deve ser depositado                            |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Informe a quatidade de pães vendida: ");
            

        }
        public void CabecalhoEx14()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|                                 SISTEMA POSTO DE GASOLINA                             |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|     Este sistema permite ler o preço do litro da gasolina e o valor do pagamento      | ");
            Console.WriteLine("|                  e exibir quantos litros ele conseguiu colocar no tanque              |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Informe  o valor a ser gasto: ");


        }
        public void CabecalhoEx15()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|                                 PROGRAMA PAR PERFEITO                                 |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|     Você e seu par devem inserir um número entre 1 e 10. Se ambos forem iguais        | ");
            Console.WriteLine("|                            você descobriu seu par perfeito                            |");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Informe um número(entre 1 e 10): ");


        }







        public void Mensagem()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|   Se sua mesada em dólares for maior que US$ 100, 00 escreva:Vou comprar bitcoin;.   |");
            Console.WriteLine("|        Se for maior que US$ 200, 00 escreva: Vou investir no tesouro nacional.       |");
            Console.WriteLine("|                  Se for menor que U$100, 00 escreva:Vou comprar bala.                |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Ou seja:");
        }
        public void Cabecalho1()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("|                            Lista de exercicios do 1 ao 15                            |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("| 1 - Exercicios 1 e 2 (Conversor de Mesada e mensagem de aplicação do dinheiro)       |");
            Console.WriteLine("| 3 - Converção de Fahrenheit em Celsius                                               |");
            Console.WriteLine("| 4 - Calcular e escrever o valor do novo salário com reajuste de 6%                   |");
            Console.WriteLine("| 5 - Cálculo de investimento na poupança com taxa de 0,049 a.m.                       |");
            Console.WriteLine("| 6 - Cálculo de quantos dias uma pessoa possui de vida                                |");
            Console.WriteLine("| 7 - Calcular e exibir o total de eleitores de uma cidade e a porcentagem de votos    |");
            Console.WriteLine("| 8 - Calcular o reajuste do salário com base em informações adicionadas pelo usuário  |");
            Console.WriteLine("| 9 - Ler o custo de fábrica de um carro, calcular eescrever o custo final             | ");
            Console.WriteLine("|10 - Calcular o salário final do funcionário de uma revendedora de carros usados      | ");
            Console.WriteLine("|11 - Exibir o número de parcelas da loja Mamão com Açúcar                             | ");
            Console.WriteLine("|12 - Programa para receber um percentual de aumento para um produto                   | ");
            Console.WriteLine("|13 - Programa para ler as quantidades de pães e de broas, e depois calcular os dados  | ");
            Console.WriteLine("|14 - Programa para visualizar a quantidade de gasolina pode ser inserida              | ");
            Console.WriteLine("|15 - Programa par perfeito                                                            | ");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Escolha uma das opções para visitar o exercicio: ");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_DS__Exercicio1_Bruno_TDS_02_
{
    class Class1
    {
        // atributos exercicio 1
        private double reais, dolar;
       

        // atributos ex 5
        private double salario;

        // atributos ex 6
        private int idade;
        private int anoAtual;
        private int anoNasc;
        private int total;

        // atributos ex 7
        private int totalHab;
        private int votosVal, votosNul,votosBran;

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
            return (y = (x-32)/1.8);
        }
        public double NewSal(double x)
        {             
            return x+(x*0.06);
        }
        public double Rendimento(double x)
        {            
            return x+(x*(0.049/100));
        }
        public int AnosVida(int x)
        {                     
            return x*365;
        }
        public int TotalAnos(int x, int y)
        {  //tot para capturar o valor final
            int tot = 0;
           for (int i=x; i < y; i++)
            {   // auxiliar recebe o ano atual
                int aux = i;
                if(aux % 4 == 0)
                {   // total e invrecementado mais um sepre que o ano for bixessto
                    tot++;
                }
            }            
            return tot;
        }

        public bool VotosBr ()
        {
            
            if (VotosVal+VotosNul <= TotalHab)
            {
                VotosBran = TotalHab - (VotosVal + VotosNul);
                Console.WriteLine();
                Console.WriteLine("Ao final da eleição a apuração dos votos ficou: ");
                double votVal = (VotosVal * 100) / TotalHab;
                double votBra = (VotosBran * 100) / TotalHab;
                double votNul = (VotosNul * 100) / TotalHab;
                Console.WriteLine("Votos válidos: "+ votVal+"%");
                Console.WriteLine("Votos nulos: " + votNul + "%");
                Console.WriteLine("Votos brancos: " + votBra + "%");
                return true;
            }
            
            return false;
        }
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
            Console.WriteLine("| 7 - Cálcular e exibir o total de eleitores de uma cidade e a porcentagem de votos    |");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Escolha uma das opções para visitar o exercicio: ");

        }
    }
}

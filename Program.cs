using System;

namespace POO_TarefaVetoresHotel
//Hotel com 10 quartos para alugar.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do vetor Hospede, limitando em 10
            Hospede[] vect = new Hospede[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());  //Recebe do usuário a informação de quantidade de hóspedes a receber
            for (int i = 1; i <= n; i++)    //Faz um laço para solicitar os dados conforme a quantidade de hóspedes informada 
            {
                Console.WriteLine();
                Console.WriteLine("Hóspede: "+i);   //Informa a sequência de entrada dos hóspedes
                Console.Write("Nome: ");            //Solicita o nome do hóspede
                string nome = Console.ReadLine();   
                Console.Write("Email: ");           //Solicita seu e-mail
                string email = Console.ReadLine();
                Console.Write("Quarto: ");          //Solicita o número do quarto onde será hospedado
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hospede(nome, email);    //Vetor quarto recebe os nomes e e-mails dos hóspedes
            }
            Console.WriteLine();
            //Informa a ocupação dos quartos de forma ordenada
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)    //Faz um laço para verficar os quartos ocupados
            {
                if (vect[i] != null)    //Se o vetor não estiver vazio, informará o conteúdo dele, sequencialmente
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            Console.WriteLine("============================");

            Console.WriteLine("Ocupação Geral dos Quartos:");
            for (int i = 0; i < 10; i++)    //Faz um laço para verficar os quartos ocupados
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
        }
    }
}

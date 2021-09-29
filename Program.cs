using System;

namespace appsSENAI
{
    class Program
    {
        static void re(string[] args)
        {
            int idade;
            string nome;
            Console.WriteLine("Qual a sua idade? ");
            Console.Write("Resposta: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu nome? ");
            Console.Write("Resposta: ");
            nome = Console.ReadLine();
            Console.WriteLine("A sua idade é " + idade + " E seu nome é " + nome);
            Console.ReadLine();
        }
    }
}

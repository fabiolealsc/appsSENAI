using System;

class codulos{
    static void Main(String[] args){
        Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());
        string resp = VerificarParImpar(numero);
        Console.WriteLine(resp);
        Console.Read();
    }
    static public string VerificarParImpar(int n){
        if (n % 2 == 0){
            return "Par";
        }
        else{
            return "Ímpar";
        }
    }

}
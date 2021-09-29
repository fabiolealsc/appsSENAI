using System;


class repit
{
    static void Main(string[] args)
    {
        int [] vetor = {5,4,23,4,6,23,1,2};
        int i;
        for(i=0; i < vetor.Length; i++){
            Console.WriteLine("O valor do vetor na posição ["+i+"] é "+vetor[i]);
        }
        Console.Read();
    }
}

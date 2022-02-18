using System;

namespace DiamanteAlfabeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z', 'Y', 'Z' };
            int posicao = 0, esquerda = 0, direita = 0;

            Console.WriteLine("Digite uma letra: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            //localiza qual a posicao da letra escolhida
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (letra == alfabeto[i])
                {
                    posicao =i;
                    direita = i;
                    esquerda = i;
                }
            }
            //o primeiro for é o da linha o segundo o da coluna
            for (int i = 0; i < posicao; i++)
            {
                for (int j = 0; j <= posicao*2; j++)
                {
                    if (direita == j && esquerda == j)
                    {
                        Console.Write(alfabeto[i]);
                    }
                    else if(direita == j){
                        Console.Write(alfabeto[i]);
                    }else if (esquerda == j){
                        Console.Write(alfabeto[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                direita--; esquerda ++;
                Console.WriteLine();
            }
            //o primeiro for é o da linha o segundo o da coluna
            for (int i = posicao; i >= 0; i--)
            {
                for (int j = 0; j <= posicao*2; j++)
                {
                    if (direita == j && esquerda == j)
                    {
                        Console.Write(alfabeto[i]);
                    }else if (direita == j)
                    {
                        Console.Write(alfabeto[i]);
                    }else if(esquerda == j)
                    {
                        Console.Write(alfabeto[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                direita++; esquerda--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
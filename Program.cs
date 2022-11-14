using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            // por padrão o add só adiciona ao final da lista
            list.Add("Leonardo");
            list.Add("Rafael");
            list.Add("Michelangelo");
            list.Add("Ryu");
            list.Add("Joe");
            list.Add("Mitsurugi");

            // insert vc pode especificar qual a posição que vc quer inserir 
            list.Insert(2, "Donatello");
            list.Insert(4, "Matheus");



            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Mostrar o tamanho da list com a propeiedade Count
            Console.WriteLine();
            Console.WriteLine("List count: " + list.Count);



            Console.WriteLine();
            // Encontrar na lista a primeira ocorrencia de um nome que começa com a letra M
            string s1 = list.Find(x => x[0]=='M'); // Lambda, uma função anônima
            // objeto x(parâmetro da função, string x) tal que x na posição 0 seja igual ao caracter M
            Console.WriteLine("Primeiro com a letra M: " + s1);


            Console.WriteLine();
            // Ultima ocorrencia que começa com a letra M
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Ultimo com a letra M: " + s2);


            Console.WriteLine();
            // Encontrar o primeira ou ultima posição de elemento da lista
            // Posição é utilizado int por ser um numero inteiro
            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Primeira posição começando com M: " +pos1);


            Console.WriteLine();
            // posoção do ultimo elemento que começa com M
            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Ultima posição começando com M: " + pos2);


            Console.WriteLine();
            // Filtrar a lista com os nomes que tem 5 caracteres
            // Para filtrar uma lista é preciso criar uma lista
            List<string> list2 = list.FindAll(x => x.Length == 6);
            Console.WriteLine();
            foreach (string obj in list2)
            {
                Console.WriteLine("Nomes com apenas 6 letras");
                Console.WriteLine(obj);
            }


            Console.WriteLine();
            // Remover elementos da Lista, Remove espera como parametro uma string
            list.Remove("Matheus");
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            // Remover todos elementos da Lista, RemoveAll espera como parametro um predicado
            list.RemoveAll(x => x[0]=='M');
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine();
            // Remover elementos da Lista por posição, RemoveAt espera como parametro uma posição
            list.RemoveAt(2);
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine();
            // Remover os elementos de uma faixa, RemoveRange espera como parametro uma contagem
            // A partir da posição 2 eu quero remover 2 elementos
            list.RemoveRange(2, 2);
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}

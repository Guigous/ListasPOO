using System;
using System.Collections.Generic;

namespace ListasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista de strings
            List<string> list = new List<string>();
            //Adiciono elementos na lista
            list.Add("Fabio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");
            //Adiciona um elemento na posição sugerida
            list.Insert(2, "Lucas");

            List<string> list2 = new List<string>();
            list2.Add("Fabio"); list2.Add("Wilson"); list2.Add("Angelina"); list2.Add("Eliney"); list2.Add("Andre");
            list2.Insert(2, "Lucas");




            foreach (string obj in list)
            {
                //Conto quantos elementos tem na minha lista
                Console.WriteLine("Qnt de elementos na Lista: " + list.Count);
                //Encontrar o elemento que inicia com a letra A com uma função lambda
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Encontrar o último elemento que inicia com a letra A, com uma função lambda
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Ultimo elemento que começa com a letra A: " + s2);
                //Buscar elementos pela sua posição
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("Primeira Posição de A: " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Última Posição de ‘A’: " + pos2);
                //Buscar todos os elementos com tamanho igual a 5 caracteres



            }
            foreach (string obj in list2)
            {
                //Buscar todos os elementos com tamanho igual a 5 caracteres
                list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("-------------------------------");
                Console.WriteLine(obj);



            }
        }
    }
}


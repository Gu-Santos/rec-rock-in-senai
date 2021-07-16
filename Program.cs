using System;
using System.Collections.Generic;

namespace rock_in_senai_tarde
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta_responsavel;
            bool cadastros = true;

            List<string> inscritos = new List<string>();
            
            do
            {
                Console.WriteLine("Qual o seu nome?");
                string nome = Console.ReadLine();

                Console.WriteLine(@"Insira a sua idade para se inscrever aos shows do Rock in SENAI!");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 16)
                {
                    Console.WriteLine("Parabéns! Sua inscrição foi feita!\n");
                    inscritos.Add(nome);
                }
                else
                {
                    Console.WriteLine("Você vai ao show com algum responsável??s/n");
                    resposta_responsavel = Console.ReadLine();

                    if (resposta_responsavel == "s")
                    {
                        Console.WriteLine("Então você pode ir com o seu resposável!\n");
                        inscritos.Add(nome);
                    }
                    else
                    {
                        Console.WriteLine("Você não tem a idade para ir ao evento sozinho, e não pode ir sem um resposável!\n");
                    }
                }

                Console.WriteLine("Deseja cadastrar mais uma pessoa?s/n");
                string continuar_cadastro = Console.ReadLine();
                if (continuar_cadastro == "n")
                {
                    cadastros = false;
                }else
                {
                    cadastros = true;
                }

            } while (cadastros);

            foreach (var item in inscritos)
            {
                Console.WriteLine("Pessoas inscritas: \n" + item);
            }
        }
    }
}

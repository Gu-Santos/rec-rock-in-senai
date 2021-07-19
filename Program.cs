using System;
using System.Collections.Generic;

namespace rock_in_senai_tarde
{
    class Program
    {
            static List<string> inscritos = new List<string>();
        static void Main(string[] args)
        {

            bool menu = true;
            do
            {
            
            Console.WriteLine("\nDigite 1 para se inscrever, ou digite 2 para mostrar a lista de inscritos");
            string resposta_menu = Console.ReadLine();
            
            if (resposta_menu == "1")
            {
                sistema_cadastro();
            }
            else
            {
                mostrar_lista();
            }

            } while (menu);
        }


        static bool sistema_cadastro()
        {
            string resposta_responsavel;
            bool cadastro = true;
            bool cadastro_feito = true;

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
                    cadastro_feito = true;
                }
                else
                {
                    Console.WriteLine("Você vai ao show com algum responsável??s/n");
                    resposta_responsavel = Console.ReadLine();

                    if (resposta_responsavel == "s")
                    {
                        Console.WriteLine("Então você pode ir com o seu resposável!\n");
                        inscritos.Add(nome);
                        cadastro_feito = true;
                    }
                    else
                    {
                        Console.WriteLine("Você não tem a idade para ir ao evento sozinho, e não pode ir sem um resposável!\n");
                        cadastro_feito = false;
                    }
                }

                Console.WriteLine("Deseja cadastrar mais uma pessoa?s/n");
                string continuar_cadastro = Console.ReadLine();

                if (continuar_cadastro == "n")
                {
                    cadastro = false;
                }
                else
                {
                    cadastro = true;
                }

            } while (cadastro);

            return cadastro_feito;
        }

        static void mostrar_lista()
        {

            foreach (var item in inscritos)
            {
                Console.WriteLine("Pessoas inscritas: \n" + item);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using PresidentesBr.Model;
using PresidentesBr.Model.Enums;
using PresidentesBr.Interface;


namespace PresidenteBr.Presentation
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("OS DONOS DO PAU BRASIL\n======================\n\nLista dos Líderes do país desde a sua descoberta.\n==================================================\n\n");
            Console.WriteLine("OUVIRAMDOIRPIRANGAASMARGENSPLACIDAS");
            Console.WriteLine("DEUMPOVOHEROICO  OBRADORETUMBANTEEO");
            Console.WriteLine("SOLDALIBERDAD      DEEMRAIOSFULGIDO");
            Console.WriteLine("SBRILHOUNOC    EU    DAPATRIANESSEE");
            Console.WriteLine("INSTANTES     EOPE     NHORDESSAILG");
            Console.WriteLine("UALDADECONS    EG    IMOSCONSQUISTA");
            Console.WriteLine("RCOMBRACOFORT      EEMTEUSEIOOLIBER");
            Console.WriteLine("DADEDESAFIAONOS  SSOPEITOAPROPRIAMO");
            Console.WriteLine("TEOPATRIAAMADAIDOLATRADASALVESALVE!");

            Console.WriteLine("\n\nDigite sua Opção\n1 - Monarcas do Brasil\n2 - Presidentes do Brasil");
            int userOption = Convert.ToInt32(Console.ReadLine());

            if (userOption == 1)
            {
                Console.Clear();
                Monarquia();
            }
            else if (userOption == 2)
            {
                Console.Clear();
                Republica();

            }
            else
            {
                InvalidOption();
            }
        }
        static void Toolbar()
        {
            Console.WriteLine("\n==================================================================================");
            Console.WriteLine("\n (X) Sair | (I) Menu inicial | (M) Consultar Monarcas | (P)Consultar Presidentes ");
            Console.WriteLine("\n==================================================================================\n");
        }
        static void Continue()
        {
            Console.WriteLine("\n===========================\nDeseja fazer nova consulta?\n S - Sim | N - Não");
            string reset = Console.ReadLine();
            if (reset == "s" || reset == "S")
            {
                Main();
            }
            else
            {
                Goodbye();
            }
        }
        static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("Obrigado pela preferência!");
            System.Environment.Exit(0);
        }
        static void InvalidOption()
        {
            Console.WriteLine("\nVocê digitou um valor que não é um número entre as opções!");
            Continue();
        }
        static void Sorry()
        {
            Console.WriteLine("\nDesculpe! Ainda estamos trabalhando nisso!");
        }
        static void Monarquia()
        {

            List<Monarca> monarcas = new List<Monarca>();

            monarcas.Add(new Monarca("Dom Manuel I", "O Venturoso", "22 de Abril de 1500", 1500, "13 de Dezembro de 1521", 1521, "31 de Maio de 1469 - Alcochete, Portugal", "13 de Dezembro de 1521 - Lisboa, Portugal", Dinastia.Avis, Reinado.Colonial));
            monarcas.Add(new Monarca("Dom João III", "O Piedoso", "13 de Dezembro de 1521", 1521, "11 de Junho de 1557", 1557, "06 de junho de 1502 - Lisboa, Portugal", "11 de junho de 1557 - Lisboa, Portugal", Dinastia.Avis, Reinado.Colonial));

            MonarquiaTitle();

            Console.WriteLine("\n\nDigite sua Opção:\n1 - Monarcas por ordem\n2 - Monarcas por dinastias\n3 - Monarcas por reinado\n4 - Consultar uma data");
            int userOption = Convert.ToInt32(Console.ReadLine());
            if (userOption == 1)
            {
                MonarquiaTitle();
                foreach (Monarca rei in monarcas)
                {

                    Console.WriteLine(rei);
                }
                Continue();
            }
            else if (userOption == 2)
            {
                MonarquiaTitle();
                Console.WriteLine("\n\nEscolha uma dinastia:\n 1 - Avis\n 2 - Habsburgo\n 3 - Bragança");
                int userOptionMonarchy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(userOptionMonarchy);
                Sorry();
                Continue();
            }
            else
            {
                InvalidOption();
            }

        }

        static void MonarquiaTitle()
        {
            Console.Clear();
            Toolbar();
            Console.WriteLine("MONARQUIA NO BRASIL\n====================\n\nO Período monárquico Brasileiro foi de 22 de Abril de 1500 até 15 de Novembro de 1889.\nEssas datas te lembram alguma coisa?\n======================================================================================\n");
        }
        static void PutDateMonarchy()
        {
            string option = Console.ReadLine();
            bool sucess = Int32.TryParse(option, out int select);

            if (sucess && select >= 1889 && select >= 2021)
            {
                Sorry();
                Continue();
            }
            else if (sucess && select < 1889)
            {
                Console.WriteLine("Ani ndepochy");
                Console.WriteLine("Ñomongeta mávapa pe tekotevẽ peteĩha");
                Console.WriteLine("\nO Brasil ainda não era indepente nessa época.\n\nTente monarquia");
                
                Continue();
            }
            else
            {
                Fail();
            }



        }


        static void Republica()
        {
            List<Presidente> presidentes = new List<Presidente>();

            presidentes.Add(new Presidente(1, "Deodoro da Fonseca", "Manuel Dedoro da Fonseca", EMandato.Indiretamente, ERepublica.Primeira, "15 de novembro de 1889", 1889, "23 de novembbro de 1891", 1891, "05 de agosto de 1827 - Alagoas da Lagoa do Sul,Alagoas", "23 de agosto de 1892 - Rio de janeiro,DF", "Militar", "Mariana da Fonseca", "Sem partido"));
            presidentes.Add(new Presidente(2, "Floriano Peixoto", "Floriano Vieira Peixoto", EMandato.Sucessao, ERepublica.Primeira, "23 de novembro de 1891", 1891, "15 de novembro de 1894", 1894, "30 de abril de 1839 - Maceió, Alagoas", "29 de junho de 1895 - Barra Mansa, Rio de Janeiro", "Militar", "Josina peixoto", "Nenhum"));

            // int getStartYear = presidentes[0].startYear;
            // int lastIndex = presidentes.Count - 1;
            // int getEndYear = presidentes[lastIndex].endYear;
            // int GetDate(int getStartYear, int getEndYear)
            // {
            //     return PutDate(this.getStartYear, this.getEndYear);
            // }
            RepublicaTitle();
            Console.WriteLine("\n\nDigite sua Opção:\n1 - Presidentes por ordem\n2 - Presidentes por período\n3 - Presidentes por ascendência \n4 - Consultar uma data");
            int userOption = Convert.ToInt32(Console.ReadLine());
            if (userOption == 1)
            {
                RepublicaTitle();
                foreach (Presidente pres in presidentes)
                {
                    Console.WriteLine($"\n{pres.QuickList(pres.shortName, pres.career, pres.arrival, pres.conclusion)}");
                }
                Continue();
            }
            else if (userOption == 2)
            {
                RepublicaTitle();
                Console.WriteLine("\n\nEscolha um periodo:\n 1 - República Velha (1889 a 1930)\n 2 - Segunda República(1930 a 1937)\n 3 - Estado Novo(1937 a 1946)\n 4 - Republica Populista(1946 a 1964)\n 5 - Ditadura Militar(1964 a 1985)\n 6 - Nova República(1985 a 2022)");
                int userOptionRepublic = Convert.ToInt32(Console.ReadLine());
                Sorry();
                Continue();
            }
            else if (userOption == 3)
            {
                RepublicaTitle();
                Console.WriteLine("\n\nEscolha um modo de ascensão:\n 1 - Eleições diretas\n 2 - Linha sucessória\n 3 - Eleições indiretas, emposse ou golpe\n 4 - Impedidos ou falecidos antes do empossamento");
                int userOptionRepublic = Convert.ToInt32(Console.ReadLine());
                Sorry();
                Continue();

            }
            else if (userOption == 4)
            {
                RepublicaTitle();
                PutDateRepublic();
            }
            else
            {
                InvalidOption();
            }


        }
        static void RepublicaTitle()
        {
            Console.Clear();
            Toolbar();
            Console.WriteLine("REPUBLICA FEDERATIVA DO BRASIL\n==============================\n\nO Período democrático Brasileiro foi de 15 de Novembro de 1889 até 31 de dezembro de 2022.\nEssas datas te lembram alguma coisa?\n===========================================================\n");

        }
        static void PutDateRepublic()
        {
            Console.WriteLine("\nInsira uma ano entre 1889 e 2022");
            string option = Console.ReadLine();
            bool sucess = Int32.TryParse(option, out int select);

            if (sucess && select >= 1889 && select <= 2022)
            {
                Sorry();
                Continue();
            }
            else if (sucess && select < 1889)
            {
                Console.WriteLine("\nO Brasil ainda não era indepente nessa época.\n\nTente (M)onarquia");
                Console.WriteLine("\n\n\"Pedro, se o Brasil se separar, antes seja para ti, que me hás de respeitar, do que para algum desses aventureiros\" - Dom joao VI");
                Continue();
            }
            else if (sucess && select > 2022)
            {
                Console.WriteLine("\nVocê inseriu uma data no futuro.\n\nProvalvemente não teremos mais democracia nesta época, nem votação digital.");
                PutDateRepublic();
            }
            else if (option == "X" || option == "x")
            {
                Goodbye();
            }
            else if (option == "I" || option == "i")
            {
                Main();
            }
            else if (option == "M" || option == "m")
            {
                Monarquia();
            }
            else if (option == "P" || option == "p")
            {
                Republica();
            }
            else
            {
                Fail();
            }



        }


        static void Fail()
        {
            RepublicaTitle();
            InvalidOption();
        }

    }
}
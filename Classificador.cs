﻿using System;

namespace Classificador_de_nível_de_Herói
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Boas vindas ao usuário, acrescentando a característica "Nome" ao Objeto "Herói"
                Console.WriteLine("Olá, Herói! Bem vindos ao seu Classificador de nível!");
                Console.WriteLine("Primeiramente, digite o nome do seu personagem:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Bem vindo, {nome}!");

                // Inserção de valor int para level do herói. Estrutura de repetição garantindo uma entrada válida. 
                int xp;
                do
                {
                    Console.WriteLine("Agora, me informe o lvl atual do seu personagem:");
                } while (!int.TryParse(Console.ReadLine(), out xp) || xp < 0);

                // Algoritmo de classificação do herói pelo Level usando enums
                Nivel nivel = ClassificarNivel(xp);

                Console.WriteLine($"Certo. Você tem {xp} XP. Você está fazendo progresso!");
                Console.WriteLine();
                Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");

                Console.WriteLine("Deseja verificar o nível de outro herói? (S/N)");
            } while (Console.ReadLine().ToUpper() == "S");
        }

        // Enum para representar os diferentes níveis
        enum Nivel
        {
            Ferro,
            Bronze,
            Prata,
            Ouro,
            Platina,
            Ascendente,
            Imortal,
            Radiante
        }

        // Função para classificar o nível do herói
        static Nivel ClassificarNivel(int xp)
        {
            if (xp <= 1000) return Nivel.Ferro;
            if (xp <= 2000) return Nivel.Bronze;
            if (xp <= 5000) return Nivel.Prata;
            if (xp <= 7000) return Nivel.Ouro;
            if (xp <= 8000) return Nivel.Platina;
            if (xp <= 9000) return Nivel.Ascendente;
            if (xp <= 10000) return Nivel.Imortal;
            return Nivel.Radiante; // Se não satisfizer nenhuma das condições anteriores, o nível é Radiante.
        }
    }
}

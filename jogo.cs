using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            int li;
            int ls;
            int oculto;
            int palpite;
            int jogador;
            
            do
            {
                Console.WriteLine("Digite um valor entre 1 e 100:");
                oculto = int.Parse(Console.ReadLine());
            }
            while ((oculto <=1) || (oculto >= 100));
            Console.Clear();
            //inicio do jogo
            jogador = 1;
            li = 1;
            ls = 100;
            do
            {
                do
                {
                    Console.WriteLine("Jogador {0} digite o n° entre {1} e {2}: ", jogador, li, ls);
                    palpite = int.Parse(Console.ReadLine());
                }
                while ((palpite <= li) || (palpite >= ls));

                if (palpite == oculto)
                    Console.WriteLine("Parabéns jogador {0} você perdeu", jogador);
                else
                {
                    if (palpite < oculto)
                        li = palpite;
                    else ls = palpite;
                }
                jogador = jogador + 1;

                if (jogador > 2)
                    jogador = 1;
            }
            while (palpite != oculto);
            
            
                   

                        

                




                


        }
    }
}

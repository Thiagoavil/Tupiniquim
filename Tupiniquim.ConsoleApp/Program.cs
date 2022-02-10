using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comandorecebido = "";
            string[] posicaoinicial;
            string lado = "";
            int posicaox = 0;
            int posicaoy = 0;
            int posicaoxmax = 0;
            int posicaoymax = 0;
            string[] posicaomaxt ;

            Console.Write("Digite a dimensão X Y máxima: ");
            posicaomaxt = Console.ReadLine().Split(" ");


            posicaoxmax = Convert.ToInt32(posicaomaxt[0]);
                        
            posicaoymax = Convert.ToInt32(posicaomaxt[1]);

            for (int contador = 0; contador < 2; contador++)
            {
                
                
                    Console.WriteLine("\n Projeto tupiniquim");
                    Console.WriteLine("Digite suas cordenadas: ");

                    posicaoinicial = Console.ReadLine().Split(" ");

                    for (int i = 0; i < posicaoinicial.Length; i++)
                    {
                        if (i == 0)
                            posicaox = Convert.ToInt32(posicaoinicial[i]);
                        else if (i == 1)
                            posicaoy = Convert.ToInt32(posicaoinicial[i]);
                        else if (i == 2)
                            lado = posicaoinicial[i];


                    }

                    Console.WriteLine("Digite o comando: ");
                    comandorecebido = Console.ReadLine();


                

                foreach (char comando in comandorecebido.ToCharArray())

                {

                    if (comando == 'e' && lado == "n")
                    {
                        lado = "o";
                    }
                    else if (comando == 'e' && lado == "o")
                    {
                        lado = "s";
                    }
                    else if (comando == 'e' && lado == "s")
                    {
                        lado = "l";
                    }
                    else if (comando == 'e' && lado == "l")
                    {
                        lado = "n";
                    }



                    if (comando == 'd' && lado == "n")
                    {
                        lado = "l";
                    }
                    else if (comando == 'd' && lado == "o")
                    {
                        lado = "n";
                    }
                    else if (comando == 'd' && lado == "s")
                    {
                        lado = "o";
                    }
                    else if (comando == 'd' && lado == "l")
                    {
                        lado = "s";
                    }




                    if (comando == 'm' && lado == "n")
                    {
                        posicaoy++;
                    }
                    else if (comando == 'm' && lado == "o")
                    {
                        posicaox--;
                    }
                    else if (comando == 'm' && lado == "s")
                    {
                        posicaoy--;
                    }
                    else if (comando == 'm' && lado == "l")
                    {
                        posicaox++;
                    }



                }
                Console.WriteLine("O robo está na posição: " + posicaox + " " + posicaoy + " " + lado);
            }
        }
    }
}
